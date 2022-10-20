using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Dictionary")]
    public class EventListenerDictionary : EventListener<Dictionary<ScriptableObject, ScriptableObject>>
    {
        public new DictionaryVariableReference compareValue;

        public override bool PassedEventCondition(Dictionary<ScriptableObject, ScriptableObject> value)
        {
            return compareValue.referenceType switch
            {
                DictionaryVariableReference.ReferenceType.variable =>
                    eventCondition switch
                    {
                        EventCondition.none => true,
                        EventCondition.equalTo => value == compareValue.Value,
                        EventCondition.notEqualTo => value != compareValue.Value,
                        _ => false
                    },
                DictionaryVariableReference.ReferenceType.key =>
                    eventCondition switch
                    {
                        EventCondition.none => true,
                        EventCondition.contains => value.ContainsKey(compareValue.key),
                        EventCondition.containsNot => !value.ContainsKey(compareValue.key),
                        _ => false
                    },
                DictionaryVariableReference.ReferenceType.value => 
                    eventCondition switch
                    {
                        EventCondition.none => true,
                        EventCondition.contains => value.ContainsValue(compareValue.value),
                        EventCondition.containsNot => !value.ContainsValue(compareValue.value),
                        _ => false
                    },
                _ => false
            };
        }
    }
}
