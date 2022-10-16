using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    /// <summary>
    /// An event listener that is placed on a game object to handle a response from an event
    /// </summary>
    public class EventListener : EventListenerBase
    {
        [Tooltip("The event to listen for")]
        public EventSDS Event;
        [Tooltip("The response to the Event")]
        public UnityEvent Response;

        private void OnEnable()
        {
            if(Event != null) Event.AddListener(this);
        }

        private void OnDisable()
        {
            if(Event != null) Event.RemoveListener(this);
        }

        public virtual void Invoke()
        {
            // Only invoke if the invoker is not set or it matches that of the event
            if(associatedInvoker == null || associatedInvoker == Event.invoker)
            {
                Response.Invoke();
            }
        }
    }

    public class EventListener<T0> : EventListenerBase
    {
        [Tooltip("The event to listen for")]
        public EventSDS<T0> Event;
        [Tooltip("The response to the Event")]
        public UnityEvent<T0> Response;

        private void OnEnable()
        {
            if(Event != null) Event.AddListener(this);
        }

        private void OnDisable()
        {
            if(Event != null) Event.RemoveListener(this);
        }

        public virtual void Invoke(T0 type)
        {
            // Only invoke if the invoker is not set or it matches that of the event
            if(associatedInvoker == null || associatedInvoker == Event.invoker)
            {
                Response.Invoke(type);
            }
        }
    }
}
