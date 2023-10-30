using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingpopup : MonoBehaviour
{
    public GameObject SettingShow;
    // Start is called before the first frame update
    void Start()
    {
        SettingShow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void btn_setting()
    {
        SettingShow.SetActive(true);
    }
    public void closepop()
    {
        SettingShow.SetActive(false);
    }
}
