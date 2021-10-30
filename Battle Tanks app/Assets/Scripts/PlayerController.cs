using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject turret;
    private GameObject player;
    private GameObject elevControl;

    private Rigidbody chassisRB;

    private float speed = 8f;

    private float turnSpeed = 35.0f;
    private float turretTurnSpeed = 50.0f;
    private float hInput;
    private float fInput;
    private float turHInput;
    private float vInput;
    private float elevSpeed = 10.0f;
    private float elevLimit;
    private Vector3 turPos = new Vector3(0.0f, 1.2f, 0.0f);

    void Start()
    {
        player = GameObject.Find("player");
        turret = GameObject.Find("turret");
        elevControl = GameObject.Find("tubeControl");
        chassisRB = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        // Sets inputs for the controls
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        vInput = Input.GetAxis("Vertical2");
        turHInput = Input.GetAxis("Horizontal2");

        //makes the vehicle go forward
        transform.Translate(Vector3.forward * speed * fInput *Time.deltaTime);

        // Makes the vehicle turn left and right with A and D
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);

        // Sets position for turret on top of vehicle and turns the turret with the chassis
        turret.transform.position = player.transform.position + turPos;
        turret.transform.Rotate(Vector3.right, turnSpeed * hInput * Time.deltaTime);

        // rotates turret with q and e (ensure Horizontal2 type is set to key or mouse on pc)
        turret.transform.Rotate(Vector3.right, turretTurnSpeed * turHInput * Time.deltaTime);

        // elevates gun tube
        elevControl.transform.Rotate(Vector3.right, elevSpeed * vInput * Time.deltaTime);
    }
}
