using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDetectRotation : MonoBehaviour
{
    public GameObject wall;
    public float maxRotation = 90.0f; // Maksimum rotasi yang diizinkan
    private bool isRotating = false; // Untuk melacak apakah objek sedang berputar

    void OnCollisionEnter(Collision collision)
    {
        if (!isRotating)
        {
            isRotating = true;
            StartCoroutine(RotateObject());
        }
    }

    IEnumerator RotateObject()
    {
        float currentRotation = 0.0f;

        while (currentRotation < maxRotation)
        {
            // Rotasi objek pada sumbu yang diinginkan (misalnya, Y)
            wall.transform.Rotate(Vector3.forward * Time.deltaTime);
            currentRotation += Time.deltaTime;

            yield return null;
        }

        isRotating = false;
    }
}
