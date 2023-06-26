using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerGameObject))]
    public class EventListenerGameObjectEditor : EventListenerEditor<GameObject>
    {
        private EventListenerGameObject selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerGameObject)target;
        }

        public override void DrawEventObjectField()
        {
            selectedType.Event = (EventSDS<GameObject>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(GameObjectEvent), false);
        }
    }
}
