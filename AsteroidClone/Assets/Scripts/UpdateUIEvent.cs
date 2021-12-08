using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class UpdateUIEvent : MonoBehaviour
{
    public UnityEvent UpdateUI;
    public IntData intData;
    public TextMeshProUGUI uIText;
    public string category;
    private int scoreVal;

    private void Start()
    {
        scoreVal = intData.value;
        uIText.text = category + scoreVal;
        UpdateUI.Invoke();
    }
    public void UpdateScoreValue()
    {
        UpdateUI.Invoke();
        scoreVal = intData.value;
        if(intData.value <= -1)
        {
            intData.value = 0;
        }
        uIText.text = category + scoreVal;
    }
}
