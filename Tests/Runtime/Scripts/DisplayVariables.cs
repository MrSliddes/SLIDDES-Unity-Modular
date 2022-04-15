using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SLIDDES.Modular.Editor.Tests
{
    public class DisplayVariables : MonoBehaviour
    {
        public FloatReference floatReference;

        public Variable<float> vFloat;

        public IntVariable intv;
        public IntEvent intEvent;

        public FloatVariable v;

        public DictionaryVariable dictionaryTest;

        public SLIDDES.Modular.Event eventTest;

        public DictionaryVariableReference dictionaryVariableReference;

        public sbyte sByte;
        public short sshort;
        public string sstring;
        public uint uuint;
        public ulong uulong;
        public ushort uushort;

        private void OnEnable()
        {
            v.onValueChanged.AddListener(DebugFloatValue);
            intEvent.AddListener(x => DebugInt(x));
        }

        private void OnDisable()
        {
            v.onValueChanged.RemoveListener(DebugFloatValue);
        }

        // Start is called before the first frame update
        void Start()
        {
            DictionaryTest();
            if(eventTest != null) eventTest.Invoke();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void DictionaryTest()
        {
            dictionaryTest.Value = new Dictionary<ScriptableObject, ScriptableObject>();
            for(int i = 0; i < 100; i++)
            {
                dictionaryTest.Value.Add(IntVariable.Create(i), intv);
            }
        }

        private void DebugFloatValue(float f)
        {
            Debug.Log(f);
        }

        public void DebugInt(int i)
        {
            Debug.Log(i);
        }
    }
}
