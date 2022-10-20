using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Object")]
    public class EventListenerObject : EventListener<object>
    {
        public new Object compareValue;

        public override bool PassedEventCondition(object value)
        {
            return eventCondition switch
            {
                EventCondition.none => true,
                EventCondition.equalTo => value.Equals(compareValue),
                EventCondition.notEqualTo => !value.Equals(compareValue),
                _ => false
            };
        }
    }
}
