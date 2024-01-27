using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Paddle :MonoBehaviour
{
    BoxCollider boxCollider;
    float width;
    float mousePositionX;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        width = boxCollider.size.x;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePositionX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            if (IsTouchingWall())
            {
                return;
            }
            transform.position = new Vector3(mousePositionX, transform.position.y, transform.position.z);
        }
    }

    bool IsTouchingLeft()
    {
        return mousePositionX - width / 2 <= -2;
    }

    bool IsTouchingRight()
    {
        return mousePositionX + width / 2 >= 2;
    }

    bool IsTouchingWall()
    {
        return IsTouchingLeft() || IsTouchingRight();
    }
}
