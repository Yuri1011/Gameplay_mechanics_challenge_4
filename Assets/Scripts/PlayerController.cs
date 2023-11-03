using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float speedPlayer = 15.0f;
    private Rigidbody playerRB;
    void Start() {
        playerRB = GetComponent<Rigidbody>();
    }

    void Update() {
        float verticalInput = Input.GetAxis("Vertical");
        playerRB.AddForce(speedPlayer * verticalInput * Vector3.forward);
    }
}
