/**
  Este script muestra la posición actual del objeto en el que se encuentra.
  También se muestra el "tag" del objeto.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionActual: MonoBehaviour {
	// Start is called before the first frame update
	void Start() {
		Transform ubication = GetComponent<Transform>();
		/// Posición del objeto "tag" es (x, y, z)
		Debug.Log("Posición del objeto " + gameObject.tag + " es " + ubication.position.ToString());	
	}

	// Update is called once per frame
	void Update() {

	}
}
