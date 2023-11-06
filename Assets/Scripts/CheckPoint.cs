using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public MonoBehaviour scriptToActivate;

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Character mengenai checkpoint");

        // Periksa apakah objek ini bersentuhan dengan objek lain
        if (other.gameObject.CompareTag("Player"))
        {
            // Aktifkan skrip saat bersentuhan
            scriptToActivate.enabled = true;
        }

    }

}
