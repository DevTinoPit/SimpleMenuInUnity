using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class UnityEventObject : UnityEvent<Object> { }

    public class GameEventListenerObject : GameEventListener
    {
        public UnityEventObject response;

        public override void OnEventRaised(Object input)
        {
            base.OnEventRaised(input);

            response.Invoke(input);
        }
    }
}