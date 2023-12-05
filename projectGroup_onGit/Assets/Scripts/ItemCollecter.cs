using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class ItemCollecter : MonoBehaviour
{
    private int coin = 0;

    [SerializeField] private Text CoinText;
    [SerializeField] private Text FinalCoinText;

    public GameObject GameComp;
    public GameObject MorCoin;

    [SerializeField] private AudioSource CoinCollectedSoundFX;
    [SerializeField] private AudioSource BackgroundMusic;

    private bool isMorCoinActive = false;
    private bool isMusicStopped = false;
    public AudioSource audiosource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            CoinCollectedSoundFX.Play();
            Destroy(collision.gameObject);
            coin++;
            CoinText.text = ":" + coin;
            FinalCoinText.text = ":" + coin;
           
        }
        if (collision.gameObject.CompareTag("EndFlag"))
        {
            if (coin >= 5)
            {
                GameComp.SetActive(true);
                Debug.Log("GameComp activated. Player collected 3 or more coins.");

                // Stop the music when GameComp is activated
                StopMusic();
            }
            else
            {
                if (!isMorCoinActive)
                {
                    MorCoin.SetActive(true);
                    Debug.Log("MorCoin activated. Player collected less than 3 coins.");
                    isMorCoinActive = true;
                }
            }
        }
    }

    private void StopMusic()
    {
        audiosource = GetComponent<AudioSource>();
        // Add logic to stop the background music here
        if (BackgroundMusic != null)
        {
            BackgroundMusic.Stop();
        }

        isMusicStopped = true;
    }
}