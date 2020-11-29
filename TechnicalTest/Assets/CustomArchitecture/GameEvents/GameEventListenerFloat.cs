using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class UnityEventFloat : UnityEvent<float> { }

    public class GameEventListenerFloat : GameEventListener
    {
        public UnityEventFloat response;

        public override void OnEventRaised(float input)
        {
            base.OnEventRaised(input);

            response.Invoke(input);
        }
    }
}