using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{
    float xVelocity = 20;
    float yVelocity = 20;
    float timeAlive = 0f;
    float gravity = -9.8f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = KinematicVelocity();
        timeAlive++;
    }

    Vector2 KinematicVelocity()
    {

        yVelocity = yVelocity + (gravity * (float)Math.Pow(timeAlive * Time.deltaTime, 2));
        return new Vector2(xVelocity, yVelocity);
    }

    public float GetXVelocity()
    {
        return xVelocity;
    }

    public float GetYVelocity()
    {
        return yVelocity;
    }

    public void SetXVelocity(float value)
    {
        xVelocity = value;
    }

    public void SetYVelocity(float value)
    {
        yVelocity = value;
    }

}
