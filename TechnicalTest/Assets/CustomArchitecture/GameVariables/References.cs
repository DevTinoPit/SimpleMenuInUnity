using System;
using UnityEngine;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class FloatReadOnlyReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private float constantValue;
        [SerializeField]
        private FloatVariable variable;

        public float value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class FloatReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private float constantValue;
        [SerializeField]
        private FloatVariable variable;

        public float value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
            set
            {
                if (!useConstant)
                    variable.CurrentValue = value;
                else
                {
                    Debug.LogWarning("Setting constant value in FloatReference");
                    constantValue = value;
                }
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class IntReadOnlyReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private int constantValue;
        [SerializeField]
        private IntVariable variable;

        public int value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class IntReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private int constantValue;
        [SerializeField]
        private IntVariable variable;

        public int value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
            set
            {
                if (!useConstant)
                    variable.CurrentValue = value;
                else
                {
                    Debug.LogWarning("Setting constant value in IntReference");
                    constantValue = value;
                }
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class BoolReadOnlyReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private bool constantValue;
        [SerializeField]
        private BoolVariable variable;

        public bool value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class BoolReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private bool constantValue;
        [SerializeField]
        private BoolVariable variable;

        public bool value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
            set
            {
                if (!useConstant)
                    variable.CurrentValue = value;
                else
                {
                    Debug.LogWarning("Setting constant value in BoolReference");
                    constantValue = value;
                }
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class StringReadOnlyReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private string constantValue;
        [SerializeField]
        private StringVariable variable;

        public string value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class StringReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private string constantValue;
        [SerializeField]
        private StringVariable variable;

        public string value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
            set
            {
                if (!useConstant)
                    variable.CurrentValue = value;
                else
                {
                    Debug.LogWarning("Setting constant value in StringReference");
                    constantValue = value;
                }
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class GameObjectReadOnlyReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private GameObject constantValue;
        [SerializeField]
        private GameObjectVariable variable;

        public GameObject value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }

    [System.Serializable]
    public class GameObjectReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private GameObject constantValue;
        [SerializeField]
        private GameObjectVariable variable;

        public GameObject value
        {
            get
            {
                return useConstant ? constantValue : variable.CurrentValue;
            }
            set
            {
                if (!useConstant)
                    variable.CurrentValue = value;
                else
                {
                    Debug.LogWarning("Setting constant value in GameObjectReference");
                    constantValue = value;
                }
            }
        }

        public void AddListener(Action listener)
        {
            variable.AddListener(listener);
        }

        public void RemoveListener(Action listener)
        {
            variable.RemoveListener(listener);
        }
    }
}