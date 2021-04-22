using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{

    public Rigidbody sphere;
    public float accForward = 5f, accBackward = 3f, speedMax = 30f, turnPower = 180, gravPower = 10f;

    private float isAccel, isTurning;

    private bool isGrounded;

    public LayerMask isGround;
    public float groundRayLength = 0.5f;
    public Transform groundRayPoint;

    void Start()
    {
        sphere.transform.parent = null;
    }

    void Update()
    {
        isAccel = 0f;
        if(Input.GetAxis("Vertical")>0) {
            isAccel = Input.GetAxis("Vertical") * accForward * 1000f;
        } else if (Input.GetAxis("Vertical")<0) {
            isAccel = Input.GetAxis("Vertical") * accBackward * 1000f;
        }

        isTurning = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, isTurning * turnPower * Time.deltaTime, 0f));

        transform.position = sphere.transform.position;
    }

    void FixedUpdate(){
        isGrounded = false;
        // Raycast hit;

        // if(Physics.Raycast(groundRayPoint.position, transform.up, out hit, groundRayLength, isGround)) 
        // {}
        if(Mathf.Abs(isAccel) > 0) 
        {
            sphere.AddForce(transform.up * isAccel);
        }
    }
}
