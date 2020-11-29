using UnityEngine;
using UnityEngine.Events;

namespace VirtualiSurg.Architecture
{
    [System.Serializable]
    public class UnityEventGameObject : UnityEvent<GameObject> { }

    public class GameEventListenerGameObject : GameEventListener
    {
        public UnityEventGameObject response;

        public override void OnEventRaised(GameObject input)
        {
            base.OnEventRaised(input);

            response.Invoke(input);
        }
    }
}