using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Long")]
    public class EventListenerLong : EventListener<long>
    {
        public override bool PassedEventCondition(long value)
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
