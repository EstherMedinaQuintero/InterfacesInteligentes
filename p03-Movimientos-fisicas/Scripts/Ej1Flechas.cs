/**
  Este script añade un campo velocidad al objeto.
  Este campo se puede modificar desde el inspector.
  Se muestra en consola el resultado de multipliciar la velocidad por el valor del eje vertical y por el valor del eje horizontal
  cada vez que se pulsan las teclas flecha arriba-abajo o izquierda-derecha.
  El nombre comienza por la flecha pulsada.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1Flechas: MonoBehaviour {
    [SerializeField] private float velocidad = 5.0f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("UpArrow: " + velocidad * Input.GetAxis("Vertical"));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("DownArrow: " + velocidad * Input.GetAxis("Vertical"));
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("LeftArrow: " + velocidad * Input.GetAxis("Horizontal"));
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("RightArrow: " + velocidad * Input.GetAxis("Horizontal"));
        } 
    }
}
