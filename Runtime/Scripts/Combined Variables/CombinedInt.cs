using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
	[System.Serializable]
    public class CombinedInt : CombinedVariable<int>
    {
		public CombinedInt(int baseValue) : base(baseValue)
		{
		}

		public override int GetValue()
		{
			return (baseValue + addedValue) * (addedPercentageValue == 0 ? 1 : addedPercentageValue);
		}

		public static int operator +(CombinedInt c, int v) => c.addedValue + v;
		public static int operator -(CombinedInt c, int v) => c.addedValue - v;
		public static int operator *(CombinedInt c, int v) => c.addedPercentageValue + v;
		public static int operator /(CombinedInt c, int v) => c.addedPercentageValue - v;
	}
}
