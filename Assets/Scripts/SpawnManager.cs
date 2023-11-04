using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject spawnEnemyPrefab;
    private float spawnRange = 9.0f;
    private int enemyCount;
    private int waveNumber = 1;
    void Start() {
        SpawnEnemyWave(waveNumber);
    }

    private Vector3 GenerateRandomSpawnPosition() {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn) {
        for (int i = 0; i < enemiesToSpawn; i++) {
            Instantiate(spawnEnemyPrefab, GenerateRandomSpawnPosition(), spawnEnemyPrefab.transform.rotation);
        }
    }
    void Update() {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0) {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }
}
