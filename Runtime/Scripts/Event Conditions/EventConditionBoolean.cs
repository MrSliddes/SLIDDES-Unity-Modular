using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    public class EventConditionBoolean : EventCondition
    {        
        public static readonly EventConditionBoolean equalToo = new EventConditionBoolean(1, "==");
        public static readonly EventConditionBoolean notEqualToo = new EventConditionBoolean(2, "!=");

        public EventConditionBoolean(int key, string value) : base(key, value)
        {

        }
    }
}
