using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SLIDDES.Modular
{
    [System.Serializable]
    public class DictionaryVariableReference
    {
        [Tooltip("What reference type is used for this reference")]
        public ReferenceType referenceType;

        public DictionaryVariable variable;
        public ScriptableObject key;
        public ScriptableObject value;

        public Dictionary<ScriptableObject, ScriptableObject> Value
        {
            get 
            {
                return referenceType switch
                {
                    ReferenceType.variable => variable.Value,
                    ReferenceType.key => new Dictionary<ScriptableObject, ScriptableObject> { { key, null } },
                    ReferenceType.value => new Dictionary<ScriptableObject, ScriptableObject> { { key, null } },
                    _ => null,
                };
            }
            set
            {
                switch(referenceType)
                {
                    case ReferenceType.variable: variable.Value = value; break;
                    case ReferenceType.key: key = value.Keys.First(); break;
                    case ReferenceType.value: this.value = value.Values.First(); break;
                    default: break;
                }
            }
        }

        public enum ReferenceType
        {
            [Tooltip("Dictionary Variable")]
            variable,
            [Tooltip("Dictionary Variable with only the key")]
            key,
            [Tooltip("Dictionary Variable with only the Value")]
            value
        }
    }
}
