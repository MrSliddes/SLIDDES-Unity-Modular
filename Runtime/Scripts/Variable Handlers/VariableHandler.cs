using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    //[AddComponentMenu("SLIDDES/Modular/Variable Handlers/")]
    public abstract class VariableHandler<T0> : MonoBehaviour
    {
        [TextArea(1, 10)]
        [Tooltip("What does this handler do?")]
        public string description;
        [Tooltip("The variable to handle")]
        public Variable<T0> variable;

        public GetValueOn getValueOn;

        [Tooltip("Triggerd when getting value")]
        public UnityEvent<T0> onGetValue;

        private void OnEnable()
        {
            if(getValueOn == GetValueOn.enable) GetValue();
        }

        private void OnDisable()
        {
            if(getValueOn == GetValueOn.disable) GetValue();
        }

        private void Awake()
        {
            if(getValueOn == GetValueOn.awake) GetValue();
        }

        // Start is called before the first frame update
        void Start()
        {
            if(getValueOn == GetValueOn.start) GetValue();
        }

        private void Update()
        {
            if(getValueOn == GetValueOn.update) GetValue();
        }

        /// <summary>
        /// Get the value of the Variable
        /// </summary>
        public void GetValue()
        {
            onGetValue.Invoke(variable.Value);
        }

        private void OnDestroy()
        {
            if(getValueOn == GetValueOn.destroy) GetValue();
        }

        [Tooltip("When to get the value")]
        public enum GetValueOn
        {
            [Tooltip("The value is fetched by an external script")]
            manually,
            enable,
            disable,
            awake,
            start,
            update,
            destroy
        }
    }
}
