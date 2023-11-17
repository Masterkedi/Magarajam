using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanR : MonoBehaviour
{
    public static bool canRot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canRot = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canRot = false;
        }
    }
}
