using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class TextUpdateScript : MonoBehaviour
{
    public UnityEvent UpdateText,NoHealth;
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
        healthVal = healthVal - 1;
        txt.text = healthVal.ToString();
    }
}
