using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanR3 : MonoBehaviour
{
    public static bool canRot3;
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
            canRot3 = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canRot3 = false;
        }
    }
}
