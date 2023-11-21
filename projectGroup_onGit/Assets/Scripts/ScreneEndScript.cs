using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool levelCompleted = false;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            levelCompleted = true;
            ReplayMethod();
        }
    }

    public void ReplayMethod()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void GoToEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }

}
