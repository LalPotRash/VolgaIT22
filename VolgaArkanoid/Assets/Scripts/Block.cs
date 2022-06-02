using UnityEngine;

public class Block : MonoBehaviour
{
    private static int _count = 0;

    void OnEnable()
    {
        ++_count;
    }

    void OnDestroy()
    {
        --_count;

        if (_count <= 0)
        {
            try
            {
                GameObject.Find("Canvas").transform.GetChild(1).gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            catch { }
        }
    }
}
