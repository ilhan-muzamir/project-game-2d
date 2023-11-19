using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float waitingTime;
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKeyUp(KeyCode.S))
            {
                waitingTime = 0.5f;
            }
            if (waitingTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitingTime = 0.5f;
            }
            else
            {
                waitingTime -= Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            effector.rotationalOffset = 0;
        }
    }
}
