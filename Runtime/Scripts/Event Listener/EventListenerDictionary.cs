using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Dictionary")]
    public class EventListenerDictionary : EventListener<Dictionary<ScriptableObject, ScriptableObject>>
    {
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventCondition eventCondition;
        [Tooltip("The condition the event has to meet before the response is executed")]
        public EventConditionKeyValue eventConditionKeyValue;
        [Tooltip("The value to compare it too")]
        public DictionaryVariableReference compareValue;
        [Tooltip("Int value to compare with")]
        public int compareInt;

        public override void Invoke(Dictionary<ScriptableObject, ScriptableObject> value)
        {
            bool passed = false;
            switch(compareValue.referenceType)
            {
                case DictionaryVariableReference.ReferenceType.variable:
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
                case DictionaryVariableReference.ReferenceType.key:
                    ScriptableObject[] keys;
                    switch(eventConditionKeyValue)
                    {
                        case EventConditionKeyValue.none: passed = true; break;
                        case EventConditionKeyValue.equalTooFirst: passed = value.Keys.First() == compareValue.Value.Keys.First();                            break;
                        case EventConditionKeyValue.equalTooLast: passed = value.Keys.Last() == compareValue.Value.Keys.Last();                            break;
                        case EventConditionKeyValue.equalTooIndex:
                            keys = value.Keys.ToArray();
                            passed = compareInt > 0 && compareInt < value.Keys.Count && keys[compareInt] == compareValue.key;
                            break;
                        case EventConditionKeyValue.notEqualToo:
                            keys = value.Keys.ToArray();
                            passed = compareInt > 0 && compareInt < value.Keys.Count && keys[compareInt] != compareValue.key;
                            break;
                        case EventConditionKeyValue.notEqualTooFirst: passed = value.Keys.First() != compareValue.Value.Keys.First();                            break;
                        case EventConditionKeyValue.notEqualTooLast: passed = value.Keys.Last() != compareValue.Value.Keys.Last();                            break;
                        case EventConditionKeyValue.notEqualTooIndex:
                            keys = value.Keys.ToArray();
                            passed = compareInt > 0 && compareInt < value.Keys.Count && keys[compareInt] != compareValue.key;
                            break;
                        case EventConditionKeyValue.contains: passed = value.Keys.Contains(compareValue.key); break;
                        case EventConditionKeyValue.notContains: passed = !value.Keys.Contains(compareValue.key); break;
                        default: break;
                    }
                    break;
                case DictionaryVariableReference.ReferenceType.value:
                    ScriptableObject[] values;
                    switch(eventConditionKeyValue)
                    {
                        case EventConditionKeyValue.none: passed = true; break;
                        case EventConditionKeyValue.equalTooFirst: passed = value.Values.First() == compareValue.Value.Values.First(); break;
                        case EventConditionKeyValue.equalTooLast: passed = value.Values.Last() == compareValue.Value.Values.Last(); break;
                        case EventConditionKeyValue.equalTooIndex:
                            values = value.Values.ToArray();
                            passed = compareInt > 0 && compareInt < value.Values.Count && values[compareInt] == compareValue.value;
                            break;
                        case EventConditionKeyValue.notEqualToo:
                            values = value.Values.ToArray();
                            passed = compareInt > 0 && compareInt < value.Values.Count && values[compareInt] != compareValue.value;
                            break;
                        case EventConditionKeyValue.notEqualTooFirst: passed = value.Values.First() != compareValue.Value.Values.First(); break;
                        case EventConditionKeyValue.notEqualTooLast: passed = value.Values.Last() != compareValue.Value.Values.Last(); break;
                        case EventConditionKeyValue.notEqualTooIndex:
                            values = value.Values.ToArray();
                            passed = compareInt > 0 && compareInt < value.Values.Count && values[compareInt] != compareValue.value;
                            break;
                        case EventConditionKeyValue.contains: passed = value.Values.Contains(compareValue.value); break;
                        case EventConditionKeyValue.notContains: passed = !value.Values.Contains(compareValue.value); break;
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
        public enum EventConditionKeyValue
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
