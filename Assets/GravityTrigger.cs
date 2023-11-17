using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTrigger : MonoBehaviour
{
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Gravity.targetGravity = -transform.up;
    }
}
