using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderMovement : MonoBehaviour
{
    private float vertical;
    private bool isLadder;
    private bool isCLimbing;
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        {
            if (isLadder && Mathf.Abs(vertical) > 0f)
            {
                isCLimbing = true;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            isLadder = false;
            isCLimbing = false;
        }
    }
    private void FixedUpdate()
    {
        if (isCLimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 5f;
        }
    }

}
