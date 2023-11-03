using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private GameObject focusPoint;
    private float speedPlayer = 15.0f;
    private Rigidbody playerRB;
    void Start() {
        playerRB = GetComponent<Rigidbody>();
        focusPoint = GameObject.Find("Focal Point");
    }

    void Update() {
        float verticalInput = Input.GetAxis("Vertical");
        playerRB.AddForce(speedPlayer * verticalInput * focusPoint.transform.forward);
    }
}
