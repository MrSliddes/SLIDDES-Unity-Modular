using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    public class CombinedFloat : CombinedVariable<float>
    {
		public override void Calculate()
		{
			base.Calculate();
			Value = (baseValue + addedValue) * addedPercentageValue;
		}

		public static float operator +(CombinedFloat c, float v) => c.addedValue + v;
		public static float operator -(CombinedFloat c, float v) => c.addedValue - v;
		public static float operator *(CombinedFloat c, float v) => c.addedPercentageValue + v;
		public static float operator /(CombinedFloat c, float v) => c.addedPercentageValue - v;
	}
}
