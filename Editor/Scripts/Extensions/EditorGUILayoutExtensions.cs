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
        public static char CharField(GUIContent guiContent, char value)
        {
            return char.Parse(EditorGUILayout.TextField(new GUIContent(guiContent.text == "" ? "Char" : guiContent.text, guiContent.tooltip), value.ToString()).Substring(0, 1));
        }

        /// <summary>
        /// Make a decimal field for entering decimal values
        /// </summary>
        /// <param name="value"></param>
        /// <param name="text">GUIContent text string</param>
        /// <param name="tooltip">GUIContent tooltip string</param>
        /// <returns>decimal</returns>
        public static decimal DecimalField(GUIContent guiContent, decimal value)
        {
            string s = EditorGUILayout.TextField(new GUIContent(guiContent.text == "" ? "Decimal" : guiContent.text, guiContent.tooltip), value.ToString());
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
        public static DictionaryVariable DictionaryVariableField(GUIContent guiContent, DictionaryVariable value)
        {
            return (DictionaryVariable)EditorGUILayout.ObjectField(new GUIContent(guiContent.text == "" ? "Dictionary Variable" : guiContent.text, guiContent.tooltip), value, typeof(DictionaryVariable), false);
        }

        /// <summary>
        /// Make a list variable field for entering a listvariable value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="guiContent"></param>
        /// <returns>ListVariable</returns>
        public static ListVariable ListVariableField(GUIContent guiContent, ListVariable value)
        {
            return (ListVariable)EditorGUILayout.ObjectField(new GUIContent(guiContent.text == "" ? "List Variable" : guiContent.text, guiContent.tooltip), value, typeof(DictionaryVariable), false);
        }
    }
}
