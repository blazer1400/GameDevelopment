using UnityEngine;
using System.Collections;
using System;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // Reference to the enemy prefab


    private void Start()
    {
        // Start spawning enemies
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // Instantiate a new enemy at the spawner's position and rotation
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(new RandomNumberGenerator((int)DateTime.Now.Ticks).Next(1, 4));
        }
    }
}

class RandomNumberGenerator
{
    private int seed;
    
    public RandomNumberGenerator(int seed)
    {
        this.seed = seed;
    }
    
    public int Next(int minValue, int maxValue)
    {
        // Ensure that the minValue is less than maxValue
        if (minValue >= maxValue)
        {
            throw new ArgumentException("minValue must be less than maxValue");
        }
        
        // Generate a random number using a simple algorithm
        seed = (seed * 1103515245 + 12345) & 0x7fffffff;
        
        // Scale the generated number to the desired range
        int range = maxValue - minValue + 1;
        int scaledNumber = (seed % range) + minValue;
        
        return scaledNumber;
    }
}