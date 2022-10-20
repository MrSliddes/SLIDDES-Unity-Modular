using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SLIDDES.Modular
{
    /// <summary>
    /// Static class for handling event conditions
    /// </summary>
    public static class EventConditionInternal
    {
        /// <summary>
        /// Draw the right event conditions for the type
        /// </summary>
        /// <param name="typeName">The name of the type (type.Name)</param>
        /// <param name="selectedValue">The interger value of EventCondition enum</param>
        /// <returns>EditorGUILayout.IntPopup selected enum value</returns>
        public static int DrawEventConditionOptions(string typeName, int selectedValue)
        {
#if UNITY_EDITOR

            List<GUIContent> displayOptions = new List<GUIContent>();
            List<int> optionValues = new List<int>();

            // Default none option
            optionValues.Add(0);

            //Debug.Log(type.Name);
            int[] optionValueIndexes = typeName switch
            {
                "Boolean" => new int[2] { 1, 2 },
                "Byte" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "Char" => new int[2] { 1, 2 },
                "Decimal" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "Dictionary`2" => new int[2] { 1, 2 },
                "Dictionary`2 KeyValue" => new int[2] { 7, 8 },
                "Double" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "Single" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "Int32" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "List`1" => new int[10] { 9, 10, 1, 2, 3, 4, 5, 6, 7, 8 },
                "Int64" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "SByte" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "Int16" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "String" => new int[4] { 1, 2, 7, 8 },
                "UInt32" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "UInt64" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "Object" => new int[2] { 1, 2 },
                "UInt16" => new int[6] { 1, 2, 3, 4, 5, 6 },
                "Vector2" => new int[14] { 1, 2, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 },
                "Vector2Int" => new int[14] { 1, 2, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 },
                "Vector3" => new int[20] { 1, 2, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 },
                "Vector3Int" => new int[20] { 1, 2, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 },
                _ => new int[0]
            };
            optionValues.AddRange(optionValueIndexes);

            // Get display options
            foreach(int item in optionValues)
            {
                switch(item)
                {                    
                    case 0: displayOptions.Add(new GUIContent("none", "Event will always pass")); break;

                    case 1: displayOptions.Add(new GUIContent("==", "Equal too")); break;
                    case 2: displayOptions.Add(new GUIContent("!=", "Not equal too")); break;

                    case 3: displayOptions.Add(new GUIContent(">", "Greater then")); break;
                    case 4: displayOptions.Add(new GUIContent("<", "Lesser then")); break;
                    case 5: displayOptions.Add(new GUIContent(">=", "Greater or eqaul then")); break;
                    case 6: displayOptions.Add(new GUIContent("<=", "Lesser or eqaul then")); break;

                    // Strings
                    case 7: displayOptions.Add(new GUIContent("Contains", "Value contains compare value")); break;
                    case 8: displayOptions.Add(new GUIContent("Contains Not", "Value does not contain compare value")); break;

                    // List
                    case 9: displayOptions.Add(new GUIContent("Count Is Equal", "Value.Count equals compareValue.Count")); break;
                    case 10: displayOptions.Add(new GUIContent("Count Not Is Equal", "Value.Count does not equal compareValue.Count")); break;

                    // Vectors
                    case 11: displayOptions.Add(new GUIContent("Equal To X", "Value.x is equal to compareValue.x")); break;
                    case 12: displayOptions.Add(new GUIContent("Not Equal To X", "Value.x is not equal to compareValue.x")); break;
                    case 13: displayOptions.Add(new GUIContent("Greater Then X", "Value.x is greater then compareValue.x")); break;
                    case 14: displayOptions.Add(new GUIContent("Lesser Then X", "Value.x is lesser then compareValue.x")); break;
                    case 15: displayOptions.Add(new GUIContent("Greater Or Equal To X", "Value.x is greater or equal to compareValue.x")); break;
                    case 16: displayOptions.Add(new GUIContent("Lesser Or Equal To X", "Value.x is lesser or equal to compareValue.x")); break;

                    case 17: displayOptions.Add(new GUIContent("Equal To Y", "Value.y is equal to compareValue.y")); break;
                    case 18: displayOptions.Add(new GUIContent("Not Equal To Y", "Value.y is not equal to compareValue.y")); break;
                    case 19: displayOptions.Add(new GUIContent("Greater Then Y", "Value.y is greater then compareValue.y")); break;
                    case 20: displayOptions.Add(new GUIContent("Lesser Then Y", "Value.y is lesser then compareValue.y")); break;
                    case 21: displayOptions.Add(new GUIContent("Greater Or Equal To Y", "Value.y is greater or equal to compareValue.y")); break;
                    case 22: displayOptions.Add(new GUIContent("Lesser Or Equal To Y", "Value.y is lesser or equal to compareValue.y")); break;

                    case 23: displayOptions.Add(new GUIContent("Equal To Z", "Value.z is equal to compareValue.z")); break;
                    case 24: displayOptions.Add(new GUIContent("Not Equal To Z", "Value.z is not equal to compareValue.z")); break;
                    case 25: displayOptions.Add(new GUIContent("Greater Then Z", "Value.z is greater then compareValue.z")); break;
                    case 26: displayOptions.Add(new GUIContent("Lesser Then Z", "Value.z is lesser then compareValue.z")); break;
                    case 27: displayOptions.Add(new GUIContent("Greater Or Equal To Z", "Value.z is greater or equal to compareValue.z")); break;
                    case 28: displayOptions.Add(new GUIContent("Lesser Or Equal To Z", "Value.z is lesser or equal to compareValue.z")); break;

                    default:
                        break;
                }
            }

            return EditorGUILayout.IntPopup(new GUIContent("Event Condition"), selectedValue, displayOptions.ToArray(), optionValues.ToArray());
#endif
        }
    }
}
