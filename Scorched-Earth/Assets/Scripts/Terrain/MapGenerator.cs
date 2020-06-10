using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] Tile tile;
    [SerializeField] Tile transitionTile;
    [SerializeField] Tile topTile;
    private int mapWidth = 440;
    private int mapHeight = 150;
    private int maxHeight;

    void Start()
    {
        maxHeight = Random.Range(10, mapHeight);
        GenerateTerrain();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateTerrain()
    {
        for (int i = 0; i < mapWidth; i++)
        {
           
            int columnMaxHeight = maxHeight - Random.Range(-1, 2);
            maxHeight = columnMaxHeight;
            for (int j = 0; j < columnMaxHeight; j++)
            {
                float xOffset = .16f;
                float yOffset = .16f;
                Vector3 spawnPos = new Vector3(transform.position.x + (xOffset * i), transform.position.y + (yOffset * j), transform.position.z);
                if(j == columnMaxHeight -1)
                {
                    GameObject.Instantiate(topTile, spawnPos, transform.rotation, transform);
                }
                else if (j == columnMaxHeight - 2)
                {
                    GameObject.Instantiate(transitionTile, spawnPos, transform.rotation, transform);
                }
                else
                {
                    GameObject.Instantiate(tile, spawnPos, transform.rotation, transform);
                }
            }
            
        }
        
        
    }
}
