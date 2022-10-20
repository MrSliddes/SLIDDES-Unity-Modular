using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener List")]
    public class EventListenerList : EventListener<List<ScriptableObject>>
    {
        public override bool PassedEventCondition(List<ScriptableObject> value)
        {
            return eventCondition switch
            {
                EventCondition.none => true,
                EventCondition.equalTo => value == compareValue,
                EventCondition.notEqualTo => value != compareValue,
                EventCondition.greaterThen => value.Count > compareValue.Count,
                EventCondition.lesserThen => value.Count < compareValue.Count,
                EventCondition.greaterOrEqual => value.Count >= compareValue.Count,
                EventCondition.lesserOrEqual => value.Count <= compareValue.Count,

                EventCondition.contains => ListContainsValue(value, compareValue),
                EventCondition.containsNot => !ListContainsValue(value, compareValue),                

                EventCondition.countIsEqual => value.Count == compareValue.Count,
                EventCondition.countIsNotEqual => value.Count != compareValue.Count,
                _ => false
            };
        }


        private bool ListContainsValue(List<ScriptableObject> value, List<ScriptableObject> compareValue)
        {
            foreach(var item in compareValue)
            {
                if(value.Contains(item)) return true;
            }
            return false;
        }
    }
}
