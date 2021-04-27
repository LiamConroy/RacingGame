using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AIcheckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AIcheckpoints;

    public int AIlap = 1;
    public int AIlapMax = 3; 
    void Update(){
        if(AIlap == AIlapMax){
            // SceneManager.LoadScene("");
            Debug.Log("You lose");                      
        }    

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("AtomRocket"))
        {
            AIlap++;
            Debug.Log("checkpoint hit");
        }
    }

}
