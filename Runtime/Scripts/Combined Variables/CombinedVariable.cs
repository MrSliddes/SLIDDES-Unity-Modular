using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    public abstract class CombinedVariable<T0>
    {
        /// <summary>
        /// The total combined value
        /// </summary>
        public T0 Value { get; protected set; }

        /// <summary>
        /// The base value
        /// </summary>
        public T0 baseValue;
        /// <summary>
        /// The total added value
        /// </summary>
        public T0 addedValue;
        /// <summary>
        /// The total added percentage value
        /// </summary>
        public T0 addedPercentageValue;

        private List<UnityAction<CombinedVariable<T0>>> actions = new List<UnityAction<CombinedVariable<T0>>>();


        public void Add(UnityAction<CombinedVariable<T0>> action)
        {
            actions.Add(action);
            Calculate();
        }

        public virtual void Calculate()
        {
            // Reset
            addedValue = default;
            addedPercentageValue = default;

            for(int i = 0; i < actions.Count; i++)
            {
                actions[i].Invoke(this);
            }
        }

        public void Remove(UnityAction<CombinedVariable<T0>> action)
        {
            if(actions.Contains(action))
            {
                actions.Remove(action);
                Calculate();
            }
        }

		//public static T0 operator +(CombinedVariable<T0> c, T0 v) => c.addedValue + v;
	}    
}