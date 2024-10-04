# Introducción a Unity
* Esther M. Quintero
* alu0101434780@ull.edu.es

## Índice <div id='indice'/>

1. [Ejercicio 1](#uno)
2. [Ejercicio 2](#dos)
3. [Ejercicio 3](#tres)
4. [Ejercicio 4](#cuatro)
5. [Ejercicio 5](#cinco)
6. [Ejercicio 6](#seis)
7. [Ejercicio 7](#siete)
8. [Ejercicio 8](#ocho)

## Tareas realizadas

### Ejercicio 1 <div id='uno'/>

1. _Crea un script asociado a un objeto en la escena que inicialice un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color)._
    * Cada 120 frames se debe cambiar el valor de una posición aleatoria y asignar el nuevo color al objeto. 
    * Parametrizar la cantidad de frames de espera para poderlo cambiar desde el inspector.

### Ejercicio 2 <div id='dos'/>

2. _Crea una escena simple en la que ubiques un plano y sobre él un cubo, una esfera y un cilindro. 
    * Cada uno de los objetos debe estar en un color diferente. 
    * En la consola cada objeto debe mostrar su nombre.

### Ejercicio 3 <div id='tres'/>

3. _Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:_
    * La magnitud de cada uno de ellos. 
    * El ángulo que forman
    * La distancia entre ambos.
    * Un mensaje indicando qué vector está a una altura mayor.
    * Muestra en el inspector cada uno de esos valores

### Ejercicio 4 <div id='cuatro'/>

4. _Muestra en pantalla el vector con la posición de la esfera._

### Ejercicio 5 <div id='cinco'/>

5. _Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro._

### Ejercicio 6 <div id='seis'/>

6. _Selecciona tres posiciones en tu escena a través de un objeto invisible (marcador) que incluya 3 vectores numéricos para configurar posiciones en las que quieres ubicar los objetos en respuesta a pulsar la barra espaciadora._ 
    * Estos vectores representan un desplazamiento respecto a la posición original del objeto. 
    * Crea un script que ubique en las posiciones configuradas cuando el usuario pulse la barra espaciadora.

### Ejercicio 7 <div id='siete'/>

7. _Cambia el color del cilindro cuando el usuario pulse la tecla C, cambia el color del cubo cuando el usuario pulse la flecha arriba._

### Ejercicio 8 <div id='ocho'/>

8. _Agrega 5 esferas más en la escena._
    * Crea un grupo de 2 , asígnales la misma etiqueta para indicar esferas de tipo 1 y a las restantes otra etiqueta diferente a ésta para indicar esferas de grupo 2. 
    * En la escena también habrá un cubo. 
    * Implementa un script que aumente la altura de la esfera de tipo 2 más cercana al cubo. 
    * Cambia el color de la más lejana cuando el jugador pulsa la tecla espacio.
