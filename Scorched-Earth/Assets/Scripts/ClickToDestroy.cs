using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClickToDestroy : MonoBehaviour
{

    [SerializeField] Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse clicked!");
            Vector3 mousePos3d = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos = new Vector2(mousePos3d.x, mousePos3d.y);

            RaycastHit2D hitInfo = Physics2D.Raycast(mousePos, Vector2.zero);
            if(hitInfo.collider != null)
            {
                Debug.Log(hitInfo.collider.name);
                Collider2D[] hitObjects = Physics2D.OverlapCircleAll(hitInfo.point, 1.5f);
                foreach(Collider2D obj in hitObjects)
                {
                    Destroy(obj.gameObject);
                }
                
            }
        }
    }

    
}
