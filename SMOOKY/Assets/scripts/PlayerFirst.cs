using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFirst : MonoBehaviour
{
    public float speed;
    public float jump;
    private float moveInput;
    public SpriteRenderer sr;

    private Rigidbody2D rb;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput == 0) 
        {
            animator.SetBool("isright", false);
            animator.SetBool("isleft", false);
        }
        else if(moveInput > 0)
        {
            animator.SetBool("isright", true);
            animator.SetBool("isleft", false);
        }

        else if (moveInput < 0)
        {
            animator.SetBool("isright", false);
            animator.SetBool("isleft", true);
        }

    }

}
