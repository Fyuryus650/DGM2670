using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
    //name events and classes for what they do
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
