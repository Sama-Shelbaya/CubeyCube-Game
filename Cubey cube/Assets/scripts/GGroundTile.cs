///using System.Collections;
///using System.Collections.Generic;
using UnityEngine;

public class GGroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle ()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
