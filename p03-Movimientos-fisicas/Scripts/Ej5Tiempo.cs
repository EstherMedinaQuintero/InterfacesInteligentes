/**
  Este script detecta si el objeto que lo contiene es un cubo o una esfera
  Si es un cubo, se mueve con las flechas arriba-abajo (eje vertical) e izquierda-derecha (eje horizontal) a una velocidad speed
  Si es una esfera, se mueve con las teclas W-S y A-D a una velocidad speed
  Los objetos tienen un tag que indica si son cubos o esferas
  Además, este movimiento es proporcional al tiempo transcurrido durante la generación del frame
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4Tiempo: MonoBehaviour {
    [SerializeField] private float speed = 3.0f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (gameObject.CompareTag("Cubo")) {
            if (Input.GetKey(KeyCode.UpArrow)) {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            } else if (Input.GetKey(KeyCode.DownArrow)) {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            } else if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            } else if (Input.GetKey(KeyCode.RightArrow)) {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

        if (gameObject.CompareTag("Esfera")) {
            if (Input.GetKey(KeyCode.W)) {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            } else if (Input.GetKey(KeyCode.S)) {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            } else if (Input.GetKey(KeyCode.A)) {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            } else if (Input.GetKey(KeyCode.D)) {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    }
}
