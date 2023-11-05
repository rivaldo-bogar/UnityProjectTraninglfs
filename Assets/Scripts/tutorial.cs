using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tutorial : MonoBehaviour
{
    public GameObject[] ImgTutorial;
    // Start is called before the first frame update
    void Start()
    {
        ImgTutorial[0].SetActive(true);
    }
    public void dragblock()
    {
        ImgTutorial[1].SetActive(true);
        ImgTutorial[0].SetActive(false);

    }
    public void showblock()
    {
        ImgTutorial[0].SetActive(true);
        ImgTutorial[1].SetActive(false);
    }
}
