using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform targetPoint;

    public float maxX;
    public float minX;
    public float y;

    public float spawnInterval = 2f;
    public float force = 7f;

    public float timeToDestroy = 5f;

    public bool canSpawn;
    private void Start()
    {
        canSpawn = true;
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (canSpawn)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(minX, maxX), y, 0f);

            GameObject enemyObject = Instantiate(enemyPrefab, randomSpawnPos, Quaternion.identity);

            Vector2 moveDirection = (targetPoint.position - enemyObject.transform.position).normalized;
            enemyObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveDirection.x * force, moveDirection.y);
        
            Destroy(enemyObject, timeToDestroy);
        
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

