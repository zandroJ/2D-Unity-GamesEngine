using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Animator animator; 
    public GameObject gameOverPanel;
    // public AudioClip gameOverMusic; //   line to declare an AudioClip for the game over music

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
            bgm.StopMusic();// Pause the current music
            // bgm.PlayMusic(gameOverMusic); // Play the game over music
            
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
public void Home()
{
    if (SceneManager.GetActiveScene().name == "GameScene") {
            // bgm.StopMusic(gameOverMusic);
            bgm.StopMusic();
    }
     StartCoroutine(WaitAndStop(0.5f));
}

IEnumerator WaitAndStop(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        animator.SetTrigger("fadeoutanim");
        yield return new WaitForSeconds(0.5f);  // Wait for the animation to complete
        SceneManager.LoadScene("Menu");
    }
}


