using UnityEngine;
using UnityEngine.Events;

public class TeleportBehaviour : MonoBehaviour
{
    public UnityEvent TeleportEvent;

    private void OnCollisionEnter(Collision collision)
    {
        TeleportEvent.Invoke();
        print("Entered Collider");
    }
}
