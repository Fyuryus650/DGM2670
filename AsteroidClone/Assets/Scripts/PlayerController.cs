using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;


    // Start is called before the first frame update
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
        Destroy(gameObject);
    }
}
