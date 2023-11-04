using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialback : MonoBehaviour
{
    public void BackMainMenu(string scenename)
    {
        SceneManager.LoadScene("mainmenu");
    }

}
