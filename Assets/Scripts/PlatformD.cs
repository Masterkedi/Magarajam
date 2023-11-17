using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformD : MonoBehaviour
{
 
    public float rotationAmount = 90f; // The amount to rotate when the key is pressed
    public float rotationDuration = 1f; // The duration of the rotation in seconds

    private bool is1, is2;
        
    private bool isRotating = false;



    // Start is called before the first frame update
    void Start()
    {
        is1= true;
        is2= true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.A) && !isRotating&& CanR.canRot&&is1)
        {


            is1 = false;
            is2 = true;
            
            StartCoroutine(RotateObjectCoroutine());

         
        }
        if (Input.GetKey(KeyCode.D) && !isRotating && CanR.canRot&&is2)
        {
            is1= true;
            is2 = false;
            
            StartCoroutine(RotateObjectCoroutine2());
           
            
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
