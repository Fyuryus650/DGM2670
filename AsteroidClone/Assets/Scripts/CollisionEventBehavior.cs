using UnityEngine;
using UnityEngine.Events;

public class CollisionEventBehavior : MonoBehaviour
{
    public UnityEvent CollisonEvent;

    private void OnCollisionEnter(Collision collision)
    {
        CollisonEvent.Invoke();
    }
}
