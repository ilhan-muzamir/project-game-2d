using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript2lvl3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ReplayMethod()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void GoToLVL3()
    {
        SceneManager.LoadScene("LVL3");
    }
}
