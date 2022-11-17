using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsWagon : MonoBehaviour
{
    public float speed;
    public float jump;
    private float Move;
    public Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
}