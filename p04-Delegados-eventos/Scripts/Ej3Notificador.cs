/**
  Este script detecta la colisión con un objeto y notifica a los suscriptores
  Si choca con las arañas de tipo 1 --> OnTrigger1
  Si choca con las arañas de tipo 2 --> OnTrigger2
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3Notificador: MonoBehaviour {
    public delegate void mensaje();
    /// Evento para notificar
    public event mensaje OnTrigger1;
    public event mensaje OnTrigger2;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "ArañaT1") {
            OnTrigger1();
        }
        if (other.tag == "ArañaT2") {
            OnTrigger2();
        }
    }
}
