using UnityEngine;
using UnityEngine.Events;

public class TeleportBehaviour : MonoBehaviour
{
    public UnityEvent TeleportEvent;

    public void OnCollisionEnter(Collision collision)
    {
        TeleportEvent.Invoke();
    }
}
