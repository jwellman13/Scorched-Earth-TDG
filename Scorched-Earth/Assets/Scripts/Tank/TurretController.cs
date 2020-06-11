using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    GameObject turret;
    // Start is called before the first frame update
    void Start()
    {
        InitializeTurret();
    }

    // Update is called once per frame
    void Update()
    {
        AimTurret();
    }

    void InitializeTurret()
    {
        foreach (Transform tr in transform)
        {
            if(tr.name == "Turret")
            {
                turret = tr.gameObject;
            }
        }
    }

    void AimTurret()
    {
        if(Input.GetKeyDown(KeyCode.A) && turret.transform.rotation.z < 180)
        {
            turret.transform.Rotate(new Vector3(0, 0, 5f));
        }
        else if (Input.GetKeyDown(KeyCode.D) && turret.transform.rotation.z > 0)
        {
            turret.transform.Rotate(new Vector3(0, 0, -5f));
        }
    }
}
