using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    /// <summary>
    /// A callback (simular to UnityEvent but works with the Modular scriptable object structure)
    /// </summary>    
    public abstract class Event<T> : ScriptableObject
    {
        [TextArea(1, 10)]
        [Tooltip("Description of the event")]
#pragma warning disable IDE0051 // Remove unused private members
        [SerializeField] private string description;
#pragma warning restore IDE0051 // Remove unused private members

        /// <summary>
        /// A list of event listeners lisening to this event
        /// </summary>
        private List<EventListener<T>> listeners = new List<EventListener<T>>();

        public virtual void Invoke(T value)
        {
            // Loop through backwards
            // (Incase a event is to remove itself from the list, then you are removing things behind you)
            for(int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].Invoke(value);
            }
        }

        public virtual void AddListener(EventListener<T> listener)
        {
            listeners.Add(listener);
        }

        public virtual void RemoveListener(EventListener<T> listener)
        {
            listeners.Remove(listener);
        }
    }
}
