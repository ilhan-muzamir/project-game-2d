using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    public GameObject HiddenBlk;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (HiddenBlk != null)
            {
                // Deactivate HiddenBlk
                HiddenBlk.SetActive(false);
            }
            else
            {
                Debug.LogWarning("HiddenBlk is null. Make sure to assign the GameObject in the inspector.");
            }
        }
    }
}
