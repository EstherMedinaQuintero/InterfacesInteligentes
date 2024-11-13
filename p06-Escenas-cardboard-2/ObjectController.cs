using System.Collections;
using UnityEngine;

public class ObjectController: MonoBehaviour {
    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;
    private Coroutine gazeCoroutine; // Corrutina para destruir el objeto
    private float gazeDuration = 3.0f; // Tiempo en segundos para destruir el objeto
    public ScoreNotifier scoreNotifier; // Referencia al ScoreNotifier para registrar la recolección

    public void Start() {
        SetMaterial(false);
        // Registrar este objeto en el ScoreNotifier si existe
        if (scoreNotifier != null) {
            scoreNotifier.RegisterObject(this);
        }
    }

    public void OnPointerEnter() {
        SetMaterial(true);
        gazeCoroutine = StartCoroutine(GazeAndDestroy());
    }

    public void OnPointerExit() {
        SetMaterial(false);
        // Detiene la corrutina si el usuario deja de mirar antes de tiempo
        if (gazeCoroutine != null) {
            StopCoroutine(gazeCoroutine);
            gazeCoroutine = null;
        }
    }

    private IEnumerator GazeAndDestroy() {
        // Espera el tiempo especificado
        yield return new WaitForSeconds(gazeDuration);
        // Destruye el objeto después de 3 segundos de mirarlo
        // 1) Lo mueve a la capa 0 (Default)
        gameObject.layer = 0;
        // 2) Lo desactiva
        gameObject.SetActive(false);
        // Notificar al ScoreNotifier
        scoreNotifier?.NotifyObjectCollected();
    }

    private void SetMaterial(bool gazedAt) {  
        if (gazedAt) {
            foreach (Transform child in transform) {
                if (child.tag == "EggColor") {
                    Debug.Log("Estamos mirando un objeto");
                    Material new_material = new Material(child.GetComponent<Renderer>().material);
                    new_material.color = Color.red; // Cambia a rojo al mirar
                    child.GetComponent<Renderer>().material = new_material;
                }
            }
            
        } else {
            foreach (Transform child in transform) {
                if (child.tag == "EggColor") {
                    Material new_material = new Material(child.GetComponent<Renderer>().material);
                    new_material.color = Color.white; // Cambia a blanco cuando no se mira
                    child.GetComponent<Renderer>().material = new_material;
                }
            }
            
        }
    }
}
