/**
  Si han pisado a una araña del tipo 1, se disminuye el contador
  y se destruye la araña
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ej8Respuesta: MonoBehaviour {
    /// Notificador
    public Ej8Notificador notificador;
    public TextMeshProUGUI textoPuntos;

    // Start is called before the first frame update
    void Start() {
        notificador.OnTrigger += Morir; /// Suscripción al evento OnTrigger
    }

    // Update is called once per frame
    void Update() {
    }

    void Morir(GameObject colision) {
        if (colision == gameObject) {
            /// Quitamos el evento
            notificador.OnTrigger -= Morir;
            /// Disminuimos el contador
            int contador = int.Parse(textoPuntos.text);
            contador--;
            textoPuntos.text = contador.ToString();
            /// Destruimos el objeto
            Destroy(gameObject);
        }
    }
}
