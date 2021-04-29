using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    #pragma warning disable 649
     [SerializeField]
     private AudioSource source;
    #pragma warning restore 649

     public static MusicManager bGMManager;
     public string nowPlaying;
     
     void Awake(){
         if (bGMManager == null){
             bGMManager = this;
             DontDestroyOnLoad(gameObject);
        } else if(bGMManager != this) {
             Destroy(gameObject);
     }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.M)){
            if (bGMManager.source.mute) {
                bGMManager.source.mute = false;
            } else bGMManager.source.mute = true;
    }
    }
}
