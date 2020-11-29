using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class UnityEventBool : UnityEvent<bool> { }

    public class GameEventListenerBool : GameEventListener
    {
        public UnityEventBool response;

        public override void OnEventRaised(bool input)
        {
            base.OnEventRaised(input);

            response.Invoke(input);
        }
    }
}