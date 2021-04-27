using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckpointManager : MonoBehaviour
{
    public static int checkpointIndex;
    public int checkpointMax = 13;
    public static int lapIndex = 1;
    public int lapMax = 4;
    
void Start(){
    lapIndex = 1;
}
void Update(){

        Debug.Log(checkpointIndex);

        if (checkpointIndex >= checkpointMax) {
            lapIndex = lapIndex + 1;
            Debug.Log("Lap: " +lapIndex+ "/3");
            checkpointIndex = 1;
        }

        if(lapIndex == 4){
             Debug.Log("You Win");
            SceneManager.LoadScene("WinScene");
         }

}

}
