using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    // RocketMove move;
    // Start(){
      
    // }

    
   
    public static bool ThirdCamOn = true;
    public static bool FirstCamOn;
    public GameObject ThirdToggle;
    public GameObject FirstToggle;
    public GameObject Canvas;

    void Awake(){
        DontDestroyOnLoad(Canvas);
    }

    void Start(){
        Canvas.SetActive(true);
        Debug.Log("Canvas Active");
    } 

    public void StartGame(){
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu(){
        SceneManager.LoadScene("MenuScene");
        
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void Controls(){
        SceneManager.LoadScene("Controls");
    }

    public void Options(){
        SceneManager.LoadScene("Options");
    }

    public void Back(){
        SceneManager.LoadScene("MenuScene");
        Canvas.SetActive(false);
        Debug.Log("Canvas Inactive");
    }

    public void CamToggle(bool thirdTog){
        // ThirdToggle.SetActive(true);
        // FirstToggle.SetActive(false);
        
        if(thirdTog){
            ThirdToggle.SetActive(true);
            FirstToggle.SetActive(false); 

            ThirdCamOn = true;
            FirstCamOn= false;

           

            Debug.Log("ThirdPerson ON");
        }

        else if(!thirdTog){
            ThirdToggle.SetActive(false);
            FirstToggle.SetActive(true);

            ThirdCamOn = false;
            FirstCamOn= true; 

        

            Debug.Log("FirstPerson ON");
        }


        // Debug.Log("Third person Toggled");
        // Debug.Log(thirdTog);
    }  


//     void FirstPerson() {   
//         // RocketMove.ThirdPersonCam.SetActive(false);
//         // RocketMove.FirstPersonCam.SetActive(true);   
          
//     }

//    void ThirdPerson() {
//         // RocketMove.FirstPersonCam.SetActive(false); 
//         // RocketMove.ThirdPersonCam.SetActive(true); 
        
//     }

}
