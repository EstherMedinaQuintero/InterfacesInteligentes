/**
  Este script detecta cuando el cubo o la esfera colisionan con el objeto 
  Muestra un mensaje en consola con la etiqueta del objeto que haya colisionado
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej11Colision: MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Colisión con: " + other.tag);
    }
}
