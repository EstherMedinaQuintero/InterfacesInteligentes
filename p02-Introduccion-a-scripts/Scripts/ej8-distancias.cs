/**
  Este script busca la esfera de tipo 2 más cercana al cubo y le aumenta la altura.
  También busca la más lejana y le cambia el color cuando el jugador pulsa el espacio.
  Este script lo tendrá el cubo.
    - Etiqueta de las esferas de tipo 2: EsferaTipo2
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8Distancias: MonoBehaviour {
    /// Objetos que van a cambiar de altura y color
    GameObject _esferaMasCercana;
    GameObject _esferaMasLejana;
    // Esta función incrementa la altura de la esfera en 1
    void IncrementarAltura(GameObject esfera) {
        esfera.transform.localScale += new Vector3(0f, 1f, 0f);
    }
    // Start is called before the first frame update
    void Start() {
        /// Buscamos las esferas de tipo 2
        GameObject[] esferasTipo2 = GameObject.FindGameObjectsWithTag("EsferaTipo2");
        /// Preparamos las distancias que servirán para comparar
        /// Las distancias se inicializan con la distancia entre la primera esfera y el cubo
        float distanciaMinima = Vector3.Distance(esferasTipo2[0].transform.position, transform.position);
        float distanciaMaxima = Vector3.Distance(esferasTipo2[0].transform.position, transform.position);
        /// Preparamos las esferas que servirán para cambiar la altura y el color
        GameObject esferaMasCercana = esferasTipo2[0];
        GameObject esferaMasLejana = esferasTipo2[0];
        /// Recorremos las esferas
        foreach (GameObject esfera in esferasTipo2) {
            float distancia = Vector3.Distance(esfera.transform.position, transform.position);
            if (distancia < distanciaMinima) {
                distanciaMinima = distancia;
                esferaMasCercana = esfera;
            } else if (distancia > distanciaMaxima) {
                distanciaMaxima = distancia;
                esferaMasLejana = esfera;
            }
        }
        _esferaMasCercana = esferaMasCercana;
        _esferaMasLejana = esferaMasLejana;
        IncrementarAltura(_esferaMasCercana);
    }

    // Update is called once per frame
    void Update() {
        /// Si se pulsa el espacio, cambiamos el color de la esfera más lejana
        if (Input.GetKeyDown(KeyCode.Space)) {
            _esferaMasLejana.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        } 
    }
}
