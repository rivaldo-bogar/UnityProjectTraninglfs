using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player; // Rujukan ke Transform pemain
    public Vector3 offset; // Jarak relatif kamera dari pemain

    // Anda bisa menyesuaikan nilai-nilai berikut untuk mengendalikan perilaku kamera
    public float smoothSpeed = 5.0f; // Faktor perataan untuk pergerakan kamera

    private void LateUpdate()
    {
        if (player == null)
        {
            // Pastikan rujukan pemain tidak null
            Debug.LogError("Rujukan pemain null. Berikan GameObject pemain.");
            return;
        }

        // Hitung posisi yang diinginkan untuk kamera
        Vector3 posisiDiinginkan = player.position + offset;

        // Menggunakan Mathf.SmoothDamp untuk membuat pergerakan kamera menjadi lebih halus
        Vector3 posisiHalus = Vector3.Lerp(transform.position, posisiDiinginkan, smoothSpeed * Time.deltaTime);
        transform.position = posisiHalus;
    }
}