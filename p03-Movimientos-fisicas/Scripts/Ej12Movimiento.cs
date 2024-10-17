/**
  Este script le otorga movimiento a un cilindro de tipo físico
  Además, sigue a un objeto con un tag específico (esfera)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej12Movimiento: MonoBehaviour {
    [SerializeField] private float moveSpeed = 30.0f;
    [SerializeField] private float followSpeed = 5.0f;
    private GameObject esfera;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start() {
        /// Obtenemos nuestro Rigidbody
        rb = GetComponent<Rigidbody>();
        esfera = GameObject.FindWithTag("Esfera");
    }

    // Update is called once per frame
    void Update() {
    }

    /// Método que mueve el cilindro con físicas
    void MoveWithPhysics(Vector3 moveVelocity) {
        rb.velocity = moveVelocity;
    }

    /// Método que sigue a la esfera
    void MoveTowardsSphere() {
        /// Dirección hacia la esfera
        Vector3 directionToSphere = (esfera.transform.position - transform.position).normalized;
        /// Evitar rotar sobre el eje Y
        Vector3 lookAtGoal = new Vector3(esfera.transform.position.x, transform.position.y, esfera.transform.position.z);
        Quaternion targetRotation = Quaternion.LookRotation(directionToSphere);
        /// Rotación gradual con Slerp para que mire hacia la esfera
        rb.MoveRotation(Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * followSpeed));
        /// Aplicamos fuerza hacia la dirección de la esfera (una vez rotado)
        rb.AddForce(directionToSphere * moveSpeed);
    }

    void FixedUpdate() {
        /// Movemos el cilindro con las teclas 
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveVelocity = moveInput * moveSpeed;
        MoveWithPhysics(moveVelocity); 
        /// Movemos el cilindro hacia la posición de la esfera
        MoveTowardsSphere();
    }
           
}
