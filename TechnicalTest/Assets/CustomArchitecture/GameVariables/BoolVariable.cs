using System;
using UnityEngine;

namespace VirtualiSurg.Architecture
{
    [CreateAssetMenu(fileName = "Bool", menuName = "Variables/Bool", order = 2)]
    public class BoolVariable : ScriptableObject
    {
        [SerializeField]
        private bool DefaultValue;

        private bool currentValue;

        private Action onValueChanged;

        public bool CurrentValue
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