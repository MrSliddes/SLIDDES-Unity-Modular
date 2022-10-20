using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Vector2")]
    public class EventListenerVector2 : EventListener<Vector2>
    {
        public override bool PassedEventCondition(Vector2 value)
        {
            return eventCondition switch
            {
                EventCondition.none => true,
                EventCondition.equalTo => value == compareValue,
                EventCondition.notEqualTo => value != compareValue,

                EventCondition.equalToX => value.x == compareValue.x,
                EventCondition.notEqualToX => value.x != compareValue.x,
                EventCondition.greaterThenX => value.x > compareValue.x,
                EventCondition.lesserThenX => value.x < compareValue.x,
                EventCondition.greaterOrEqualToX => value.x >= compareValue.x,
                EventCondition.lesserOrEqualToX => value.x <= compareValue.x,

                EventCondition.equalToY => value.y == compareValue.y,
                EventCondition.notEqualToY => value.y != compareValue.y,
                EventCondition.greaterThenY => value.y > compareValue.y,
                EventCondition.lesserThenY => value.y < compareValue.y,
                EventCondition.greaterOrEqualToY => value.y >= compareValue.y,
                EventCondition.lesserOrEqualToY => value.y <= compareValue.y,

                _ => false
            };
        }
    }
}
