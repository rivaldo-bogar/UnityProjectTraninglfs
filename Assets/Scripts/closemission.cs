using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closemission : MonoBehaviour
{

    public GameObject canvaMission;
    void Start()
    {
        canvaMission.SetActive(true);
    }
    // Start is called before the first frame update
    public void hideCanvaMission()
    {
        canvaMission.SetActive(false);
    }
    public void showCanvaMission()
    {
        canvaMission.SetActive(true);
    }
}
