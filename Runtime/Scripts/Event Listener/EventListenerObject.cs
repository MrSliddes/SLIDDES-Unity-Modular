using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Object")]
    public class EventListenerObject : EventListener<object>
    {
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventCondition eventCondition;
        [Tooltip("The value to compare it too")]
        public ObjectVariable compareValue;

        public override void Invoke(object value)
        {
            bool passed = false;
            switch(eventCondition)
            {
                case EventCondition.none: passed = true; break;
                case EventCondition.equalToo: passed = value == compareValue.Value; break;
                case EventCondition.notEqualToo: passed = value != compareValue.Value; break;
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
            notEqualToo
        }
    }
}
