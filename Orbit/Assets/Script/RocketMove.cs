using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{

    public Rigidbody sphere;
    public float accForward = 5f, accBackward = 3f, speedMax = 30f, turnPower = 180, jumpPower = 300f, gravPower;

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
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("jumping");
            sphere.AddForce(Vector3.up * jumpPower * 1000f);
            }
        

        isTurning = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, isTurning * turnPower * Time.deltaTime, 0f));

        transform.position = sphere.transform.position;
    }

    void FixedUpdate(){
        sphere.AddForce(Vector3.up * -gravPower * 10f);
    
        if(Mathf.Abs(isAccel) > 0) 
        {
            sphere.AddForce(transform.up * isAccel);
        }
    }
}
