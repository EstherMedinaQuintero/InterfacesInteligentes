using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabadora: MonoBehaviour {
    private AudioSource audioSource; // Componente de audio para grabar y reproducir
    private string micName; // Nombre del micrófono
    private bool isRecording = false; // Para controlar el estado de grabación

    // Start se llama antes del primer frame de actualización
    void Start() {
        // Recuperar el componente AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = false; // Configuramos el audio para que no sea en bucle

        // Comprobar si hay micrófonos disponibles
        if (Microphone.devices.Length > 0) {
            micName = Microphone.devices[0]; // Usar el primer micrófono disponible
            Debug.Log($"Micrófono encontrado: {micName}");
        } else {
            Debug.LogError("No se detectaron micrófonos en este dispositivo.");
        }
    }

    // Update se llama una vez por frame
    void Update() {
        // Iniciar la grabación al mantener presionada la tecla 'R'
        if (Input.GetKeyDown(KeyCode.R)) {
            if (!isRecording && !audioSource.isPlaying) {
                Debug.Log("Iniciando grabación...");
                audioSource.clip = Microphone.Start(micName, false, 10, 44100); // Grabar por 10 segundos como máximo
                isRecording = true;
            }
        }

        // Detener la grabación y reproducir el audio al soltar la tecla 'R'
        if (Input.GetKeyUp(KeyCode.R)) {
            if (isRecording) {
                Microphone.End(micName);
                Debug.Log("Grabación detenida. Reproduciendo audio...");
                audioSource.Play(); // Reproducir el clip grabado
                isRecording = false;
            }
        }
    }
}
