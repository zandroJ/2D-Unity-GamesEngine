using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public AudioClip gameOverMusic; //   line to declare an AudioClip for the game over music

    public BackgroundMusic bgm; //   line to declare a reference to the BackgroundMusic script

    void Start() //   line to initialize the bgm reference
    {
        bgm = GameObject.FindObjectOfType<BackgroundMusic>();
         bgm.PlayMusic(bgm.backgroundMusic);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null){
            gameOverPanel.SetActive(true);
            bgm.PauseMusic(); // Pause the current music
            bgm.PlayMusic(gameOverMusic); // Play the game over music
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
}
