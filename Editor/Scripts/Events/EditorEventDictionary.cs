using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(DictionaryEvent))]
    public class EditorEventDictionary : EditorEvent<Dictionary<ScriptableObject, ScriptableObject>>
    {
        
    }
}
