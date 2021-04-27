using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
    public GameObject ThirdPersonCam;
    // public static bool ThirdCamOn = true;
    public GameObject FirstPersonCam;
    // public static bool FirstCamOn;
    public Rigidbody sphere;
    public float accForward, accBackward, speedMax = 30f, turnPower = 180, thrustPower = 10f, gravPower;

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
            sphere.AddForce(transform.up * thrustPower * 100f);
            }
        

        isTurning = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, isTurning * turnPower * Time.deltaTime, 0f));

        transform.position = sphere.transform.position;


        if(Input.GetKeyDown(KeyCode.P)){
            CamSwitch();
        }

        if(!Menu.ThirdCamOn){
            FirstPerson();
        }

        else if(Menu.ThirdCamOn){
            ThirdPerson();
        }
  
    }

    void FixedUpdate(){
        sphere.AddForce(Vector3.up * -gravPower * 1f);
    
        if(Mathf.Abs(isAccel) > 0) 
        {
            sphere.AddForce(transform.forward * isAccel);
        }
    }

    public void CamSwitch(){
        if(!Menu.ThirdCamOn){
               FirstPersonCam.SetActive(false);
               ThirdPersonCam.SetActive(true);

               Menu.ThirdCamOn = true;
               Menu.FirstCamOn= false;
               Debug.Log("Third person");
            }

            else if(!Menu.FirstCamOn){
               FirstPersonCam.SetActive(true);
               Menu.FirstCamOn= true;

               ThirdPersonCam.SetActive(false);
               Menu.ThirdCamOn = false;

               Debug.Log("First person");
            }
    }

    void FirstPerson() {   
        ThirdPersonCam.SetActive(false);
        FirstPersonCam.SetActive(true);         
    }

    void ThirdPerson() {
        FirstPersonCam.SetActive(false); 
        ThirdPersonCam.SetActive(true);     
    }

    
}
