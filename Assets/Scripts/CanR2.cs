using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanR2 : MonoBehaviour
{
    public static bool canRot2;
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
            canRot2 = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canRot2 = false;
        }
    }
}
