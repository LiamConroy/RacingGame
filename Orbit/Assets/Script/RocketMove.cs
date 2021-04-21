using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{

    public Rigidbody sphere;
    public float accForward = 5f, accBackward = 3f, speedMax = 30f, turnPower = 180;

    private float isAccel, isTurning;

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

        transform.position = sphere.transform.position;
    }

    void FixedUpdate(){
        
        if(Mathf.Abs(isAccel) > 0) 
        {
            sphere.AddForce(transform.up * isAccel);
        }
    }
}
