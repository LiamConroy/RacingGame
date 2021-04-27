using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointReset : MonoBehaviour

{
public GameObject[] Checkpoints;
  void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerRocket"))
        {

            for (var i = 0; i < 15; i++)
            {
              Checkpoints[i].SetActive(true);  
            }  
        }
    }
}
