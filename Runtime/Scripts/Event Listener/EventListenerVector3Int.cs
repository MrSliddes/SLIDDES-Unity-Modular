using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Vector3Int")]
    public class EventListenerVector3Int : EventListener<Vector3Int>
    {
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventCondition eventCondition;
        [Tooltip("The value to compare it too")]
        public Vector3Int compareValue;

        public override void Invoke(Vector3Int value)
        {
            bool passed = false;
            switch(eventCondition)
            {
                case EventCondition.none: passed = true; break;
                case EventCondition.equalToo: passed = value == compareValue; break;
                case EventCondition.notEqualToo: passed = value != compareValue; break;
                case EventCondition.equalTooX: passed = value.x == compareValue.x; break;
                case EventCondition.notEqualTooX: passed = value.x != compareValue.x; break;
                case EventCondition.greaterThenX: passed = value.x > compareValue.x; break;
                case EventCondition.lesserThenX: passed = value.x < compareValue.x; break;
                case EventCondition.greaterOrEqualX: passed = value.x >= compareValue.x; break;
                case EventCondition.lesserOrEqualX: passed = value.x <= compareValue.x; break;

                case EventCondition.equalTooY: passed = value.y == compareValue.y; break;
                case EventCondition.notEqualTooY: passed = value.y != compareValue.y; break;
                case EventCondition.greaterThenY: passed = value.y > compareValue.y; break;
                case EventCondition.lesserThenY: passed = value.y < compareValue.y; break;
                case EventCondition.greaterOrEqualY: passed = value.y >= compareValue.y; break;
                case EventCondition.lesserOrEqualY: passed = value.y <= compareValue.y; break;

                case EventCondition.equalTooZ: passed = value.z == compareValue.z; break;
                case EventCondition.notEqualTooZ: passed = value.z != compareValue.z; break;
                case EventCondition.greaterThenZ: passed = value.z > compareValue.z; break;
                case EventCondition.lesserThenZ: passed = value.z < compareValue.z; break;
                case EventCondition.greaterOrEqualZ: passed = value.z >= compareValue.z; break;
                case EventCondition.lesserOrEqualZ: passed = value.z <= compareValue.z; break;
                default: break;
            }
            if(!passed) return;

            Response.Invoke(value);
        }

        /// <summary>
        /// Before the response is invoked, the event has to meet the eventCondition
        /// </summary>
        public enum EventCondition
        {
            [Tooltip("Event allways passes")]
            none,
            [InspectorName("==")]
            equalToo,
            [InspectorName("!=")]
            notEqualToo,
            [InspectorName("X == Value")]
            equalTooX,
            [InspectorName("X != Value")]
            notEqualTooX,
            [InspectorName("X < Value")]
            greaterThenX,
            [InspectorName("X > Value")]
            lesserThenX,
            [InspectorName("X <= Value")]
            greaterOrEqualX,
            [InspectorName("X >= Value")]
            lesserOrEqualX,
            [InspectorName("Y == Value")]
            equalTooY,
            [InspectorName("Y != Value")]
            notEqualTooY,
            [InspectorName("Y < Value")]
            greaterThenY,
            [InspectorName("Y > Value")]
            lesserThenY,
            [InspectorName("Y <= Value")]
            greaterOrEqualY,
            [InspectorName("Y >= Value")]
            lesserOrEqualY,
            [InspectorName("Z == Value")]
            equalTooZ,
            [InspectorName("Z != Value")]
            notEqualTooZ,
            [InspectorName("Z < Value")]
            greaterThenZ,
            [InspectorName("Z > Value")]
            lesserThenZ,
            [InspectorName("Z <= Value")]
            greaterOrEqualZ,
            [InspectorName("Z >= Value")]
            lesserOrEqualZ
        }
    }
}
