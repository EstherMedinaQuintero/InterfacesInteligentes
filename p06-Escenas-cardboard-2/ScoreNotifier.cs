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
