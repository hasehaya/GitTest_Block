using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Ball :MonoBehaviour
{
    float speed = 2f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(speed, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
