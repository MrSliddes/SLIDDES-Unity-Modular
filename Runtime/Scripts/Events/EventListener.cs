using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    /// <summary>
    /// An event listener that is placed on a game object to handle a response from an event
    /// </summary>
    [AddComponentMenu("SLIDDES/Modular/Modular Event Listener")]
    public class EventListener : MonoBehaviour
    {
        [Tooltip("The event to listen for")]
        public Event Event;
        [Tooltip("The response to the Event")]
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.AddListener(this);
        }

        private void OnDisable()
        {
            Event.RemoveListener(this);
        }

        public void Invoke()
        {
            Response.Invoke();
        }
    }
}
