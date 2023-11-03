using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {
    private float speedRotate = 70.0f;

    void Start() {
    }

    void Update() {
        float horizontalInput = -Input.GetAxis("Horizontal");
        transform.Rotate(speedRotate * horizontalInput * Time.deltaTime * Vector3.up);
    }
}
