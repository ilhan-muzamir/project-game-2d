using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicStop : MonoBehaviour
{
    public TMP_Text popuptext;

    private GameObject window;
    private Animator popupAnimator; // Corrected the type to Animator

    private Queue<string> popupQueue;
    private bool isActive;
    private Coroutine queueChecker;

    private void Start()
    {
        window = transform.GetChild(0).gameObject;
        popupAnimator = window.GetComponent<Animator>();
        window.SetActive(false);
        popupQueue = new Queue<string>();
    }

    private void AddToQueue(string text)
    {
        popupQueue.Enqueue(text);
        if (queueChecker == null)
            queueChecker = StartCoroutine(CheckQueue()); // Corrected the typo
    }

    private void ShowPopup(string text)
    {
        isActive = true;
        window.SetActive(true);
        popupAnimator.Play("PopupAnimation"); // Corrected the typo
    }

    private IEnumerator CheckQueue()
    {
        do
        {
            ShowPopup(popupQueue.Dequeue());
            do
            {
                yield return null; // Added the semicolon
            }
            while (popupAnimator.GetCurrentAnimatorStateInfo(0).IsTag("idle")); // Corrected the method name

        } while (popupQueue.Count > 0);
        isActive = false;
        window.SetActive(false);
        queueChecker = null;
    }
}
