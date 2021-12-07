using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent StartEvent, DestroyEvent, IsGameActive;
    //at the start of the event invokes an event
    public void Start()
    {
        StartEvent.Invoke();
    }

    public void OnDestroy()
    {
        DestroyEvent.Invoke();
    }
}
