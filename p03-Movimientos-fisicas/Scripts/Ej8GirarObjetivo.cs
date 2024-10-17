/**
  Este script permite mover con las teclas W-S-A-D el objeto que lo contiene
  Sin embargo, usa el eje horizontal para girar el objetivo y que siempre avance hacia delante
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8GirarObjetivo: MonoBehaviour {
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private float rotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start() {
        
    } 

    // Update is called once per frame
    void Update() {
        /// Dibujamos un rayo para ver la dirección hacia la que mira el objeto
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(transform.forward * moveSpeed * Time.deltaTime, Space.World);
        } else if (Input.GetKey(KeyCode.S)) {
            transform.Translate(-transform.forward * moveSpeed * Time.deltaTime, Space.World);
        } else if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(-Vector3.up, rotationSpeed * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }  
    }
}
