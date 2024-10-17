/**
  Este script traslada una cantidad proporcional un vector que indica la dirección del movimiento (moveDirecction).
  La cantidad de traslación se puede modificar desde el inspector.
  La velocidad también se puede modificar desde el inspector (speed).
  Inicialmente la velocidad es mayor que 1.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3Trasladar: MonoBehaviour {
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private Vector3 moveDirection = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        /// Movimiento respecto al sistema local
        // transform.Translate(moveDirection * speed * Time.deltaTime);
        /// Movimiento respecto al sistema global
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
