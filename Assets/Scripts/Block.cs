using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Block :MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            BlockManager.Instance.RemoveBlock(this);
            Destroy(gameObject);
        }
    }
}
