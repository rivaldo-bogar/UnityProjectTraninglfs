using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptlevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level1(string namescene)
    {
        SceneManager.LoadScene("gameplay");
    }
    public void level2(string namescene)
    {
        SceneManager.LoadScene("gameplay2");
    }
}
