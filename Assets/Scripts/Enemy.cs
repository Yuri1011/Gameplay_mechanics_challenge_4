using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private float speedEnemy = 15.0f;
    private Rigidbody enemyRB;
    private GameObject player;
    void Start() {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update() {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(speedEnemy * lookDirection);

        if(transform.position.y < -10) {
            Destroy(gameObject);
        }
    }
}
