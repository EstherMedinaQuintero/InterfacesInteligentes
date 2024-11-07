# Escenas cardboard (1)
* Esther M. Quintero
* alu0101434780@ull.edu.es

> [!WARNING]  
> Los gifs tardan un poco en cargar al abrirlo desde GitHub.

## Guía de inicio rápido de Google Cardboard para Unity

1. [Configurar el entorno de desarrollo](#entorno)
1. [Importar el SDK y crear un nuevo proyecto](#sdk)
1. [Configurar escena](#escena)
1. [Configurar proyecto de Android](#android)
1. [Activar y desactivar](#activar)

### Configura tu entorno de desarrollo <div id='entorno'/>

* Versión utilizada: `2023.1.13.f1`
* Compatibilidad Android instalada
* Git instalado

### Importa el SDK y crea un proyecto nuevo <div id='sdk'/>

* Abrir Unity y crear un proyecto 3D.

![Crear proyecto](image.png)

* Ir a Window > Administrador de paquete
* Darle a + y seleccionar Add package from git URL

![Lugar de instalación](image-1.png)

* Instalar de `https://github.com/googlevr/cardboard-xr-plugin.git`
* Ir al `Google Cardboard XR Plugin` en Unity package
* En el apartado de `Samples`, elegimos `Import into Project`

![Samples lugar](image-2.png)

* El ejemplo se carga en `Assets/Samples/Google Cardboard/<version>/Hello Cardboard`

![Ruta del ejemplo](image-3.png)

### Cómo configurar una escena de HelloCardboard <div id='escena'/>

* Ir a `Assets/Samples/Google Cardboard/<version>/Hello Cardboard/Scenes`
* Seleccionar `Add Open Scenes`
* Elegir `HelloCardboard` para abrir la escena de ejemplo

![Escena abierta](image-4.png)

* Abrir `Layers` en el menú y seleccionar `Edit Layers`

![Menú de layers](image-5.png)

* Añadir una nueva capa llamada "Interactive"

![Nueva capa](image-6.png)

* Seleccionar `Treasure` GameObject para abrir el `Inspector` window
* Poner como su layer `"Interactive"`
* Si sale un pop-up, marcar `"Yes, change children"`

![Añadir layer](image-7.png)

* Hacer clic en `Player > Camera > CardboardReticlePointer` GameObject para abrir el Inspector 
* En el script `"Carboard reticle pointer"`, seleccionar "Interactive" como el `Reticle Interaction Layer Mask`

![Selección del objeto](image-8.png)

### Cómo establecer la configuración del proyecto de Android <div id='android'/>

* Navegar a `File > Build Settings`
  * Seleccionar `Android` y elegir `Switch Platform`
  * Seleccionar `Add Open Scenes` y elegir `HelloCardboard`

![Seleccionar escena en Android](image-9.png)

* Navegamos a `Edit > Project Settings > Player > Resolution and Presentation`
  * Marcar `Default Orientation` a `Landscape Left` o `Landscape Right`
  * Desactivar `Optimized Frame Pacing`

![Opciones de landscape](image-10.png)

* Navegamos a `Edit > Project Settings > Player > Other Settings`
  * Choose OpenGLES2, OpenGLES3, or Vulkan, or any combination of them in Graphics APIs.
  * Select Android 8.0 'Oreo' (API level 26) or higher in Minimum API Level.
  * Select API level 33 or higher in Target API Level.
  * Select IL2CPP in Scripting Backend.
  * Select desired architectures by choosing ARMv7, ARM64, or both in Target Architectures.
  * Select Require in Internet Access.
  * Specify your company domain under Package Name.
  * If Vulkan was selected as Graphics API:
    * Uncheck Apply display rotation during rendering checkbox in Vulkan Settings.
    * If the Unity version is 2021.2 or above, Select ETC2 in Texture compression format.
  * If the Unity version is 2023.1 or later, select Activity and clear GameActivity in Application Entry Point.
* Cambiar los settings de publicación
* Hacer el build

### Probando el apk

![Video de prueba](./ApkCardboard.gif)

