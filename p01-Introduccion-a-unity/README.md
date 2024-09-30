# Introducción a Unity
* Esther M. Quintero
* alu0101434780@ull.edu.es

## Tareas realizadas
* _Incluir objetos 3D básicos._  
    * Los objetos básicos añadidos son un cubo, una esfera y una cápsula. Se les ha dado un material simple rojo.
    * Están agrupados en el objeto vació denominado "ObjetosBasicos".
* _Incluir  en el proyecto el paquete Starter Assets._  
    * Se ha incluido el paquete [Starter Assets](https://assetstore.unity.com/packages/essentials/starter-assets-thirdperson-updates-in-new-charactercontroller-pa-196526?srsltid=AfmBOooOfzG9vjTZm_1M6-V6_A74crJlWHGpXM7b-TEFd1_TqJ9kxvkz)
* _Incluir un objeto libre de la Asset Store que no sea de los Starter Assets._
    * Se ha añadido al robot [Kyle](https://assetstore.unity.com/packages/3d/characters/robots/robot-kyle-urp-4696?srsltid=AfmBOoo6GiIa_p6qBKas8AFZ-Wk1zVkDrreLmKzIdc5dh8IW2V4ynly2).
* _Crear un terreno._
    * Se ha creado el elemento Terreno. Además, para decorar el terreno se han utilizado las herramientas de "Paint" Terrain" y "Paint Grass".
* _Cada objeto debe tener una etiqueta que lo identifique._
    * Se han etiquetado los objetos usando el mismo nombre que tienen en la jerarquía (por simplicidad y comodidad).
* _Utilizar prefabs de Starter Asset FPS o Third Person._
    * Se ha añadido el prefab de **PlayerCapsule**. Además, se le ha incorporado la cámara principal para lograr que se vea en "primera persona" al empezar la simulación.
    * Se han añadido dos prefabs de **entorno**: el edificio y las escaleras. También se les ha dado un material simple negro.
* _Agregar un script que escriba en la consola la posición de cada objeto que hayas utilizado._
    * Para ello, se han tomado las coordenadas del objeto desde la componente Transform. El código se puede ver en el siguiente [fichero](PosicionActual.cs).
    * Se indican las coordenadas de los objetos en **Start()** ya que, excepto la cápsula, el resto son estáticos. Si se quisiera que se actualizaran las posiciones habría que usar Update() o incluso una función que detectase si se ha movido el objeto o no.

## Gif animado de la ejecución
![Ejecución](ejecucion.gif)