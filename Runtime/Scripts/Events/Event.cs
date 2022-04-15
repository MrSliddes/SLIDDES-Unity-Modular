using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    /// <summary>
    /// A callback (simular to UnityEvent but works with the Modular scriptable object structure)
    /// </summary>
    [CreateAssetMenu(fileName = "Event", menuName = "SLIDDES/Modular/Events/Event", order = -1)]
    public class Event : EventBase
    {
        /// <summary>
        /// A list of event listeners lisening to this event
        /// </summary>
        private List<EventListener> listeners = new List<EventListener>();

        public virtual void Invoke()
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

    /// <summary>
    /// A callback (simular to UnityEvent but works with the Modular scriptable object structure)
    /// </summary>   
    public class Event<T0> : EventBase
    {
        /// <summary>
        /// A list of event listeners lisening to this event
        /// </summary>
        private List<EventListener<T0>> listeners = new List<EventListener<T0>>();

        public virtual void Invoke(T0 value)
        {
            // Loop through backwards
            // (Incase a event is to remove itself from the list, then you are removing things behind you)
            for(int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].Invoke(value);
            }
        }

        public void AddListener(EventListener<T0> listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(EventListener<T0> listener)
        {
            listeners.Remove(listener);
        }
    }
}
