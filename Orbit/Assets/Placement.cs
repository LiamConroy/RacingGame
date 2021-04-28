using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Placement : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text lapText;
    public TMP_Text firstText;
    public TMP_Text secondText;

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
                firstText.text = "#1: Player";
                secondText.text = "#2: Enemy";
            }

            else if(EnemyMove.enemyLaps > CheckpointManager.lapIndex){
                Debug.Log("You are in 2nd Place");
                lapText.text = "2nd Place";
                firstText.text = "#1: Enemy";
                secondText.text = "#2: Player";
            }

            else {
                Debug.Log("You are in 1st Place");
                lapText.text = "1st Place";
                firstText.text = "#1: Player";
                secondText.text = "#2: Enemy";
            }
        }


        else if(EnemyMove.currentPathPoint > CheckpointManager.checkpointIndex){
            if(EnemyMove.enemyLaps > CheckpointManager.lapIndex){
                Debug.Log("You are in 2nd Place");
                lapText.text = "2nd Place";
                firstText.text = "#1: Enemy";
                secondText.text = "#2: Player";
            }

            else if(EnemyMove.enemyLaps < CheckpointManager.lapIndex){
                Debug.Log("You are in 1st Place");
                lapText.text = "1st Place";
                firstText.text = "#1: Player";
                secondText.text = "#2: Enemy";
            }

            else {
                Debug.Log("You are in 2nd Place");
                lapText.text = "2nd Place";
                firstText.text = "#1: Enemy";
                secondText.text = "#2: Player";
            }
        }
    }
}
