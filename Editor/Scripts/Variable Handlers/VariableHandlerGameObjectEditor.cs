using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(VariableHandlerGameObject))]
    public class VariableHandlerGameObjectEditor : VariableHandlerEditor<GameObject>
    {
        public override void DrawVariableObjectField()
        {
            selected.variable = (GameObjectVariable)EditorGUILayout.ObjectField(new GUIContent("Variable", "The variable to handle"), selected.variable, typeof(GameObjectVariable), false);
        }
    }
}
