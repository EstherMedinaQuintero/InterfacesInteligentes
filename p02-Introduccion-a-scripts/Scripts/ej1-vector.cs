/**
  Este script inicializa un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color).
  Cada 120 frames se cambia el valor de una posición aleatoria y se asigna el nuevo color al objeto.
  La cantidad de frames de espera está parametrizado para poderlo cambiar desde el inspector.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1Vector: MonoBehaviour {
    /// Inicializamos el vector de 3 posiciones con valores entre 0.0 y 1.0
    /// Random.value devuelve un valor entre 0.0 y 1.0
    private Vector3 _color;
    /// Parámetro para cambiar la cantidad de frames de espera
    [SerializeField] private int _frames = 120;
    /// Contador de frames
    private int _framesCounter = 0;
    
    // Start is called before the first frame update
    void Start() {
        /// Inicializamos el vector de 3 posiciones con valores entre 0.0 y 1.0
        _color = new Vector3(Random.value, Random.value, Random.value);
        /// Asignamos el color al objeto
        GetComponent<Renderer>().material.color = new Color(_color.x, _color.y, _color.z);
    }

    // Update is called once per frame
    void Update() {
        /// Incrementamos el contador de frames
        _framesCounter++;
        /// Si el contador de frames es igual al parámetro de frames
        if (_framesCounter == _frames) {
            /// Cambiamos el valor de una posición aleatoria
            _color[Random.Range(0, 3)] = Random.value;
            /// Asignamos el nuevo color al objeto
            GetComponent<Renderer>().material.color = new Color(_color.x, _color.y, _color.z);
            /// Reiniciamos el contador de frames
            _framesCounter = 0;
        }
        
    }
}
