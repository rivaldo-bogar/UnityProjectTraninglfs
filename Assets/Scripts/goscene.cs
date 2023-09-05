using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Fungsi ini akan dipanggil saat tombol tertentu ditekan atau kondisi lain terpenuhi
    public void SwitchToScene(string sceneName)
    {
        SceneManager.LoadScene("scene2");
    }
    public void QuitGame()
    {
        // Keluar dari permainan
        Application.Quit();
    }

}
