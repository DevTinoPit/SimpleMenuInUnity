using System;
using UnityEngine;

namespace VirtualiSurg.Architecture
{
    [CreateAssetMenu(fileName = "GameObject", menuName = "Variables/GameObject", order = 4)]
    public class GameObjectVariable : ScriptableObject
    {
        [SerializeField]
        private GameObject DefaultValue;

        private GameObject currentValue;

        private Action onValueChanged;

        public GameObject CurrentValue
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