/**
  Este script mueve con WASD el objeto que lo contiene
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento: MonoBehaviour {
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        /// Vble para multiplicar
        float timedSpeed = speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * timedSpeed, Space.World);
        } else if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * timedSpeed, Space.World);
        } else if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * timedSpeed, Space.World);
        } else if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * timedSpeed, Space.World);
        }
    }
}
