/**
  Este script es para las arañas de tipo 1
  Cuando el notificador las avise, se teletransportarán a un huevo del tipo 1
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4RespuestaT1: MonoBehaviour {
    /// Notificador
    public Ej4Notificador notificador;
    public GameObject huevo1;
    // Start is called before the first frame update
    void Start() {
        notificador.OnTrigger += MoverHaciaHuevo1; /// Suscripción al evento OnTrigger
        /// Buscamos el huevo más cercanos
        huevo1 = GameObject.FindGameObjectWithTag("HuevoT1");
    }

    // Update is called once per frame
    void Update() {
        
    }

    void MoverHaciaHuevo1() {
        transform.position = huevo1.transform.position;
    }
}
