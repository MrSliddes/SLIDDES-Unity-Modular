using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [CreateAssetMenu(fileName = "Dictionary Variable", menuName = "SLIDDES/Modular/Variable Dictionary")]
    public class DictionaryVariable : Variable<Dictionary<ScriptableObject, ScriptableObject>>
    {
        /// <summary>
        /// Create an instance of this Variable
        /// </summary>
        /// <param name="key">The dictionary key</param>
        /// <param name="value">The dictionary Value</param>
        public static ScriptableObject Create(ScriptableObject key, ScriptableObject value)
        {
            DictionaryVariable so = (DictionaryVariable)CreateInstance(typeof(DictionaryVariable));
            so.Value = new Dictionary<ScriptableObject, ScriptableObject>
            {
                { key, value }
            };
            return so;
        }
    }
}
