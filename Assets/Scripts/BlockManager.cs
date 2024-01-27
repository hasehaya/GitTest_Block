using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BlockManager :MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;

    float width = 0.85f;
    float height = 0.35f;

    int rows = 4; // óÒ
    int columns = 7; // çs

    List<Block> blocks = new List<Block>();
    void Start()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                GameObject block = Instantiate(blockPrefab, Vector3.zero, Quaternion.identity);
                block.transform.parent = transform;
                block.transform.localPosition = new Vector3(width * i, height * j, 0);
                blocks.Add(block.GetComponent<Block>());
            }
        }
    }

    void Update()
    {

    }
}
