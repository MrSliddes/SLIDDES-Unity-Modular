using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerBool))]
    public class EventListenerBoolEditor : EventListenerEditor<bool>
    {
        private EventListenerBool selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerBool)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<bool>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(BoolEvent), false);
        }
    }
}
