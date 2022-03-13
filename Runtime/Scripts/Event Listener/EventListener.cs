using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    /// <summary>
    /// An event listener that is placed on a game object to handle a response from an event
    /// </summary>
    public class EventListener<T> : MonoBehaviour
    {
        [Tooltip("The event to listen for")]
        public Event<T> Event;
        [Tooltip("The response to the Event")]
        public UnityEvent<T> Response;

        private void OnEnable()
        {
            if(Event != null) Event.AddListener(this);
        }

        private void OnDisable()
        {
            if(Event != null) Event.RemoveListener(this);
        }

        public virtual void Invoke(T type)
        {
            Response.Invoke(type);
        }
    }
}
