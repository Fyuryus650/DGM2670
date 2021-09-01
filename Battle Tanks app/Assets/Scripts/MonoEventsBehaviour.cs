using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, destroyEvent;
    //at the start of the event invokes an event
    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }
}
