using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Float")]
    public class EventListenerFloat : EventListener<float>
    {
        public override bool PassedEventCondition(float value)
        {
            return eventCondition switch
            {
                EventCondition.none => true,
                EventCondition.equalTo => value == compareValue,
                EventCondition.notEqualTo => value != compareValue,
                EventCondition.greaterThen => value > compareValue,
                EventCondition.lesserThen => value < compareValue,
                EventCondition.greaterOrEqual => value >= compareValue,
                EventCondition.lesserOrEqual => value <= compareValue,
                _ => false
            };
        }
    }
}
