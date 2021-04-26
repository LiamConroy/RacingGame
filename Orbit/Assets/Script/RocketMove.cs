using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
    public GameObject ThirdPersonCam;
    public bool ThirdCamOn = true;
    public GameObject FirstPersonCam;
    public bool FirstCamOn;
    public Rigidbody sphere;
    public float accForward = 5f, accBackward = 3f, speedMax = 30f, turnPower = 180, thrustPower = 10f, gravPower;

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
        if(Input.GetKey(KeyCode.Space)) {
            sphere.AddForce(transform.forward * thrustPower * 100f);
            }
        

        isTurning = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, isTurning * turnPower * Time.deltaTime, 0f));

        transform.position = sphere.transform.position;


        if(Input.GetKey(KeyCode.P)){
            if(ThirdCamOn){
                FirstPerson();
                ThirdCamOn = false;
                Debug.Log("FP ON");
            }

            else{
                ThirdPerson();
                ThirdCamOn = true;
                Debug.Log("TP ON");
            }
        }
    }

    void FixedUpdate(){
        sphere.AddForce(Vector3.up * -gravPower * 1f);
    
        if(Mathf.Abs(isAccel) > 0) 
        {
            sphere.AddForce(transform.up * isAccel);
        }
    }

    // void CamSwitch(){
    //     if(!ThirdCamOn){
    //            FirstPersonCam .SetActive(false);
               

    //            ThirdPersonCam.SetActive(true);

    //            ThirdCamOn = true;
    //            FirstCamOn= false;
    //            Debug.Log("Third person");
    //         }

    //         else if(!FirstCamOn){
    //            FirstPersonCam.SetActive(true);
    //            FirstCamOn= true;

    //            ThirdPersonCam.SetActive(false);
    //            ThirdCamOn = false;mumumu

    //            Debug.Log("First person");
    //         }
    // }

    void FirstPerson() {   
        ThirdPersonCam.SetActive(false);
        FirstPersonCam.SetActive(true);   
        
        
    }

    void ThirdPerson() {
        FirstPersonCam.SetActive(false); 
        ThirdPersonCam.SetActive(true); 
        
    }
}
