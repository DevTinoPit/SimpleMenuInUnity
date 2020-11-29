using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class UnityEventInt : UnityEvent<int> { }

    public class GameEventListenerInt : GameEventListener
    {
        public UnityEventInt response;

        public override void OnEventRaised(int input)
        {
            base.OnEventRaised(input);

            response.Invoke(input);
        }
    }
}