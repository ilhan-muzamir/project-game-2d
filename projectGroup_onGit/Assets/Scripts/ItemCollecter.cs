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

    private bool isMorCoinActive = false;
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

            if (coin >= 3)
            {
                GameComp.SetActive(true);
                Debug.Log("GameComp activated. Player collected 3 or more coins.");
            }
            else
            {
                if(!isMorCoinActive)
                MorCoin.SetActive(true);
                Debug.Log("MorCoin activated. Player collected less than 3 coins.");
                isMorCoinActive = true;

            }


        }
    }
}
