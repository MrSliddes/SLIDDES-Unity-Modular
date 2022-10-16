using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    [System.Serializable]
    public abstract class Variable<T0> : ScriptableObject
    {
        [TextArea(1, 10)]
        [Tooltip("The description of what this variable is for")]
#pragma warning disable IDE0051 // Remove unused private members
        [SerializeField] private string description;
        [Space()]
#pragma warning restore IDE0051 // Remove unused private members

        [Tooltip("Do you want the so values to be reset on when the Application stops playing")]
        [SerializeField] private bool resetOnQuit;

        /// <summary>
        /// The Value of the type
        /// </summary>
        /// <remarks>
        /// On value change the onValueChanged gets invoked
        /// </remarks>
        public T0 Value
        {
            get 
            {
                if(value == null) value = default;
                return value; 
            }
            set
            {
                this.value = value;
                if(onValueChanged != null) onValueChanged.Invoke(Value);
                if(onValueChangedEvent != null) onValueChangedEvent.Invoke(Value);
            }
        }

        /// <summary>
        /// The value of the type, accessed directly
        /// </summary>
        /// <remarks>
        /// This does not trigger onValueChanged
        /// </remarks>
        public T0 value;

        /// <summary>
        /// Event that gets triggerd if value changes
        /// </summary>
        public EventSDS<T0> onValueChangedEvent;
        /// <summary>
        /// Unity event that gets triggerd if value changes
        /// </summary>
        [HideInInspector] public UnityEvent<T0> onValueChanged;

        /// <summary>
        /// The value that gets set in the editor by user.
        /// Used for on start resetting of value
        /// </summary>
        private T0 editorSetValue;

        
        protected virtual void OnEnable()
        {
            if(resetOnQuit)
            {
                Application.quitting -= Reset;
                Application.quitting += Reset;
            }
        }

        protected virtual void OnValidate()
        {
            Value = value;
#if UNITY_EDITOR
            if(!Application.isPlaying) editorSetValue = value;
#endif
        }

        /// <summary>
        /// Create an instance of this Variable
        /// </summary>
        /// <param name="value">The value T0</param>
        public static ScriptableObject Create(System.Type type, T0 value)
        {
            Variable<T0> so = (Variable<T0>)CreateInstance(type);
            so.Value = value;
            return so;
        }

        /// <summary>
        /// Reset the variable
        /// </summary>
        public virtual void Reset()
        {
            value = editorSetValue;
        }
    }
}
