using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class TextUpdateScript : MonoBehaviour
{
    public UnityEvent UpdateText;
    public Text txt;
    public IntData health;
    public int healthVal;

    public void Start()
    {
        UpdateText.Invoke();
        healthVal = health.value;
        txt.text = healthVal.ToString();
    }
    public void UpdateHealthValue()
    {
        UpdateText.Invoke();
        healthVal--;
        txt.text = healthVal.ToString();
    }
}
