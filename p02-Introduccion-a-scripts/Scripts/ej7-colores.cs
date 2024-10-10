/**
  Este script detecta si se ha pulsado el la C, y le cambia el color al Cilindro en tal caso.
  También detecta si se ha pulsado la flecha arriba, y le cambia el color al cubo.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7Colores: MonoBehaviour {
    /// Objetos que van a cambiar de color
    GameObject _cubo;
    GameObject _cilindro;
    // Start is called before the first frame update
    void Start() {
        /// Buscamos los objetos por su etiqueta "Cubo" y "Cilindro"
        _cubo = GameObject.FindWithTag("Cubo");
        _cilindro = GameObject.FindWithTag("Cilindro");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            /// Cambiamos el color del cilindro a un color aleatorio
            _cilindro.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            /// Cambiamos el color del cubo a un color aleatorio
            _cubo.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
