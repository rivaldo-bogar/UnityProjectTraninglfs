using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closemission : MonoBehaviour
{
    public GameObject canvaMission;
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
