using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private GameObject focusPoint;
    private float speedPlayer = 15.0f;
    private Rigidbody playerRB;
    public bool hasPowerUp;
    private float powerUpStrenght = 10.0f;
    public GameObject powerupIndicator;
    void Start() {
        playerRB = GetComponent<Rigidbody>();
        focusPoint = GameObject.Find("Focal Point");
    }

    void Update() {
        float verticalInput = Input.GetAxis("Vertical");
        playerRB.AddForce(speedPlayer * verticalInput * focusPoint.transform.forward);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Powerup")) {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Enemy") && hasPowerUp) {
            Rigidbody enemyRB = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.transform.position - transform.position;
            enemyRB.AddForce(awayFromPlayer * powerUpStrenght, ForceMode.Impulse);
        }
    }

    IEnumerator PowerupCountdownRoutine () {
        yield return new WaitForSeconds(5);
        hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}
