using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDetectRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // Kecepatan rotasi (dalam derajat per detik)
    public float targetRotation = -257f; // Rotasi yang diinginkan sebelum berhenti
    private bool isRotating = true;

    void Update()
    {
        if (isRotating)
        {
            // Rotasi objek secara terus menerus
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

            // Periksa apakah objek telah mencapai rotasi yang diinginkan
            if (transform.rotation.eulerAngles.y >= targetRotation)
            {
                // Objek telah mencapai rotasi yang diinginkan, berhenti berputar
                isRotating = false;
            }
        }
    }
}
