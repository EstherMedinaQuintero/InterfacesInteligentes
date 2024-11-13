# Escenas cardboard (2)
* Esther M. Quintero
* alu0101434780@ull.edu.es

> [!WARNING]  
> Los gifs tardan un poco en cargar al abrirlo desde GitHub.

## Enunciado de la práctica

Con la escena del ejercicio 8 de la práctica anterior crea un proyecto de CardBoard, en el que implementes la mecánica de recolección de algún objeto. La interacción para la recolección se lleva a cabo con la mirada del jugador. Además cuando se llega a una determinada puntuación un tipo de objetos debe dirigirse hacia un punto preestablecido.

### Explicación de lo realizado

* Se ha hecho recolección de huevos.
* Cuando se mira un huevo durante 3 segundos, este se recolecta.
* Al llegar a 5 huevos, las arañas de alrededor corren hacia el jugador.

### Scripts 

* Se ha modificado el script de [ObjectController.cs](./ObjectController.cs)

```csharp
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
```

* Se ha creado el script de [ScoreNotifier.cs](./ScoreNotifier.cs)

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreNotifier: MonoBehaviour {
  private int collectedObjectsCount = 0;
  private int targetScore = 5; // Puntaje objetivo para activar el movimiento

  // Método para registrar la recolección de un objeto
  public void NotifyObjectCollected() {
    collectedObjectsCount++;
    Debug.Log("Objeto recolectado. Total de objetos recolectados: " + collectedObjectsCount);

    // Verifica si el puntaje ha alcanzado el objetivo
    if (collectedObjectsCount == targetScore) {
      MoveAllSpidersToNotifier();
    }
  }

  // Método para mover todos los objetos con tag "Spider" hacia este objeto
  private void MoveAllSpidersToNotifier() {
    GameObject[] spiders = GameObject.FindGameObjectsWithTag("Spider");
    foreach (GameObject spider in spiders) {
      StartCoroutine(MoveSpiderTowardsNotifier(spider));
    }
    Debug.Log("¡Todos los objetos con el tag 'Spider' se están moviendo hacia el ScoreNotifier!");
  }

  // Corrutina para mover un objeto "Spider" hacia el ScoreNotifier
  private IEnumerator MoveSpiderTowardsNotifier(GameObject spider) {
    float speed = 2.0f;
    while (spider != null && Vector3.Distance(spider.transform.position, transform.position) > 0.1f) {
      spider.transform.position = Vector3.MoveTowards(
        spider.transform.position,
        transform.position,
        speed * Time.deltaTime
      );
      yield return null;
    }
  }

  // Método para reiniciar el contador
  public void ResetScore() {
    collectedObjectsCount = 0;
    Debug.Log("Contador de recolección reiniciado.");
  }

  // Registro de un objeto
  public void RegisterObject(ObjectController obj) {
    Debug.Log("Objeto registrado para notificación.");
  }

  // Método para obtener el número de objetos recolectados
  public int GetCollectedObjectsCount() {
    return collectedObjectsCount;
  }
}
```

### Probando el apk

![Video de prueba](./ApkCardboard.gif)

