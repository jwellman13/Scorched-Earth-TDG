using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkerController : MonoBehaviour
{
    float fallSpeed = 2f;
    bool hasLanded = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(fallSpeed > 0)
        {
            Fall();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with" + collision.name);
        if (collision.GetComponent<Tile>())
        {
            fallSpeed = 0;
            if(!hasLanded)
            {
                DestroyLandingCrate();
            }
        }
    }

    void Fall()
    {
        Vector3 bunkerPos = transform.position;
        bunkerPos.y = bunkerPos.y - (Time.deltaTime * fallSpeed);
        this.transform.position = bunkerPos;
    }

    void DestroyLandingCrate()
    {
        foreach (Transform tr in transform)
        {
            if (tr.name == "Landing Crate")
            {
                Destroy(tr.gameObject);
                hasLanded = true;
            }
        }
    }
}
