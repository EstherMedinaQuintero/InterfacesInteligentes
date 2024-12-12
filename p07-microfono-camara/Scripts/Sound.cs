/**
  Si la araña choca con algo, hace un sonido
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound: MonoBehaviour {
    public AudioClip collisionSound; // El sonido que se reproducirá al chocar
    private AudioSource audioSource; // Fuente de audio para reproducir el sonido

    // Start se llama antes del primer frame de actualización
    void Start() {
        // Inicializa el componente AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    // Método que se llama cuando este objeto colisiona con otro
    void OnTriggerEnter(Collider other) {
        if (other.tag != "Plano") {
            Debug.Log("Repoduciendo sonido de colisión");
            audioSource.PlayOneShot(collisionSound);
        }
    }
}

