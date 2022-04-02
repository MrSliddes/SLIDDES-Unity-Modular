using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    /// <summary>
    /// Extension class for EditorGUILayout
    /// </summary>
    public static class EditorGUILayoutExtensions
    {
        /// <summary>
        /// Make a char field for entering a char value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="text">GUIContent text string</param>
        /// <param name="tooltip">GUIContent tooltip string</param>
        /// <returns>char</returns>
        public static char CharField(char value, string text = "", string tooltip = "")
        {
            return char.Parse(EditorGUILayout.TextField(new GUIContent(text == "" ? "Char" : text, tooltip), value.ToString()).Substring(0, 1));
        }

        /// <summary>
        /// Make a decimal field for entering decimal values
        /// </summary>
        /// <param name="value"></param>
        /// <param name="text">GUIContent text string</param>
        /// <param name="tooltip">GUIContent tooltip string</param>
        /// <returns>decimal</returns>
        public static decimal DecimalField(decimal value, string text = "", string tooltip = "")
        {
            string s = EditorGUILayout.TextField(new GUIContent(text == "" ? "Decimal" : text, tooltip), value.ToString());
            if(GUI.changed)
            {
                if(decimal.TryParse(s, out decimal val)) return val;
            }
            return value;
        }

        /// <summary>
        /// Make a DictionaryVariable field for entering a DictionaryVariable value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="text">GUIContent text string</param>
        /// <param name="tooltip">GUIContent tooltip string</param>
        /// <returns>DictionaryVariable</returns>
        public static DictionaryVariable DictionaryVariableField(DictionaryVariable value, string text = "", string tooltip = "")
        {
            return (DictionaryVariable)EditorGUILayout.ObjectField(new GUIContent(text == "" ? "Dictionary Variable" : text, tooltip), value, typeof(DictionaryVariable), false);
        }
    }
}
