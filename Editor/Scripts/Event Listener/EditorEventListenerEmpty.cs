using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerEmpty))]
    public class EditorEventListenerEmpty : EditorEventListener<bool>
    {
        public override void DrawGUIEventObjectField()
        {
            selected.Event = (Event<bool>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selected.Event, typeof(EmptyEvent), false);
        }
    }
}
