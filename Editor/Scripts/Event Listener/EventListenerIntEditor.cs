using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerInt))]
    public class EventListenerIntEditor : EventListenerEditor<int>
    {
        private EventListenerInt selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerInt)target;            
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<int>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(IntEvent), false);
        }
    }
}
