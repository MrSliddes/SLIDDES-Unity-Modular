using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    /// <summary>
    /// A callback (simular to UnityEvent but works with the Modular scriptable object structure)
    /// </summary>    
    public abstract class EventBase : ScriptableObject
    {
        [TextArea(1, 10)]
        [Tooltip("Description of the event")]
#pragma warning disable IDE0051 // Remove unused private members
        [SerializeField] private string description;
#pragma warning restore IDE0051 // Remove unused private members
    }
}
