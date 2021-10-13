using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    public void PauseToggle(Toggle obj)
    {
        if (obj.isOn)
        {
            Time.timeScale = obj.isOn ? 0 : 1;
            AudioListener.pause = obj.isOn;
        }
    }
}
