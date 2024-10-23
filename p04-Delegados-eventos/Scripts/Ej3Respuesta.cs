/**
  Si chocaron con las arañas de tipo 2 --> OnTrigger2
        --> Las arañas del tipo 1 se mueven hacia el huevo más cercano del tipo 1 (tag: HuevoT1)
  Si chocaron con las arañas de tipo 1 --> OnTrigger1
        --> Las arañas del tipo 1 se mueven hacia el huevo más cercano del tipo 2 (tag: HuevoT2)
        --> Las arañas del tipo 1 cambian su color si colisionan con el huevo
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3Respuesta: MonoBehaviour {
    /// Notificador
    public Ej3Notificador notificador;
    public float speed = 3.0f;
    Vector3 direction;
    public GameObject huevo1;
    public GameObject huevo2;
    bool followHuevo1 = false;
    bool followHuevo2 = false;

    // Start is called before the first frame update
    void Start() {
        notificador.OnTrigger1 += MoverHaciaHuevo1; /// Suscripción al evento OnTrigger1
        notificador.OnTrigger2 += MoverHaciaHuevo2; /// Suscripción al evento OnTrigger2
        /// Buscamos los huevos más cercanos
        huevo1 = GameObject.FindGameObjectWithTag("HuevoT1");
        huevo2 = GameObject.FindGameObjectWithTag("HuevoT2");
    }

    // Update is called once per frame
    void Update() {
        if (followHuevo1) {
            transform.position = Vector3.MoveTowards(transform.position, huevo1.transform.position, speed * Time.deltaTime);
        }
        if (followHuevo2) {
            transform.position = Vector3.MoveTowards(transform.position, huevo2.transform.position, speed * Time.deltaTime);
        }
    }

    /// Si chocaron con las arañas de tipo 1 --> OnTrigger1
    void MoverHaciaHuevo1() {
        followHuevo1 = true;
        followHuevo2 = false;
    }

    /// Si chocaron con las arañas de tipo 2 --> OnTrigger2
    void MoverHaciaHuevo2() {
        followHuevo1 = false;
        followHuevo2 = true;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "HuevoT2") {
            Debug.Log("Colision con huevo 2");
            /// Buscamos el componente hijo que tiene "EggColor"
            foreach (Transform child in other.transform) {
                if (child.tag == "EggColor") {
                    Debug.Log("Cambio de color");
                    Material new_material = new Material(child.GetComponent<Renderer>().material);
                    new_material.color = Color.red;
                    child.GetComponent<Renderer>().material = new_material;
                }
            }
        }
    }
}
