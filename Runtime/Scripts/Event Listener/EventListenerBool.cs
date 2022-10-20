using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SLIDDES.Modular
{
    [AddComponentMenu("SLIDDES/Modular/Event Listeners/Event Listener Bool")]
    public class EventListenerBool : EventListener<bool>
    {
        public override bool PassedEventCondition(bool value)
        {
            return eventCondition switch
            {
                EventCondition.none => true,
                EventCondition.equalTo => value == compareValue,
                EventCondition.notEqualTo => value != compareValue,
                _ => false
            };
        }
    }
}