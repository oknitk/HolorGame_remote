using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    private Animator animator;
    SpriteRenderer spriteRenderer;

    void Start()
    {

        //characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {


    }
    void FixedUpdate()
    {
        int horizontalKey = (int)Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(speed * horizontalKey, rb.velocity.y);

        animator.SetBool("walk", horizontalKey != 0);
        if (horizontalKey != 0)//“ü—Í‚ª‚ ‚Á‚½Žž‚¾‚¯Œü‚«‚ð•Ï‚¦‚é
        {
            spriteRenderer.flipX = (horizontalKey < 0);
        }

    }

}
