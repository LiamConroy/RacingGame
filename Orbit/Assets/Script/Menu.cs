using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    // RocketMove move;
    // Start(){
      
    // }

    
   
    public static bool ThirdCamOn = true;
    public static bool FirstCamOn;
    public TMP_Text camText;
    public GameObject Canvas;

    void Awake(){
    }

    void Start(){
        Canvas.SetActive(true);
        Debug.Log("Canvas Active");
    } 

    void Update() {
        if(ThirdCamOn){
            camText.text = "Third Person Mode";
        } else 
            camText.text = "First Person Mode";
    }

    public void StartGame(){
        SceneManager.LoadScene("LevelSelect");
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

    public void LevelOne(){
        SceneManager.LoadScene("Supernova");
    }

    public void LevelTwo(){
        SceneManager.LoadScene("SpaceStation");
    }

    public void CamToggle(bool thirdTog){
        
        if(thirdTog){
            // camText.text = "Third Person Mode";

            ThirdCamOn = true;
            FirstCamOn= false;

           

            Debug.Log("ThirdPerson ON");
        }

        else if(!thirdTog){
            // camText.text = "First Person Mode";

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
