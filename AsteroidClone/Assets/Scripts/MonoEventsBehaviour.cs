using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent StartEvent, DestroyEvent, IsGameActiveEvent, GameOverEvent;

    public IntData lives;
    //at the start of the event invokes an event
    public void Start()
    {
        StartEvent.Invoke();
    }

    public void IsGameActive()
    {
        IsGameActiveEvent.Invoke();
    }
    public void IsGameOver()
    {
        if(lives.value <= 0)
        {
            GameOverEvent.Invoke();
        }
    }

    public void OnDestroy()
    {
        DestroyEvent.Invoke();
    }
}
