using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.ObjectModel;

namespace SLIDDES.Modular
{
    /// <summary>
    /// An extention class for enums
    /// </summary>
    /// <typeparam name="T0">Type</typeparam>
    /// <credit>https://www.codeproject.com/Articles/20805/Enhancing-C-Enums</credit>
    public abstract class EnumBaseType<T0> where T0 : EnumBaseType<T0>
    {
        protected static List<T0> enumValues = new List<T0>();

        public readonly int Key;
        public readonly string Value;

        public EnumBaseType(int key, string value)
        {
            Key = key;
            Value = value;
            enumValues.Add((T0)this);
        }

        protected static ReadOnlyCollection<T0> GetBaseValues()
        {
            return enumValues.AsReadOnly();
        }

        protected static T0 GetBaseByKey(int key)
        {
            foreach(T0 t in enumValues)
            {
                if(t.Key == key) return t;
            }
            return null;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
