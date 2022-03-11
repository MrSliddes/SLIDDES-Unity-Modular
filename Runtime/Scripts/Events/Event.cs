using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    /// <summary>
    /// A callback (simular to UnityEvent but works with the Modular scriptable object structure)
    /// </summary>
    [CreateAssetMenu(fileName = "Event", menuName = "SLIDDES/Modular/Event", order = -1)]
    public class Event : ScriptableObject
    {
        [TextArea(1, 10)]
        [Tooltip("Description of the event")]
#pragma warning disable IDE0051 // Remove unused private members
        [SerializeField] private readonly string description;
#pragma warning restore IDE0051 // Remove unused private members

        /// <summary>
        /// A list of event listeners lisening to this event
        /// </summary>
        private List<EventListener> listeners = new List<EventListener>();

        public void Invoke()
        {
            // Loop through backwards
            // (Incase a event is to remove itself from the list, then you are removing things behind you)
            for(int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].Invoke();
            }
        }

        public void AddListener(EventListener listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(EventListener listener)
        {
            listeners.Remove(listener);
        }
    }
}
