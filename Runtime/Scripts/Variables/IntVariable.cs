using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [CreateAssetMenu(fileName = "Variable Int", menuName = "SLIDDES/Modular/Variables/Variable Int")]
    public class IntVariable : Variable<int>
    {
        /// <summary>
        /// Create an instance of this Variable
        /// </summary>
        /// <param name="value"></param>
        public static ScriptableObject Create(int value)
        {
            IntVariable so = (IntVariable)CreateInstance(typeof(IntVariable));
            so.Value = value;
            return so;
        }
    }
}
