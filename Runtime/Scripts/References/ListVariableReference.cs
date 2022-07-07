using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SLIDDES.Modular
{
    [System.Serializable]
    public class ListVariableReference
    {
        [Tooltip("What reference type is used for this reference")]
        public ReferenceType referenceType;

        public ListVariable variable;
        /// <summary>
        /// The item of an list
        /// </summary>
        public ScriptableObject item;

        public List<ScriptableObject> Value
        {
            get 
            {
                return referenceType switch
                {
                    ReferenceType.variable => variable.Value,
                    ReferenceType.item => new List<ScriptableObject> { item },
                    _ => null,
                };
            }
            set
            {
                switch(referenceType)
                {
                    case ReferenceType.variable: variable.Value = value; break; 
                    case ReferenceType.item: item = value.First(); break;
                    default: break;
                }
            }
        }

        public enum ReferenceType
        {
            [Tooltip("List Variable")]
            variable,
            [Tooltip("Item of a List Variable")]
            item
        }
    }
}
