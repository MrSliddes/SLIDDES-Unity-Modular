using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SLIDDES.Modular
{
    /// <summary>
    /// Event only used as trigger with no passtrough value
    /// </summary>
    /// <remarks>bool type does nothing</remarks>
    [CreateAssetMenu(fileName = "Event", menuName = "SLIDDES/Modular/Events/Event", order = -1)]
    public class EmptyEvent : Event<bool>
    {
        public override void Invoke(bool value = false)
        {
            base.Invoke(value);
        }
    }
}
