using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SEvent = SLIDDES.Modular.Event;

namespace SLIDDES.Modular.Samples
{
    [AddComponentMenu("SLIDDES/Modular/Samples/Display Variables")]
    public class DisplayVariables : MonoBehaviour
    {
        [Header("References")]
        public BoolReference boolReference;
        public DoubleReference doubleReference;
        public FloatReference floatReference;
        public IntReference intReference;
        public LongReference longReference;
        public StringReference stringReference;
        public Vector2Reference vector2Reference;
        public Vector2IntReference vector2IntReference;
        public Vector3Reference vector3Reference;
        public Vector3IntReference vector3IntReference;
        public DictionaryVariableReference dictionaryVariableReference;

        [Header("Variables")]
        //public Variable<float> vFloat; also possible, but recoomended to use FloatVariable
        public BoolVariable boolVariable;
        public ByteVariable byteVariable;
        public CharVariable charVariable;
        public DecimalVariable decimalVariable;
        public DictionaryVariable dictionaryVariable;
        public DoubleVariable doubleVariable;
        public FloatVariable floatVariable;
        public IntVariable intVariable;
        public ListVariable listVariable;
        public LongVariable longVariable;
        public ObjectVariable objectVariable;
        public SByteVariable sByteVariable;
        public ShortVariable shortVariable;
        public StringVariable stringVariable;
        public UIntVariable uIntVariable;
        public ULongVariable uLongVariable;
        public UShortVariable uShortVariable;
        public Vector2Variable vector2Variable;
        public Vector2IntVariable vector2IntVariable;
        public Vector3Variable vector3Variable;
        public Vector3IntVariable vector3IntVariable;

        [Header("Events")]
        public SEvent eventTest;
        public IntEvent intEvent;


        private void OnEnable()
        {
            floatVariable.onValueChanged.AddListener(DebugFloatValue);
            intEvent.AddListener(x => DebugInt(x));
        }

        private void OnDisable()
        {
            floatVariable.onValueChanged.RemoveListener(DebugFloatValue);
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
            dictionaryVariable.Value = new Dictionary<ScriptableObject, ScriptableObject>();
            for(int i = 0; i < 100; i++)
            {
                dictionaryVariable.Value.Add(IntVariable.Create(i), intVariable);
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
