using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2lvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ReplayMethod()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void GoToLVL2()
    {
        SceneManager.LoadScene("LVL2");
    }
}
