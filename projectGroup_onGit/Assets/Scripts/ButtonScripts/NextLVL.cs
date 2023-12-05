using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void GoNextLevel()
    {
        // Assuming MusicController is the name of the GameObject with the MusicController script
        MusicController musicController = FindObjectOfType<MusicController>();

        // Check if the MusicController is found
        if (musicController != null)
        {
            // Stop the music
            musicController.StopMusic();
            Debug.Log("Music stopped.");

            // Destroy the MusicController GameObject
            Destroy(musicController.gameObject);
        }

        // Load the next scene in the build
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }

}
