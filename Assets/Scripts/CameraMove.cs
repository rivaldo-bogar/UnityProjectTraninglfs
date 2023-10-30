using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 5.0f; // Kecepatan gerakan kamera
    public float minX = -5.0f; // Batas kiri
    public float maxX = 5.0f;  // Batas kanan

    private bool moveRight = true;
    
    void Update()
    {
        // Mendapatkan posisi saat ini
        Vector3 currentPosition = transform.position;

        // Mengecek arah pergerakan dan memindahkan kamera
        if (moveRight)
        {
            currentPosition.x += speed * Time.deltaTime;
            if (currentPosition.x >= maxX)
            {
                moveRight = false;
            }
        }
        else
        {
            currentPosition.x -= speed * Time.deltaTime;
            if (currentPosition.x <= minX)
            {
                moveRight = true;
            }
        }

        // Memperbarui posisi kamera
        transform.position = currentPosition;
    }
}
