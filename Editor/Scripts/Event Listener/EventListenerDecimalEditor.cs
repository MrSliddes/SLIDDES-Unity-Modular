using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(EventListenerDecimal))]
    public class EventListenerDecimalEditor : EventListenerEditor<decimal>
    {
        private EventListenerDecimal selectedType;

        public override void OnEnable()
        {
            base.OnEnable();
            selectedType = (EventListenerDecimal)target;
        }

        public override void DrawGUIEventObjectField()
        {
            selectedType.Event = (EventSDS<decimal>)EditorGUILayout.ObjectField(new GUIContent("Event", "The event to listen for"), selectedType.Event, typeof(DecimalEvent), false);
        }
    }
}
