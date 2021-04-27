using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapCounter : MonoBehaviour
{
    public Text lapText;
    void Update()
    {
        lapText.text = "Lap: " + CheckpointManager.lapIndex.ToString() + "/3";
    }
}
