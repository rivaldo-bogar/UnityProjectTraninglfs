using UnityEngine;

public class iconsettingrotate : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Kecepatan rotasi objek

    void Update()
    {
        // Mendapatkan komponen Transform dari objek
        Transform transform = GetComponent<Transform>();

        // Mengatur rotasi objek di sekitar sumbu Y
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
