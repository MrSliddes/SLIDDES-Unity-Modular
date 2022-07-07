using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    /// <summary>
    /// Base class for a reference
    /// </summary>
    /// <typeparam name="T">The type of reference</typeparam>
    public class Reference<T>
    {
        /// <summary>
        /// Is the reference a constant value or a TypeVariable
        /// </summary>
        [SerializeField] private bool isConstant = true;
        [SerializeField] private T constantValue;
        [SerializeField] private Variable<T> variable;

        /// <summary>
        /// Get the value of the reference based on isConstant
        /// </summary>
        public T Value
        {
            get { return isConstant ? constantValue : variable.Value; }
            set
            {
                if(isConstant)
                {
                    constantValue = value;
                }
                else
                {
                    variable.Value = value;
                }
            }
        }
    }
}
