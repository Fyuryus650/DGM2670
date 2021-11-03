using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotatePlayerRight()
    {
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
    }
    public void RotatePlayerLeft()
    {
        transform.Rotate(Vector3.forward * -turnSpeed * Time.deltaTime);
    }
}
