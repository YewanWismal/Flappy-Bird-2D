using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 2f;
    public float spawnHeight = 1.5f;
    public Player player;
    private float nextSpawnTime = 0f;

    private void Update()
    {
        if (player.isDead)
        {
            return;
        }
        if(Time.time > nextSpawnTime)
        {
            float yPos = Random.Range(-spawnHeight, spawnHeight);
            Vector3 spawnPos = new Vector3(transform.position.x, yPos, 0);
            Instantiate(prefab, spawnPos, Quaternion.identity);
            nextSpawnTime = Time.time + spawnRate;
        }
    }

}
