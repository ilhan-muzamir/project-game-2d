using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{
    public GameObject HiddenBlk;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (HiddenBlk != null)
            {
                // Activate HiddenBlk
                HiddenBlk.SetActive(true);
            }
            else
            {
                Debug.LogWarning("HiddenBlk is null. Make sure to assign the GameObject in the inspector.");
            }
        }
    }
}
