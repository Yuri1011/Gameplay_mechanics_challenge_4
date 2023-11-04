using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject spawnEnemyPrefab;
    private float spawnRange = 9.0f;
    void Start() {
        SpawnEnemyWave();
    }

    private Vector3 GenerateRandomSpawnPosition() {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    void SpawnEnemyWave() {
        for (int i = 0; i < 3; i++) {
            Instantiate(spawnEnemyPrefab, GenerateRandomSpawnPosition(), spawnEnemyPrefab.transform.rotation);
        }
    }
    void Update() {
        
    }
}
