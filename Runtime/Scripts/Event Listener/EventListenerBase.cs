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
        [Tooltip("The associated gameobject that invoked the event. If left on null the listener will accept all event invokers")]
        public GameObject associatedInvoker;        
    }
}
