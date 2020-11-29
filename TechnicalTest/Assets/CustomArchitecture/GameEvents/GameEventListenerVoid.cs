using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    public class GameEventListenerVoid : GameEventListener
    {
        public UnityEvent response;

        public override void OnEventRaised()
        {
            base.OnEventRaised();

            response.Invoke();
        }
    }
}