using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed;
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
}
