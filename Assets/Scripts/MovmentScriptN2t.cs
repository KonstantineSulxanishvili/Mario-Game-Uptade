using System.Collections;
using System.Collections.Generic;
using UnityEngine;
            
public class MovmentScriptN2t : MonoBehaviour
{
    float moveInput;
    public Rigidbody2D rb;
    public float speed;
    public Transform pos;
    public float radius;
    public LayerMask groundLayers;
    public float jumpForce;
    public float heightCutter;
    public bool grounded;
    void Awake()
    { 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity=new Vector2(moveInput * speed, rb.velocity.y);
    }
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        grounded = Physics2D.OverlapCircle(pos.position, radius, groundLayers);

        if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {  
            if(rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * heightCutter);
            }
        }
    }
}
