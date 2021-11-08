using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent StartEvent, DestroyEvent, IsGameActive;
    //at the start of the event invokes an event
    private void Start()
    {
        StartEvent.Invoke();
    }

    private void OnDestroy()
    {
        DestroyEvent.Invoke();
    }

    public void OnCollisonEnter()
    {
        IsGameActive.Invoke();
    }
}
