using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunker : MonoBehaviour
{
    float turretAngle;
    GameObject turret;

    private void Start()
    {
        InitializeTurret();
    }

    public float GetTurretAngle()
    {
        foreach (Transform tr in transform)
        {
            if (tr.name == "Turret")
            {
                turret = tr.gameObject;
            }
        }

        return turret.transform.rotation.z;
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
