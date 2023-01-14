using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartButtonScript : MonoBehaviour
{
    // Declare a variable to reference the audio source
    public AudioSource backgroundMusic;
    public Animator animator; 
    public AudioClip startSound;

    private void Start()
    {
        // Play the background music
        backgroundMusic.Play();
    }

    public void StartGame()
    {
        // Play the start sound
        backgroundMusic.PlayOneShot(startSound);
        // Wait for 3 seconds before stopping the music
        StartCoroutine(WaitAndStop(0.5f));
    }

    IEnumerator WaitAndStop(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(0.5f);  // Wait for the animation to complete
        backgroundMusic.Stop();
        SceneManager.LoadScene("SampleScene");
    }
}
