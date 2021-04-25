using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapCounter : MonoBehaviour
{
    public Text lapText;

    // Start is called before the first frame update
    void Start()
    {
        
        lapText.text = CheckpointManager.lapIndex.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        lapText.text = CheckpointManager.lapIndex.ToString();
    }
}
