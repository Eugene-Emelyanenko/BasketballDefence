using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private EnemySpawner enemySpawner;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.attachedRigidbody != null && other.attachedRigidbody.velocity.y < 0 && other.CompareTag("Enemy"))
        {
            enemySpawner.canSpawn = false;
            gameOverScreen.SetActive(true);
        }
    }
}
