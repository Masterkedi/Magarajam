using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformD3 : MonoBehaviour
{
    public float rotationAmount = 90f; // The amount to rotate when the key is pressed
    public float rotationDuration = 1f; // The duration of the rotation in seconds

    private bool is31, is32;



    private bool isRotating = false;



    // Start is called before the first frame update
    void Start()
    {
        is31 = true;
        is32 = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A) && !isRotating && CanR3.canRot3 && is31)
        {
            is31 = false;
            is32 = true;
            StartCoroutine(RotateObjectCoroutine2());
         

        }
        if (Input.GetKey(KeyCode.D) && !isRotating && CanR3.canRot3 && is32)
        {
            is31 = true;
            is32 = false;
            StartCoroutine(RotateObjectCoroutine());
            

        }

    }

    IEnumerator RotateObjectCoroutine()
    {
        isRotating = true;

        float elapsedRotationTime = 0f;
        Quaternion initialRotation = transform.rotation;
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(0, 0, rotationAmount);

        while (elapsedRotationTime < rotationDuration)
        {
            transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, elapsedRotationTime / rotationDuration);
            elapsedRotationTime += Time.deltaTime;
            yield return null;
        }

        transform.rotation = targetRotation;
        isRotating = false;


    }

    IEnumerator RotateObjectCoroutine2()
    {
        isRotating = true;

        float elapsedRotationTime = 0f;
        Quaternion initialRotation = transform.rotation;
        Quaternion targetRotation = transform.rotation * Quaternion.Euler(0, 0, -rotationAmount);

        while (elapsedRotationTime < rotationDuration)
        {
            transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, elapsedRotationTime / rotationDuration);
            elapsedRotationTime += Time.deltaTime;
            yield return null;
        }

        transform.rotation = targetRotation;
        isRotating = false;
    }
}
