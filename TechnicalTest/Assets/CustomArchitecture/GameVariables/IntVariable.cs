using System;
using UnityEngine;

namespace VirtualiSurg.Architecture
{
    [CreateAssetMenu(fileName = "Int", menuName = "Variables/Int", order = 1)]
    public class IntVariable : ScriptableObject
    {
        [SerializeField]
        private int DefaultValue;

        private int currentValue;

        private Action onValueChanged;

        public int CurrentValue
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