# Delegados y eventos
* Esther M. Quintero
* alu0101434780@ull.edu.es

> [!WARNING]  
> Los gifs tardan un poco en cargar al abrirlo desde GitHub.

## Índice <div id='indice'/>

1. [Ejercicios de la práctica 4](#practica)
    1. [Ejercicio 1](#uno)
    2. [Ejercicio 2](#dos)
    3. [Ejercicio 3](#tres)
    4. [Ejercicio 4](#cuatro)
    5. [Ejercicio 5](#cinco)
    6. [Ejercicio 6](#seis)
    7. [Ejercicio 7](#siete)
    8. [Ejercicio 8](#ocho)
    9. [Ejercicio 9](#nueve)

## Tareas realizadas

### Ejercicios de la práctica <div id='practica'/>

#### Ejercicio 1 <div id='uno'/>

* Cubo 
  * Movimiento cinemático: [Movimiento](./Scripts/Movimiento.cs)
  * Notificador: [Ej1Notificador](./Scripts/Ej1Notificador.cs)
* Esferas de tipo 1
  * Suscriptoras: [Ej1RespuestaTipo1](./Scripts/Ej1RespuestaTipo1.cs)
* Esferas de tipo 2
  * Suscriptoras: [Ej1RespuestaTipo2](./Scripts/Ej1RespuestaTipo2.cs)

* Funcionamiento:
  * Cuando el cubo colisiona con el cilindro:
    * Las esferas de tipo 1 se dirigen hacia una esfera de tipo 2
    * Las esferas de tipo 2 se desplazan hacia el cilindro

[Collider](https://docs.unity3d.com/ScriptReference/Collider.html)    
[OnTrigger events](https://docs.unity3d.com/Manual/collider-interactions-ontrigger.html)

![ejercicio1.gif](./Gifs/ejercicio1.gif)   

#### Ejercicio 2 <div id='dos'/>

* Sustituir las esferas por arañas
* Sustituir el cilindro por un huevo

![ejercicio2.gif](./Gifs/ejercicio2.gif) 

[Asset de las arañas](https://assetstore.unity.com/packages/3d/characters/creatures/fuga-spiders-with-destructible-eggs-and-mummy-151921)

#### Ejercicio 3 <div id='tres'/>

* Cubo: [Ej3Notificador](./Scripts/Ej3Notificador.cs)
* Arañas de tipo 1: [Ej3Respuesta](./Scripts/Ej3Respuesta.cs)

* Cuando el cubo colisione con una araña del tipo 2:
  * Las del tipo 1 van hacia un huevo del tipo 1.
* Cuando el cubo colisiones con una araña del tipo 1:
  * Las arañas del tipo 1 van hacia un huevo del tipo 2.
  * Si tocan uno, deben cambiar de color.

![ejercicio3.gif](./Gifs/ejercicio3.gif)   

#### Ejercicio 4 <div id='cuatro'/>

* Cubo: [Ej4Notificador](./Scripts/Ej4Notificador.cs)
* Arañas de tipo 1: [Ej4RespuestaT1](./Scripts/Ej4RespuestaT1.cs)
* Arañas de tipo 2: [Ej4RespuestaT2](./Scripts/Ej4RespuestaT2.cs)

* Cuando el cubo colisione con el cilindro:
  * Las arañas del grupo 1 se teletransportan a un huevo fijado.
  * Las arañas del grupo 2 se orientan hacia un huevo fijado.

![ejercicio4.gif](./Gifs/ejercicio4.gif)   

#### Ejercicio 5 <div id='cinco'/>

* Añadir una puntuación para el jugador: [Ej5Puntuacion](./Scripts/Ej5Puntuacion.cs)
  * Las arañas de tipo 1 suman 5 puntos.
  * Las arañas de tipo 2 suman 10 puntos.

![ejercicio5.gif](./Gifs/ejercicio5.gif)   

#### Ejercicio 6 <div id='seis'/>

* Interfaz que muestre la puntuación: [Ej6Puntuacion](./Scripts/Ej6Puntuacion.cs)

[Canvas](https://docs.unity3d.com/ScriptReference/Canvas.html)

![ejercicio6.gif](./Gifs/ejercicio6.gif)   

#### Ejercicio 7 <div id='siete'/>

* Cada 100 puntos se sube un nivel: [Ej7Puntuacion](./Scripts/Ej7Puntuación.cs)

![ejercicio7.gif](./Gifs/ejercicio7.gif)   

#### Ejercicio 8 <div id='ocho'/>

* Escena:
  * Estás en tus servidores y tienes una plaga de arañas.
  * Tienes que matarlas a todas.

* Mecánicas:
  * Respuesta: [Ej8Respuesta](./Scripts/Ej8Respuesta.cs)
  * Notificador con parámetros: [Ej8Notificador](./Scripts/Ej8Notificador.cs)
  * Contador en UI

![ejercicio8.gif](./Gifs/ejercicio8.gif)   

#### Ejercicio 9 <div id='nueve'/>

* Implementar el ejercicio 3 siendo el cubo un objeto físico.
* Nuevo movimiento: [MovimientoFisicas](./Scripts/MovimientoFisicas.cs)

![ejercicio9.gif](./Gifs/ejercicio9.gif)   


