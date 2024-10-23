/**
  Este script mueve con WASD el objeto que lo contiene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisicas: MonoBehaviour {   
    public float speed = 20f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {

    }

    /// Método que mueve el objeto con físicas
    void MoveWithPhysics(Vector3 moveVelocity) {
        rb.velocity = moveVelocity;
    }

    void FixedUpdate() {
        /// Movemos con las teclas 
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveVelocity = moveInput * speed;
        MoveWithPhysics(moveVelocity); 
    }
}