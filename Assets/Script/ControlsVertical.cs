using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsVertical : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
