using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;
    
    [SerializeField] private LayerMask jumpableGround;

    private float dirX = 0;
    [SerializeField] private float moveSpeed = 7;
    [SerializeField] private float jumpforce = 18f;

    private enum MovementStat { idle, running, jumping, falling }



    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = rb.GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }

        UpdateAnimationState();

    }

    private void UpdateAnimationState()
    {
        MovementStat state;

        if (dirX > 0f)
        {
            state = MovementStat.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
           state = MovementStat.running;
           sprite.flipX = true;
        }
        else
        {
            state = MovementStat.idle;
        }
        if (rb.velocity.y > .1f)
        {
            state = MovementStat.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementStat.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
