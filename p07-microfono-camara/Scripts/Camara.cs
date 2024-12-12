using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara: MonoBehaviour {
    /// Declaración de variables: Material, WebCamTexture y String para almacenar el path del directorio donde almacenar las imágenes
    private Material tvMaterial; // Material del objeto donde se muestra la cámara
    private WebCamTexture webcamTexture; // Textura de la cámara
    private string savePath; // Ruta donde guardar imágenes
    int captureCounter = 1; // Contador para el nombre de las capturas

    // Start se llama antes del primer frame de actualización
    void Start() {
        // Inicializar el material al que posteriormente se asignará cada imagen-frame de la cámara
        GameObject plane = GameObject.FindWithTag("Plano"); // Buscar el objeto con el tag "Plano"
        if (plane != null) {
            Renderer renderer = plane.GetComponent<Renderer>();
            tvMaterial = renderer.material;
            Debug.Log("Material del plano asignado correctamente.");
        } else {
            Debug.LogError("No se encontró un objeto con el tag 'Plano'.");
        }

        // Usar el constructor de WebCamTexture para inicializar una variable de ese tipo
        if (WebCamTexture.devices.Length > 0) {
            string selectedCamera = WebCamTexture.devices[2].name;
            webcamTexture = new WebCamTexture(selectedCamera);
            Debug.Log($"Cámara seleccionada: {selectedCamera}");
        } else {
            Debug.LogError("No se detectaron cámaras en este dispositivo.");
        }

        foreach (var device in WebCamTexture.devices) {
            Debug.Log($"Cámara encontrada: {device.name}");
        }

        // Inicializar la ruta para guardar capturas
        savePath = Application.persistentDataPath;
        Debug.Log($"Ruta de almacenamiento de imágenes: {savePath}");
    }

    // Update se llama una vez por frame
    void Update() {
        if (Input.GetKey("s")) {
            if (webcamTexture != null && !webcamTexture.isPlaying) {
                // Asignar a la mainTexture del material lo que capta la cámara
                tvMaterial.mainTexture = webcamTexture;
                webcamTexture.Play(); // La captura se inicia
                Debug.Log("Captura de video iniciada.");
            }
        }

        if (Input.GetKey("p")) {
            if (webcamTexture != null && webcamTexture.isPlaying) {
                // Parar la captura de video
                webcamTexture.Stop();
                Debug.Log("Captura de video detenida.");
            }
        }

        if (Input.GetKey("x")) {
            if (webcamTexture != null && webcamTexture.isPlaying) {
                // Capturar la imagen actual de la cámara
                Texture2D capture = new Texture2D(webcamTexture.width, webcamTexture.height);
                capture.SetPixels(webcamTexture.GetPixels());
                capture.Apply();

                // Guardar la imagen en la ruta definida
                byte[] bytes = capture.EncodeToPNG();
                string fileName = $"{savePath}/Capture_{captureCounter}.png";
                System.IO.File.WriteAllBytes(fileName, bytes);
                captureCounter++;
                Debug.Log($"Imagen capturada y guardada en: {fileName}");
            } else {
                Debug.LogWarning("No se está capturando video. No se puede guardar la imagen.");
            }
        }
    }
}
