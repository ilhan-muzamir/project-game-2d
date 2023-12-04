using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour


{
    public void GoBackToMenu()
    {
        // Assuming MusicController is the name of the GameObject with the MusicController script
        MusicController MusicController = FindObjectOfType<MusicController>();

        // Check if the MusicController is found
        if (MusicController != null)
        {
            // Stop the music
            MusicController.StopMusic();
            Debug.Log("Music stopped.");
        }

        // Load the menu scene
        SceneManager.LoadScene("MainMenu");
    }

}
