﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController instance;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Awake() {
        MakeSingleton();
        audioSource  = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    void MakeSingleton(){
        if(instance != null){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

   public void PlayMusic(bool play){
       if(play){
           if(!audioSource.isPlaying){
               audioSource.Play();
           }
       }else{
           if(audioSource.isPlaying){
               audioSource.Stop();
           }
       }
   }
}
