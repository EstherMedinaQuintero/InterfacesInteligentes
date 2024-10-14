# Movimientos y física
* Esther M. Quintero
* alu0101434780@ull.edu.es

> [!WARNING]  
> Los gifs tardan un poco en cargar al abrirlo desde GitHub.

## Índice <div id='indice'/>

1. [Ejercicios de físicas 3d](#fisicas)
    * [Situación 1](#fisicas1)
    * [Situación 2](#fisicas2)
    * [Situación 3](#fisicas3)
    * [Situación 4](#fisicas4)
    * [Situación 5](#fisicas5)
    * [Situación 6](#fisicas6)
    * [Situación 7](#fisicas7)
    * [Situación 8](#fisicas8)
    * [Situación 9](#fisicas9)
2. [Ejercicios de la práctica 3](#practica)
    1. [Ejercicio 1](#uno)
    2. [Ejercicio 2](#dos)
    3. [Ejercicio 3](#tres)
    4. [Ejercicio 4](#cuatro)
    5. [Ejercicio 5](#cinco)
    6. [Ejercicio 6](#seis)
    7. [Ejercicio 7](#siete)
    8. [Ejercicio 8](#ocho)
    9. [Ejercicio 9](#nueve)
    10. [Ejercicio 10](#diez)
    11. [Ejercicio 11](#once)
    12. [Ejercicio 12](#doce)

## Tareas realizadas

### Ejercicios de físicas 3d <div id='fisicas'/>

#### Situación 1 <div id='fisicas1'/>

* El plano no es un objeto físico: tiene collider.
* La esfera no es un objeto físico: tiene collider.
* El cubo es un objeto físico: tiene rigidbody.

En este caso el cubo es el único que puede moverse por el motor de físicas (y chocar con el plano y la esfera).

![fisicas1.gif](./Gifs/fisicas1.gif)    

#### Situación 2 <div id='fisicas2'/>

* El plano no es un objeto físico: tiene collider.
* La esfera es un objeto físico: tiene rigidbody.
* El cubo es un objeto físico: tiene rigidbody.

En este caso tanto el cubo como la esfera son movidos por el motor de físicas.

![fisicas2.gif](./Gifs/fisicas2.gif)    

#### Situación 3 <div id='fisicas3'/>

* El plano no es un objeto físico: tiene collider.
* El cubo es un objeto físico: tiene rigidbody.
* La esfera es cinemática: isKinematic.

En este caso, la esfera a pesar de tener Rigidbody no puede ser movida por el motor de físicas.

![fisicas3.gif](./Gifs/fisicas3.gif)   

#### Situación 4 <div id='fisicas4'/>

* El plano es un objeto físico: tiene rigidbody.
* La esfera es un objeto físico: tiene rigidbody.
* El cubo es un objeto físico: tiene rigidbody.

Al tener los tres comportamiento físico, se caen los tres.

![fisicas4.gif](./Gifs/fisicas4.gif)    

#### Situación 5 <div id='fisicas5'/>

* El plano es un objeto físico: tiene rigidbody.
* La esfera es un objeto físico: tiene rigidbody.
* La esfera tiene 10 veces más masa que el cubo. 
* El cubo es un objeto físico: tiene rigidbody.

La esfera, a pesar de tener más masa no se mueve distinto, pues estamos en un entorno sin fricción (principio de equivalencia de Galileo, que establece que en ausencia de otras fuerzas, todos los cuerpos aceleran al mismo ritmo bajo la gravedad). Además, Unity ajusta automáticamente las velocidades usando el motor de física, por lo que aunque la masa afecta la inercia y la forma en que los objetos responden a las fuerzas, la velocidad final no depende de la masa en escenarios en los que las fuerzas aplicadas son uniformes y continuas. De hecho, si añadimos fricción podemos ver que la esfera "empuja" al cubo.

![fisicas5.gif](./Gifs/fisicas5.gif)  

#### Situación 6 <div id='fisicas6'/>

* El plano es un objeto físico: tiene rigidbody.
* La esfera es un objeto físico: tiene rigidbody.
* La esfera tiene 100 veces más masa que el cubo. 
* El cubo es un objeto físico: tiene rigidbody.

Estamos ante el mismo caso que antes.

![fisicas6.gif](./Gifs/fisicas6.gif)    

#### Situación 7 <div id='fisicas7'/>

* El plano es un objeto físico: tiene rigidbody.
* La esfera es un objeto físico: tiene rigidbody.
* La esfera es física con fricción.
* El cubo es un objeto físico: tiene rigidbody.

Al tener fricción la esfera, le cuesta más moverse.

![fisicas7.gif](./Gifs/fisicas7.gif)   

#### Situación 8 <div id='fisicas8'/>

* El plano es un objeto físico: tiene rigidbody.
* La esfera no es un objeto físico: tiene collider.
* La esfera es trigger.
* El cubo es un objeto físico: tiene rigidbody.

En teoría, en esta configuración la esfera deja pasar objetos a través de ella. Sin embargo, por la situación actual no se da el caso. Es decir, la esfera está actuando esencialmente como un sensor (si algún objeto chocase con ella se podría detectar).

![fisicas8.gif](./Gifs/fisicas8.gif)    

#### Situación 9 <div id='fisicas9'/>

* El plano es un objeto físico: tiene rigidbody.
* La esfera es un objeto físico: tiene rigidbody.
* La esfera es trigger.
* El cubo es un objeto físico: tiene rigidbody.

Aquí la situación parece exactamente igual a la de antes; sin embargo, la diferencia es que además de servir como trigger, la esfera se mueve e interactúa con objetos físicos. De hecho, en esta situación si el plano no fuera físico podemos ver que mueve el cubo y atraviesa el plano.

![fisicas9.gif](./Gifs/fisicas9.gif)   

### Ejercicios de la práctica <div id='practica'/>

#### Ejercicio 1 <div id='uno'/>


#### Ejercicio 2 <div id='dos'/>


#### Ejercicio 3 <div id='tres'/>


#### Ejercicio 4 <div id='cuatro'/>


#### Ejercicio 5 <div id='cinco'/>


#### Ejercicio 6 <div id='seis'/>


#### Ejercicio 7 <div id='siete'/>


#### Ejercicio 8 <div id='ocho'/>


#### Ejercicio 9 <div id='nueve'/>


#### Ejercicio 10 <div id='diez'/>


#### Ejercicio 11 <div id='once'/>


#### Ejercicio 12 <div id='doce'/>
