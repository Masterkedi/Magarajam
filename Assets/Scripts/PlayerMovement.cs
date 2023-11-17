using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    public static bool isMoving=false;

    private float horizontal;
    public float speed = 5f;
    private bool isFacingRight = true;

    private Rigidbody2D rb;

    

    private void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Flip();
        
    }
    private void FixedUpdate()
    {
       
        Vector2 x = Vector2.Perpendicular(Gravity.gravity);
        var y=horizontal* x*speed;
        var b=Vector2.Dot(rb.velocity,y);
        if (b<1)
        {
            rb.AddForce((y));
        }
       
       
        
    }
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }
}
