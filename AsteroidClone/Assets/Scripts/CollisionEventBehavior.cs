using UnityEngine;
using UnityEngine.Events;

public class CollisionEventBehavior : MonoBehaviour
{
    public UnityEvent CollisonEvent;

    public void OnCollisionEnter(Collision collision)
    {
        CollisonEvent.Invoke();
    }
}
