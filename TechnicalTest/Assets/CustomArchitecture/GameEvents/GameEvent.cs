using System.Collections.Generic;
using UnityEngine;

namespace VirtualiSurg.Architecture
{
    [CreateAssetMenu]
    public class GameEvent : ScriptableObject
    {
        private readonly List<GameEventListener> listeners = new List<GameEventListener>();

        public void RegisterListener(GameEventListener listener)
        {
            if (!listeners.Contains(listener))
                listeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (listeners.Contains(listener))
                listeners.Remove(listener);
        }


        /// <summary>
        /// Called whenever the custom event needs to be raised.
        /// </summary>
        public void Raise()
        {
            Debug.Log("GameEventRaised : " + name);
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }
        public void Raise(int input)
        {
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(input);
            }
        }
        public void Raise(float input)
        {
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(input);
            }
        }
        public void Raise(string input)
        {
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(input);
            }
        }
        public void Raise(bool input)
        {
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(input);
            }
        }
        public void Raise(UnityEngine.Object input)
        {
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(input);
            }
        }
        // Note: GameObject and Transform input types are explicitely defined below, although the Object type has been described already,
        // because Unity inspector does not allow dynamic GameObject or Transform parameters without those definitions
        public void Raise(GameObject input)
        {
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(input);
            }
        }
        public void Raise(Transform input)
        {
            // Parse listeners backward
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(input);
            }
        }
    }
}