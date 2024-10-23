/**
  Este script es para las arañas de tipo 2
  Cuando el notificador las avise, se orientarán hacia un huevo del tipo 2
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4RespuestaT2: MonoBehaviour {
    public Ej4Notificador notificador;
    public GameObject huevo2;
    bool followHuevo2 = false;
    // Start is called before the first frame update
    void Start() {
        notificador.OnTrigger += OrientarHaciaHuevo2;
        huevo2 = GameObject.FindGameObjectWithTag("HuevoT2");
    }

    // Update is called once per frame
    void Update() {
        if (followHuevo2) {
            transform.LookAt(huevo2.transform);
        }
    }

    void OrientarHaciaHuevo2() {
        followHuevo2 = true;
    }
}
