using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showandhidesetting : MonoBehaviour
{
    public GameObject objectToToggle; // Game object yang ingin ditampilkan atau disembunyikan
  

    private bool isObjectVisible = false; // Status apakah objek sedang terlihat atau tidak

    void Start()
    {
        // Pastikan objek awalnya terlihat
        objectToToggle.SetActive(isObjectVisible);
    }

    void Update()
    {
      
    }
    public void ShowCanvaSetting()
    {
        isObjectVisible = !isObjectVisible;
        objectToToggle.SetActive(isObjectVisible);
    }
    public void BtnCloseHide()
    {
        isObjectVisible = !isObjectVisible;
        objectToToggle.SetActive(isObjectVisible);
    }
}
