using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StarnBtn()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene("Menu");
    }
}
