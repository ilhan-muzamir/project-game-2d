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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coin++;
            CoinText.text = ":" + coin;
            FinalCoinText.text = ":" + coin;
        }
    }
}
