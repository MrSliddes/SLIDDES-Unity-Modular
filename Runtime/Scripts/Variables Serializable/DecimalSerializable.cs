using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    /// <summary>
    /// For serializing a variable and showing it in the unity inspector
    /// </summary>
    [System.Serializable]
    public class DecimalSerializable : ISerializationCallbackReceiver
    {
        public decimal value;
        [SerializeField]
        private int[] data;

        public void OnBeforeSerialize()
        {
            data = decimal.GetBits(value);
        }
        public void OnAfterDeserialize()
        {
            if(data != null && data.Length == 4)
            {
                value = new decimal(data);
            }
        }
    }
}
