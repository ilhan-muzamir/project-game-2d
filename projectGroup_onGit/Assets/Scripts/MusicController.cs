using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private static MusicController instance;
    public AudioSource audiosource;

    private void Awake()
    {
        // Ensure only one instance of the MusicController exists
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Play your music here (assuming you have an AudioSource component attached)
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }    // Method to stop the music
    public void StopMusic()
    {
        audiosource = GetComponent<AudioSource>();
        if (audiosource != null && audiosource.isPlaying)
        {
            audiosource.Stop();
            Debug.Log("Music stopped.");
        }
    }
}
