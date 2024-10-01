# PRIMERA PRÁCTICA DE INTERFACES INTELIGENTES

## Descripción

Este proyecto trata de una introducción simple al uso de assets en unity y la creación de scripts sencillos.

## Implementaciones

- **Objeto globo aerostático**: Se ha descado un asset desde sketchfab y se ha incluido al proyecto.

> URL: https://sketchfab.com/3d-models/worldskills-hot-air-balloon-77d4e26489d34657b60dccf87d952e15

- **Jugador**: Sacado del paquete de First Person de StarterAssets de Unity.

- **World Trade Center**: Se ha incluido un asset de un edificio del World Trade Center para dar un poco de ambientación al escenario.

> URL: https://sketchfab.com/3d-models/the-world-trade-center-fde04f65f5fc40308e05d44872ed7390

- **Scripts**:
  - `postion.cs`: Muestra la posición del objeto al que está asociado en la consola.
  - `movimiento.cs`: Controla el movimiento vertical del globo aerostático.

## Extra

- Se añadió movimiento en el eje Y al globo aerostático.

- Se añadió colisión al globo para que el jugador pueda subirse en él.

- Se incluyeron dos imágenes: un GIF que muestra el movimiento del globo y una captura del escenario.


### GIF del movimiento del globo:

![Movimiento del Globo](img/globo.gif)
En el GIF se puede ver un poco resumido lo que se ha hecho, a falta de la colisión del globo con el jugador.

### Captura del funcionamiento del script:

![Escenario](img/Captura%20de%20pantalla%202024-10-01%20053931.png)

Cabe destacar que el script de posición se puede ver funcionando correctamente en la consola en la imagen superior.