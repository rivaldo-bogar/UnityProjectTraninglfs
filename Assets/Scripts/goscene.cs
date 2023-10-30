using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Fungsi ini akan dipanggil saat tombol tertentu ditekan atau kondisi lain terpenuhi
    public void Goplayscene(string sceneName)
    {
        SceneManager.LoadScene("gameplay");
    }
    public void QuitGame()
    {
        // Keluar dari permainan
        Application.Quit();
    }
    public void TutorialScene()
    {
        SceneManager.LoadScene("tutorial");
    }


}
