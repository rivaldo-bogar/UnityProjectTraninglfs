using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falseDrag : MonoBehaviour
{
    private Vector3 initialPosition;
    private bool isDragging = false;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (isDragging)
        {
            // Mengikuti posisi mouse atau sentuh layar
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(newPosition.x, newPosition.y, initialPosition.z);
        }

        if (Input.GetMouseButtonDown(0))
        {
            // Memulai drag jika klik kiri
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hitCollider = Physics2D.OverlapPoint(touchPosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                isDragging = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            // Menghentikan drag jika melepaskan klik kiri
            if (isDragging)
            {
                isDragging = false;

                // Cek apakah objek berada di tempat yang salah
                if (!IsInCorrectPosition())
                {
                    // Kembalikan objek ke posisi awalnya
                    transform.position = initialPosition;
                }
            }
        }
    }

    // Anda perlu mengimplementasikan metode ini sesuai dengan kebutuhan Anda
    private bool IsInCorrectPosition()
    {
        float minX = -830.0f;
        float maxX = 833.0f;
        float minY = -495.0f ;
        float maxY = -323.0f;

        Vector3 currentPosition = transform.position;

        if (currentPosition.x < minX || currentPosition.x > maxX || currentPosition.y < minY || currentPosition.y > maxY)
        {
            Debug.Log("valdo developer test dibugging");
            // Objek berada di luar area yang benar
            return true;
        }
        // Implementasikan logika untuk memeriksa apakah objek berada di tempat yang benar
        // Misalnya, Anda dapat memeriksa jarak antara objek dan posisi target
        // Jika objek berada dalam jarak tertentu dari posisi target, Anda dapat mengembalikan true
        // Jika tidak, Anda dapat mengembalikan false


        return false;
    }
}
