using UnityEngine;

//script referenced from https://unity3d.college/2017/07/03/using-vector3-reflect-to-cheat-ball-bouncing-physics-in-unity/

public class ProjectileBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Just for debugging, adds some velocity during OnEnable")]
    private Vector3 initialVelocity;

    [SerializeField]
    private float minVelocity = 4f;

    private Vector3 lastFrameVelocity;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialVelocity = gameObject.transform.up * 4;
        rb.velocity = initialVelocity;
    }

    private void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
}

