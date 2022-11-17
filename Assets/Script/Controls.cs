using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float speed;
    public float jump;
    private float Move;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if (Move >= 0.1f)
        {
            animator.SetBool("Look Left", true);
        }
        else
        {
            animator.SetBool("Look Left", false);
        }

        if (Move <= -0.1f)
        {
            animator.SetBool("Look Right", true);
        }
        else
        {
            animator.SetBool("Look Right", false);
        }
    }
}