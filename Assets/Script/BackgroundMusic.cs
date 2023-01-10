using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic bgm;
    public AudioSource audioSource;
    public AudioClip backgroundMusic; //   field to hold the background music

    void Awake()
    {
        if(bgm == null){
            bgm = this;
            DontDestroyOnLoad(bgm);
        }
        else{
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        PlayMusic(backgroundMusic); // Play the background music in the Start method
    }

    public void PauseMusic()
    {
        audioSource.Pause();
    }

    public void PlayMusic(AudioClip newClip)
    {
        audioSource.clip = newClip;
        audioSource.Play();
    }
}
