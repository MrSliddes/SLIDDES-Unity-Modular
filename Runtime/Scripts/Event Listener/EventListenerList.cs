using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener List")]
    public class EventListenerList : EventListener<List<ScriptableObject>>
    {
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventCondition eventCondition;
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventConditionItem eventConditionItem;
        [Tooltip("The value to compare it too")]
        public ListVariableReference compareValue;
        [Tooltip("Int value to compare with")]
        public int compareInt;

        public override void Invoke(List<ScriptableObject> value)
        {
            bool passed = false;
            switch(compareValue.referenceType)
            {
                case ListVariableReference.ReferenceType.variable:
                    switch(eventCondition)
                    {
                        case EventCondition.none: passed = true; break;
                        case EventCondition.equalToo: passed = value == compareValue.Value; break;
                        case EventCondition.notEqualToo: passed = value != compareValue.Value; break;
                        case EventCondition.countIsEqual: passed = value.Count == compareValue.Value.Count; break;
                        case EventCondition.countIsNotEqual: passed = value.Count != compareValue.Value.Count; break;
                        case EventCondition.countIsBigger: passed = value.Count > compareValue.Value.Count; break;
                        case EventCondition.countIsSmaller: passed = value.Count < compareValue.Value.Count; break;
                        case EventCondition.countIsEqualOrBigger: passed = value.Count >= compareValue.Value.Count; break;
                        case EventCondition.countIsEqualOrSmaller: passed = value.Count <= compareValue.Value.Count; break;
                        default: break;
                    }
                    break;
                case ListVariableReference.ReferenceType.item:
                    switch(eventConditionItem)
                    {
                        case EventConditionItem.none: passed = true; break;
                        case EventConditionItem.equalTooFirst: passed = value.First() == compareValue.Value.First(); break;
                        case EventConditionItem.equalTooLast: passed = value.Last() == compareValue.Value.Last(); break;
                        case EventConditionItem.equalTooIndex: passed = compareInt > 0 && compareInt < value.Count && value[compareInt] == compareValue.item; break;
                        case EventConditionItem.notEqualToo: passed = compareInt > 0 && compareInt < value.Count && value[compareInt] != compareValue.item; break;
                        case EventConditionItem.notEqualTooFirst: passed = value.First() != compareValue.Value.First(); break;
                        case EventConditionItem.notEqualTooLast: passed = value.Last() != compareValue.Value.Last(); break;
                        case EventConditionItem.notEqualTooIndex: passed = compareInt > 0 && compareInt < value.Count && value[compareInt] != compareValue.item; break;
                        case EventConditionItem.contains: passed = value.Contains(compareValue.item); break;
                        case EventConditionItem.notContains: passed = !value.Contains(compareValue.item); break;
                        default: break;
                    }
                    break;                
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
            [InspectorName("Count == Count")]
            countIsEqual,
            [InspectorName("Count != Count")]
            countIsNotEqual,
            [InspectorName("Count > Count")]
            countIsBigger,
            [InspectorName("Count < Count")]
            countIsSmaller,
            [InspectorName("Count >= Count")]
            countIsEqualOrBigger,
            [InspectorName("Count <= Count")]
            countIsEqualOrSmaller
        }

        /// <summary>
        /// Before the response is invoked, the event has to meet the eventCondition
        /// </summary>
        public enum EventConditionItem
        {
            [Tooltip("Event allways passes")]
            none,
            equalTooFirst,
            equalTooLast,
            equalTooIndex,
            notEqualToo,
            notEqualTooFirst,
            notEqualTooLast,
            notEqualTooIndex,
            contains,
            [InspectorName("Does Not Contain")]
            notContains
        }
    }
}
