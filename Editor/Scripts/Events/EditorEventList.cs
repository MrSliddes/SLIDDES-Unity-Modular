using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SLIDDES.Modular.Editor
{
    [CustomEditor(typeof(ListEvent))]
    public class EditorEventList : EditorEvent<List<ScriptableObject>>
    {
        
    }
}
