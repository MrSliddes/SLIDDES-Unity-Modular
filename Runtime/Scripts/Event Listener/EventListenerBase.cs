using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    /// <summary>
    /// An event listener that is placed on a game object to handle a response from an event
    /// </summary>
    public abstract class EventListenerBase : MonoBehaviour
    {
        [TextArea(1, 10)]
        [Tooltip("Description of what the event listener does")]
        [SerializeField] private string description;

        [Tooltip("The associated gameobject that invoked the event. If left on null the listener will accept all event invokers")]
        public GameObject associatedInvoker;

        /// <summary>
        /// Set the associated invoker
        /// </summary>
        /// <param name="associatedInvoker">The gameobject that is associated with this event listener</param>
        public void SetAssociatedInvoker(GameObject associatedInvoker)
        {
            this.associatedInvoker = associatedInvoker;
        }
    }
}
