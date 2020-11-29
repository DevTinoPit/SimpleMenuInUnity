using System;
using UnityEngine;

namespace VirtualiSurg.Architecture
{
    [CreateAssetMenu(fileName = "String", menuName = "Variables/String", order = 3)]
    public class StringVariable : ScriptableObject
    {
        [SerializeField]
        private string DefaultValue;

        private string currentValue;

        private Action onValueChanged;

        public string CurrentValue
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