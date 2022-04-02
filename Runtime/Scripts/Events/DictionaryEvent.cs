using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular
{
    [CreateAssetMenu(fileName = "Event Dictionary", menuName = "SLIDDES/Modular/Events/Event Dictionary")]
    public class DictionaryEvent : Event<Dictionary<ScriptableObject, ScriptableObject>>
    {
        public DictionaryVariable test;
    }
}
