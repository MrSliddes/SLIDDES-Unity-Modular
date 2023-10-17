using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    public class CombinedInt : CombinedVariable<int>
    {
		public override void Calculate()
		{
			base.Calculate();
			Value = (baseValue + addedValue) * addedPercentageValue;
		}

		public static int operator +(CombinedInt c, int v) => c.addedValue + v;
		public static int operator -(CombinedInt c, int v) => c.addedValue - v;
		public static int operator *(CombinedInt c, int v) => c.addedPercentageValue + v;
		public static int operator /(CombinedInt c, int v) => c.addedPercentageValue - v;
	}
}
