using System;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    public abstract class GameEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public GameEvent customEvent;

        void OnEnable()
        {
            if (customEvent != null)
            {
                customEvent.RegisterListener(this);
            }
            else
            {
                enabled = false;
            }
        }
        void OnDisable()
        {
            if (customEvent != null)
            {
                customEvent.UnregisterListener(this);
            }
        }

        public virtual void OnEventRaised() { Debug.Log(gameObject.name + " listening event raised " + customEvent.name); }
        public virtual void OnEventRaised(int input) { Debug.Log(gameObject.name + " listening event raised " + customEvent.name + " value:" + input); }
        public virtual void OnEventRaised(float input) { Debug.Log(gameObject.name + " listening event raised " + customEvent.name + " value:" + input); }
        public virtual void OnEventRaised(string input) { Debug.Log(gameObject.name + " listening event raised " + customEvent.name + " value:" + input); }
        public virtual void OnEventRaised(bool input) { Debug.Log(gameObject.name + " listening event raised " + customEvent.name + " value:" + input); }
        public virtual void OnEventRaised(UnityEngine.Object input) { }
        public virtual void OnEventRaised(GameObject input) { }
        public virtual void OnEventRaised(Transform input) { }
    }
}