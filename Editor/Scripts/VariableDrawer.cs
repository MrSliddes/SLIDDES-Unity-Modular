using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomPropertyDrawer(typeof(Variable<>))]
    public class VariableDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // Dont show in inspector as Variable<T> isnt supposed to be used    
        }
    }
}
