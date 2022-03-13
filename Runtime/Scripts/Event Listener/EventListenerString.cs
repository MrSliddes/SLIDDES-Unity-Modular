using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener String")]
    public class EventListenerString : EventListener<string>
    {
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventCondition eventCondition;
        [Tooltip("The value to compare it too")]
        public string compareValue;

        public override void Invoke(string value)
        {
            bool passed = false;
            switch(eventCondition)
            {
                case EventCondition.none: passed = true; break;
                case EventCondition.equalToo: passed = value == compareValue; break;
                case EventCondition.notEqualToo: passed = value != compareValue; break;
                case EventCondition.contains: passed = value.ToLower().Contains(compareValue.ToLower()); break;
                case EventCondition.notContains: passed = !value.ToLower().Contains(compareValue.ToLower()); break;
                case EventCondition.containsCaseSensitive: passed = value.Contains(compareValue); break;
                case EventCondition.notContainsCaseSensitive: passed = !value.Contains(compareValue); break;
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
            contains,
            [InspectorName("Does Not Contain")]
            notContains,
            containsCaseSensitive,
            [InspectorName("Does Not Contain Case Sensitive")]
            notContainsCaseSensitive
        }
    }
}
