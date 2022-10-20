using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener SByte")]
    public class EventListenerSByte : EventListener<sbyte>
    {
        public override bool PassedEventCondition(sbyte value)
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
