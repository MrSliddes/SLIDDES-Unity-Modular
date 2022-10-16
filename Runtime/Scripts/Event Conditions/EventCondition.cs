using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace SLIDDES.Modular
{
    public class EventCondition : EnumBaseType<EventCondition>
    {
        public static readonly EventConditionBoolean none = new EventConditionBoolean(0, "none");

        public int index;

        public EventCondition(int key, string value) : base(key, value)
        {

        }

        public ReadOnlyCollection<EventCondition> GetValues()
        {
            return GetBaseValues();
        }
    }
}
