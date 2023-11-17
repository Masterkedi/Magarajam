using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float speed = 5f;
    public static Vector2 targetGravity=Vector2.down*10;
    public static Vector2 gravity=Vector2.down*10;
    
   
    // Update is called once per frame
    void Update()
    {
        gravity=Vector2.MoveTowards(gravity, targetGravity, Time.deltaTime * speed);
        Physics2D.gravity=gravity;
    }
}
