/**
  Este script hace que el cubo se mueva hacia la posición de la esfera girando hacia ella
  Los objetos tienen un tag que indica si es Cubo o Esfera
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej7Girando: MonoBehaviour {
    [SerializeField] private float speed = 3.0f;
    GameObject esfera;
    // Start is called before the first frame update
    void Start() {
        /// Obtenemos la posición de la esfera
        esfera = GameObject.FindGameObjectWithTag("Esfera");
    }

    // Update is called once per frame
    void Update() {
        /// Movemos el cubo hacia la posición de la esfera
        Vector3 direccion = esfera.transform.position - transform.position;
        transform.Translate(direccion.normalized * speed * Time.deltaTime, Space.World);
        /// Giramos el cubo hacia la esfera
        transform.LookAt(esfera.transform);
    }
}
