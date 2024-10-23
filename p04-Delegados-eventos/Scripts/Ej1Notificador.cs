/**
  Este script detecta la colisión con un objeto y notifica a los suscriptores
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1Notificador: MonoBehaviour {
    /// Delegado para notificar
    public delegate void mensaje();
    /// Evento para notificar
    public event mensaje OnTrigger;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Cilindro") {
            OnTrigger();
        }
    }
}