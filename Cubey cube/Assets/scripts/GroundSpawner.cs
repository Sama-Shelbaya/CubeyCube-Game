///using System.Collections;
///using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject GroundTile;
           Vector3 NextSpawnPoint;


    public void SpawnTile()
    {
        GameObject temp = Instantiate(GroundTile, NextSpawnPoint, Quaternion.identity);
        NextSpawnPoint = temp.transform.GetChild(1).transform.position;
    } 




    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnTile();
        }
       

    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
