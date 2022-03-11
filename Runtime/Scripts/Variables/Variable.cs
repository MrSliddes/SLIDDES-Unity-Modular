using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    public abstract class Variable<T> : ScriptableObject
    {
        [Tooltip("Do you want the so values to be reset on unity runtime")]
        [SerializeField] private bool resetOnRuntime;

        /// <summary>
        /// The Value of the type
        /// </summary>
        /// <remarks>
        /// On value change the onValueChanged gets invoked
        /// </remarks>
        public T Value
        {
            get { return value; }
            set
            {
                this.value = value;
                if(Event != null) Event.Invoke();
            }
        }

        /// <summary>
        /// The value of the type, accessed directly
        /// </summary>
        /// <remarks>
        /// This does not trigger onValueChanged
        /// </remarks>
        public T value;

        [TextArea(1, 10)]
        [Tooltip("The description of what this variable is for")]
#pragma warning disable IDE0051 // Remove unused private members
        [SerializeField] private readonly string description;
#pragma warning restore IDE0051 // Remove unused private members

        public Event Event;

        protected virtual void OnDisable()
        {
            if(resetOnRuntime) Reset();
        }

        protected virtual void OnValidate()
        {
            Value = value;
        }

        protected virtual void Reset()
        {
            value = default;
        }

    }
}
