using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent(out Block block))
        {
            Destroy(col.gameObject);
        }
    }
}
