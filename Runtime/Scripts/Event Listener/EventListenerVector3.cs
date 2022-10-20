using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Vector3")]
    public class EventListenerVector3 : EventListener<Vector3>
    {
        public override bool PassedEventCondition(Vector3 value)
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

                EventCondition.equalToZ => value.z == compareValue.z,
                EventCondition.notEqualToZ => value.z != compareValue.z,
                EventCondition.greaterThenZ => value.z > compareValue.z,
                EventCondition.lesserThenZ => value.z < compareValue.z,
                EventCondition.greaterOrEqualToZ => value.z >= compareValue.z,
                EventCondition.lesserOrEqualToZ => value.z <= compareValue.z,

                _ => false
            };
        }
    }
}
