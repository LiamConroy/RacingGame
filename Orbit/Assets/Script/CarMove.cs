using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    public Rigidbody RB;
    public float accelFor = 8f;
    public float accelBack = 5f;
    public float maxSpeed = 50f;
    public float speedInput, turnInput;
    // Start is called before the first frame update
    void Start()
    {
        RB.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        speedInput = 0f;
        if(Input.GetAxis("Vertical") >0){
            speedInput = Input.GetAxis("Vertical") * accelFor * 1000f;
        }

        else if(Input.GetAxis("Vertical") >0){
            speedInput = Input.GetAxis("Vertical") * accelBack * 1000f;
        }

        transform.position = RB.transform.position;
    }

    void FixedUpdate(){
        
        if(Mathf.Abs(speedInput) > 0){
        RB.AddForce(transform.forward * accelFor * Time.deltaTime * 1000f);
        }
    }
}
