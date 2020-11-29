using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class UnityEventTransform : UnityEvent<Transform> { }

    public class GameEventListenerTransform : GameEventListener
    {
        public UnityEventTransform response;

        public override void OnEventRaised(Transform input)
        {
            base.OnEventRaised(input);

            response.Invoke(input);
        }
    }
}