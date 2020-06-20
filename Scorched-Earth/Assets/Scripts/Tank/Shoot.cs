using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    GameObject turret;

    // Start is called before the first frame update
    void Start()
    {
        InitializeTurret();
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = transform.position;
            GameObject go = Instantiate(projectile, spawnPos, transform.rotation);
            float xVelocity = go.GetComponent<ProjectileMotion>().GetXVelocity();
            xVelocity = xVelocity * (float)Math.Cos(turret.transform.rotation.z);
            go.GetComponent<ProjectileMotion>().SetXVelocity(xVelocity);
            float yVelocity = go.GetComponent<ProjectileMotion>().GetYVelocity();
            yVelocity = yVelocity * (float)Math.Sin(turret.transform.rotation.z);
            go.GetComponent<ProjectileMotion>().SetYVelocity(yVelocity);


        }
    }


    void InitializeTurret()
    {
        foreach (Transform tr in transform)
        {
            if (tr.name == "Turret")
            {
                turret = tr.gameObject;
            }
        }
    }
}
