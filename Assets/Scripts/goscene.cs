using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject levelcanva;
    // Fungsi ini akan dipanggil saat tombol tertentu ditekan atau kondisi lain terpenuhi
    public void GoSelectLevel(string sceneName)
    {
        levelcanva.SetActive(true);
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
    public void PopSelectLevel()
    {
        levelcanva.SetActive(false);
    }


}
