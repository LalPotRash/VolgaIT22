using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Time.timeScale = 0;
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
    }
}
