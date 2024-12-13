# Sensores
* Esther M. Quintero
* alu0101434780@ull.edu.es

> [!WARNING]  
> Los gifs tardan un poco en cargar al abrirlo desde GitHub.

1. [Componentes del móvil](#componentes)
1. [Mover samurai](#samurai)

## Componentes <div id='componentes'/>

![Imagen 1](./Multimedia/Screenshot_20241213_100011_PracticaSensores.jpg)     
![Imagen 2](./Multimedia/Screenshot_20241213_100101_PracticaSensores.jpg)    

``` csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowValues: MonoBehaviour {
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start() {
        Input.location.Start();
        Input.gyro.enabled = true;
        /// Comprobar si tiene giroscopio
        if (!SystemInfo.supportsGyroscope) {
            Debug.Log("Giroscopio no soportado");
        }
    }

    // Update is called once per frame
    void Update() {
        text.text = "Velocidad angular: " + Input.gyro.rotationRateUnbiased.ToString() + "\n" +
                    "Aceleración: " + Input.acceleration.ToString() + "\n" +
                    "Altitud: " + Input.location.lastData.altitude.ToString() + "\n" +
                    "Gravedad: " + Input.gyro.gravity.ToString() + "\n" +
                    "Longitud: " + Input.location.lastData.longitude.ToString() + "\n" +
                    "Latitud: " + Input.location.lastData.latitude.ToString();
    }
}
```

## Mover samurai <div id='samurai'/>

``` csharp
public class SamuraiMovement: MonoBehaviour {
    /// Objeto del samurai
    public GameObject samurai;
    /// Velocidad del samurai
    public float speed = 0.1f;
    /// Rango de latitud
    public float maxLat = 0f;
    public float minLat = 0f;
    /// Rango de longitud
    public float maxLon = 0f;
    public float minLon = 0f;

    void Start() {
        Input.gyro.enabled = true;
        Input.location.Start();
        /// Comprobar si tiene giroscopio
        if (!SystemInfo.supportsGyroscope) {
            Debug.Log("Giroscopio no soportado");
        }
    }

    void OrientToNorth() {
        Quaternion attitude = Input.gyro.attitude;
        samurai.transform.rotation = attitude;
        samurai.transform.Rotate(0f, 0f, 180f, Space.Self);
        samurai.transform.Rotate(90f, 180f, 0f, Space.World);
    }

    void MoveSamurai() {
        /// Hacia donde está mirando
        Vector3 direction = samurai.transform.forward;
        /// Aceleración del dispositivo
        Vector3 acceleration = Input.acceleration;
        /// Invertir la aceleración en z
        acceleration.z = -acceleration.z;
        /// Mover el samurai
        samurai.transform.position += direction * acceleration.z * speed;
    }

    void Update() {
        OrientToNorth();
        MoveSamurai();
    }
}
```

![Gif del movimiento]()