using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Double")]
    public class EventListenerDouble : EventListener<double>
    {
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventCondition eventCondition;
        [Tooltip("The value to compare it too")]
        public double compareValue;

        public override void Invoke(double value)
        {
            bool passed = false;
            switch(eventCondition)
            {
                case EventCondition.none: passed = true; break;
                case EventCondition.equalToo: passed = value == compareValue; break;
                case EventCondition.notEqualToo: passed = value != compareValue; break;
                case EventCondition.greaterThen: passed = value > compareValue; break;
                case EventCondition.lesserThen: passed = value < compareValue; break;
                case EventCondition.greaterOrEqual: passed = value >= compareValue; break;
                case EventCondition.lesserOrEqual: passed = value <= compareValue; break;
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
            [InspectorName(">")]
            greaterThen,
            [InspectorName("<")]
            lesserThen,
            [InspectorName(">=")]
            greaterOrEqual,
            [InspectorName("<=")]
            lesserOrEqual
        }
    }
}
