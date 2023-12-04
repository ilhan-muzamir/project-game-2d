using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private LayerMask Wall;
    private Rigidbody2D rb;
    [SerializeField] private Collider2D triggerCollider;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
    private void FixedUpdate()
    {
        if (!triggerCollider.IsTouchingLayers(jumpableGround) || triggerCollider.IsTouchingLayers(Wall))
        {
            Flip();
        }
    }

    private void Flip()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        moveSpeed *= -1;
    }
}
