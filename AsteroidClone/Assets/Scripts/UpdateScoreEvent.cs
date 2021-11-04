using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class UpdateScoreEvent : MonoBehaviour
{
    public UnityEvent UpdateScore;

    void OnCollisionEnter()
    {
        UpdateScore.Invoke();
        GetComponent<TextMeshPro>();
        TextMeshPro.print("Score" + UpdateScore);
    }
}
