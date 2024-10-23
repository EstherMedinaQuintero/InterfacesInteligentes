/**
  Si el cubo colisiona con un huevo de tipo 1, se le suman 5 puntos
  Si el cubo colisiona con un huevo de tipo 2, se le suman 10 puntos
  Cuando choca con un huevo, este debe trasladarse a una posición aleatoria dentro del plano ("Plano")
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5Puntuacion: MonoBehaviour {
    public int puntos = 0;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "HuevoT1") {
            puntos += 5;
            Debug.Log("Puntos: " + puntos);
            /// Movemos dentro del rango -9 y 9
            float x = Random.Range(-9, 9);
            float z = Random.Range(-9, 9);
            float y = other.transform.position.y;
            other.transform.position = new Vector3(x, y, z);
        }
        if (other.tag == "HuevoT2") {
            puntos += 10;
            Debug.Log("Puntos: " + puntos);
            /// Movemos dentro del rango -9 y 9
            float x = Random.Range(-9, 9);
            float z = Random.Range(-9, 9);
            float y = other.transform.position.y;
            other.transform.position = new Vector3(x, y, z);
        }
    }
}
