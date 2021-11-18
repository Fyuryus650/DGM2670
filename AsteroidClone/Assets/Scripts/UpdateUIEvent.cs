using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class UpdateUIEvent : MonoBehaviour
{
    public UnityEvent UpdateUI;
    public IntData intData;
    public TextMeshProUGUI uIText;
    private int scoreVal;

    private void Start()
    {
        UpdateUI.Invoke();
        intData.value = scoreVal;
        uIText.text = "Score: " + scoreVal;
    }
    void UpdateScoreValue()
    {
        UpdateUI.Invoke();
        intData.value = scoreVal;
        uIText.text = "Score: " + scoreVal;
    }
}
