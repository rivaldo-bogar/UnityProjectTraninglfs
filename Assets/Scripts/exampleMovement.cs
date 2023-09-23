using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exampleMovement : MonoBehaviour
{
    public Transform defaultposition;
    public float speed = 5.0f;
    private Vector3 resetPosition;
    // Start is called before the first frame update
    void Start()
    {
        resetPosition = defaultposition.position; 
    }

    // Update is called once per frame
    void Update()
    {
        // Bergerak ke depan (maju) berdasarkan sumbu Z
        Vector3 movement = transform.forward * speed * Time.deltaTime;
        transform.Translate(movement);
        if (transform.position.z >= 65.0f)
        {
            Debug.Log("Player mencapai titik.");
           transform.position = resetPosition;       // Dicomment karena ada test dibugging
         ;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
          
        }
    }
}
