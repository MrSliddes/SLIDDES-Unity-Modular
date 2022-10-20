using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Decimal")]
    public class EventListenerDecimal : EventListener<decimal>
    {
        [Tooltip("Special inspector field for working with decimal value")]
        public new DecimalSerializable compareValue;

        public override bool PassedEventCondition(decimal value)
        {
            return eventCondition switch
            {
                EventCondition.none => true,
                EventCondition.equalTo => value == compareValue.value,
                EventCondition.notEqualTo => value != compareValue.value,
                EventCondition.greaterThen => value > compareValue.value,
                EventCondition.lesserThen => value < compareValue.value,
                EventCondition.greaterOrEqual => value >= compareValue.value,
                EventCondition.lesserOrEqual => value <= compareValue.value,
                _ => false
            };
        }
    }
}
