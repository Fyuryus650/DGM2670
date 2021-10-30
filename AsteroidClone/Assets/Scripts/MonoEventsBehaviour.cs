using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, DestroyEvent, ForwardThrustEvent, TurnShipEvent;
    //at the start of the event invokes an event
    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDestroy()
    {
        DestroyEvent.Invoke();
    }
    private void OnButtonDown()
    {
        ForwardThrustEvent.Invoke();
    }
}
