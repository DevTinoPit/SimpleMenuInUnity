using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class UnityEventString : UnityEvent<string> { }

    public class GameEventListenerString : GameEventListener
    {
        public UnityEventString response;

        public override void OnEventRaised(string input)
        {
            base.OnEventRaised(input);

            response.Invoke(input);
        }
    }
}