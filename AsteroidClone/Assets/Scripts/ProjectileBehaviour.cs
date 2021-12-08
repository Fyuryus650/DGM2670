using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
