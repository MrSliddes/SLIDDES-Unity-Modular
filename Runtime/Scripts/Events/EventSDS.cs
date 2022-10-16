using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    /// <summary>
    /// A callback (simular to UnityEvent but works with the Modular scriptable object structure)
    /// </summary>
    [CreateAssetMenu(fileName = "Event", menuName = "SLIDDES/Modular/Events/Event", order = -1)]
    public class EventSDS : EventBase
    {
        /// <summary>
        /// A list of event listeners listening to this event
        /// </summary>
        private List<EventListener> listeners = new List<EventListener>();
        /// <summary>
        /// A list of unity actions listening to this event
        /// </summary>
        private List<UnityAction> listenersAction = new List<UnityAction>();

        public virtual void Invoke()
        {
            // Loop through backwards
            // (Incase a event is to remove itself from the list, then you are removing things behind you)
            for(int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].Invoke();
            }

            for(int i = listenersAction.Count -1; i >= 0; i--)
            {
                listenersAction[i].Invoke();
            }
        }

        public void AddListener(EventListener listener)
        {
            listeners.Add(listener);
        }

        public void AddListener(UnityAction unityAction)
        {
            listenersAction.Add(unityAction);
        }

        public void RemoveListener(EventListener listener)
        {
            listeners.Remove(listener);
        }

        public void RemoveListener(UnityAction unityAction)
        {
            listenersAction.Remove(unityAction);
        }
    }

    /// <summary>
    /// A callback (simular to UnityEvent but works with the Modular scriptable object structure)
    /// </summary>   
    public class EventSDS<T0> : EventBase
    {
        /// <summary>
        /// A list of event listeners lisening to this event
        /// </summary>
        private List<EventListener<T0>> listeners = new List<EventListener<T0>>();
        /// <summary>
        /// A list of unity actions listening to this event
        /// </summary>
        private List<UnityAction<T0>> listenersAction = new List<UnityAction<T0>>();

        public virtual void Invoke(T0 value)
        {
            // Loop through backwards
            // (Incase a event is to remove itself from the list, then you are removing things behind you)
            for(int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].Invoke(value);
            }

            for(int i = listenersAction.Count - 1; i >= 0; i--)
            {
                listenersAction[i].Invoke(value);
            }
        }

        public void AddListener(EventListener<T0> listener)
        {
            listeners.Add(listener);
            //listenersAction.Add(x => listener.Invoke(x)); need to test if this works
        }

        public void AddListener(UnityAction<T0> unityAction)
        {
            listenersAction.Add(unityAction);
        }

        public void RemoveListener(EventListener<T0> listener)
        {
            listeners.Remove(listener);
            //listenersAction.Remove(x => listener.Invoke(x)); need to test if this works
        }

        public void RemoveListener(UnityAction<T0> unityAction)
        {
            listenersAction.Remove(unityAction);
        }
    }
}
