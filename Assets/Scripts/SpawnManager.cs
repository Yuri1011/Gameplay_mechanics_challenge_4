using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject spawnEnemyPrefab;
    void Start() {
        Instantiate(spawnEnemyPrefab, new Vector3(0, 0, 6), spawnEnemyPrefab.transform.rotation);
    }

    void Update() {
        
    }
}
