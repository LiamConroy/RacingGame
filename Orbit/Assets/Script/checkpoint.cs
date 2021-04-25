using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class checkpoint : MonoBehaviour
{

    public GameObject Checkpoint;
    void Update(){
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerRocket"))
        {
            CheckpointManager.checkpointIndex = CheckpointManager.checkpointIndex + 1;
            Checkpoint.SetActive(false);
            // Debug.Log("checkpoint hit");
        }
    }
}

