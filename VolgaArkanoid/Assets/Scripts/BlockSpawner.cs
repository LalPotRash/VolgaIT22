using UnityEngine;
using System.Collections.Generic;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _blocks;

    void Start()
    {
        for (int i = 0; i < transform.childCount; ++i)
        {
            var gameobj = Instantiate(_blocks[Random.Range(0, 3)]);
            gameobj.transform.position = transform.GetChild(i).transform.position;
        }
    }
}
