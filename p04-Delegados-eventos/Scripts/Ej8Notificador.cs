/**
  Este script detecta la colisión con un objeto y notifica a los suscriptores
  Si choca con las arañas de tipo 1, estas son "escachadas" y se disminuye el contador de arañas
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8Notificador: MonoBehaviour {
    public delegate void mensaje(GameObject colision);
    /// Evento para notificar
    public event mensaje OnTrigger;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "ArañaT1") {
            OnTrigger?.Invoke(other.gameObject); 
            /// El ? es para evitar excepciones si no hay suscriptores
        }
    }
}
