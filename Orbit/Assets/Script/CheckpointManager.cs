﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckpointManager : MonoBehaviour
{
    public static int checkpointIndex;
    public int checkpointMax = 23;
    public static int lapIndex = 1;
    public int lapMax;
    
void Start(){
       
}
void Update(){

        Debug.Log(checkpointIndex);
         
        if(checkpointIndex == checkpointMax){
            lapIndex = lapIndex + 1;
            Debug.Log("Lap: "+lapIndex);
            checkpointIndex = 0;
        }

        //  if(lapIndex == lapMax){
        //      //SceneManager.LoadScene("SampleScene");
        //     Debug.Log(lapIndex);
        //  }

}

}
