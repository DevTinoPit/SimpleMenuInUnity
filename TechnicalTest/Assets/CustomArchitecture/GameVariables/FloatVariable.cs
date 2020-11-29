using System;
using UnityEngine;

namespace VirtualiSurg.Architecture
{
    [CreateAssetMenu(fileName = "Float", menuName = "Variables/Float", order = 0)]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField]
        private float DefaultValue;

        private float currentValue;

        private Action onValueChanged;

        public float CurrentValue
        {
            get { return currentValue; }
            set
            {
                if (currentValue != value)
                {
                    currentValue = value;
                    onValueChanged?.Invoke();
                }
            }
        }

        private void OnEnable()
        {
            currentValue = DefaultValue;
            onValueChanged = null;
        }

        public void AddListener(Action listener)
        {
            onValueChanged += listener;
        }

        public void RemoveListener(Action listener)
        {
            onValueChanged -= listener;
        }
    }
}