using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagement : MonoBehaviour
{
    public GameObject[] tilePrefabs;
     float zSpawn = 310f;
    public float tileLength = 400f;
    public int num_of_tiles = 2;



    public Transform playerTransform;
    public void spawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }



    /// ///////////////////////////////////////////////////////////////////////////////////////


    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < num_of_tiles; i++)
        //{

        //    spawnTile(Random.Range(0, tilePrefabs.Length));
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z > zSpawn - (num_of_tiles * tileLength))
        {
            spawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    
}
