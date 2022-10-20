using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener String")]
    public class EventListenerString : EventListener<string>
    {
        public override bool PassedEventCondition(string value)
        {
            return eventCondition switch
            {
                EventCondition.none => true,
                EventCondition.equalTo => value == compareValue,
                EventCondition.notEqualTo => value != compareValue,
                EventCondition.contains => value.Contains(compareValue),
                EventCondition.containsNot => !value.Contains(compareValue),
                _ => false
            };
        }
    }
}
