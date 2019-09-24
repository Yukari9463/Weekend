﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private bool isJumping;
    private Rigidbody rb;
    private float speed;

    virtual public void Start()
    {
        isJumping = false;
        rb = GetComponent<Rigidbody>();
        speed = 10;
    }

    protected void move(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    protected void jump(Vector3 direction)
    {
        if (isJumping == false)
        {
            isJumping = true;
            rb.AddForce(0, 20000, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}
