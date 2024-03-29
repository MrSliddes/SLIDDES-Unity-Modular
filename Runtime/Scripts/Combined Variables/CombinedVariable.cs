using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    public abstract class CombinedVariable<T0>
    {
        public T0 Value => GetValue();

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

        public CombinedVariable(T0 baseValue)
        {
            this.baseValue = baseValue;
            Calculate();
        }            

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

        public virtual T0 GetValue()
        {
            return baseValue;
        }

		//public static T0 operator +(CombinedVariable<T0> c, T0 v) => c.addedValue + v;
	}    
}