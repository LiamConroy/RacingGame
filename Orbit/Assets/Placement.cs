using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Placement : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text lapText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyMove.currentPathPoint < CheckpointManager.checkpointIndex){
            if(EnemyMove.enemyLaps < CheckpointManager.lapIndex){
                Debug.Log("You are in 1st Place");
                lapText.text = "1st Place";
            }

            else if(EnemyMove.enemyLaps > CheckpointManager.lapIndex){
                Debug.Log("You are in 2nd Place");
                lapText.text = "2nd Place";
            }

            else {
                Debug.Log("You are in 1st Place");
                lapText.text = "1st Place";
            }
        }


        else if(EnemyMove.currentPathPoint > CheckpointManager.checkpointIndex){
            if(EnemyMove.enemyLaps > CheckpointManager.lapIndex){
                Debug.Log("You are in 2nd Place");
                lapText.text = "2nd Place";
            }

            else if(EnemyMove.enemyLaps < CheckpointManager.lapIndex){
                Debug.Log("You are in 1st Place");
                lapText.text = "1st Place";
            }

            else {
                Debug.Log("You are in 2nd Place");
                lapText.text = "2nd Place";
            }
        }
    }
}
