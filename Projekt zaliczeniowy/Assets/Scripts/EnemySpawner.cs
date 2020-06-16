using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2;
    private float timer = 0;


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1 / spawnRate)
        {
            timer = 0;
            Instantiate(enemy, transform.position + transform.right * Random.Range(-6, 6), Quaternion.identity);
        }
    }
}

