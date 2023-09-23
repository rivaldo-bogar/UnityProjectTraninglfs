using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    private Vector3 CameraPosition = new Vector3 (-17.0f, 36.1f, -30.0f);
    public GameObject player;
    private void LateUpdate()
    {
        transform.position = player.transform.position + CameraPosition;
    }
}
