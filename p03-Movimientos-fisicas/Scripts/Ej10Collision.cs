/**
  Este script detecta cuando el cubo o la esfera colisionan con el objeto 
  Muestra un mensaje en consola con la etiqueta del objeto que haya colisionado
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej10Collision: MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    /// Método que se ejecuta cuando el objeto colisiona con otro objeto
    void OnCollisionEnter(Collision other) {
        Debug.Log("Colisión con: " + other.gameObject.tag);
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Colisión con: " + other.tag);
    }
}
