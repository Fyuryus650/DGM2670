using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;
    public IntData livesData;
    private int lives;


    private void Start()
    {
        lives = livesData.value;
    }
    public void DefaultRot()
    {
        gameObject.transform.rotation = new Quaternion(0f, 0f, 0f,0f);
    }
    public void RotatePlayerRight()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
    }
    public void RotatePlayerLeft()
    {
        transform.Rotate(Vector3.forward * -turnSpeed * Time.deltaTime);
    }
    public void KillPlayer()
    {
        lives = lives - 1;
        if(lives <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
