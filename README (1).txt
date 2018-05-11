Author: 44660014V - Adrián González Barbosa - agbarbosa
Title: Whack-AR-Mole

Integración de un juego clásico con nuevas tecnologías como Realidad Mixta e IoT.

Modo de empleo:

- El jugador se pondrá unas HoloLens, pondrá el marcador en donde quiera jugar y mediante el martillo impreso en 3D y una mata especial hecha con un arduino que capturará los golpes y los traducirá a pulsaciones de las teclas "ASZX" se podrá jugar.
La interfaz se ha diseñado para ser lo más flexible posible, integrada en la propia realidad aumentada y dejando a cada plataforma manejar la entrada y salida del juego. Las reglas son simples, golpea un topo cuando está y se gana un punto, se golpea cuando no está y se pierde una vida.



Notas:

- Se ha realizado una compilación para Android, al ser la única opción viable para poder ser corregido.
- En caso de querer probarse desde un PC, se puede importar el proyecto en Unity 2017.3.0f3 con el componente Vuforia (aparece en el listado de componentes al instalarse).
- Se han omitido opciones de Realidad Mixta ya que se presume que el corrector no tendrá acceso a los medios para probarlo, en caso de que no sea así, por favor informe.
- El juego soporta 2 modos de control, pulsando sobre la imagen o con las teclas "ASZX", una para cada topo. En caso de quedarse sin vidas, pulsar cualquier botón reiniciará el juego.
- Debido a mis poquisimas habilidades de diseño y modelación en 3D he decidido utilizar un topo ya modelado, en el proyecto queda igualmente adjunto el modelo que utilicé durante el desarrollo.

Marcador:

- Se adjunta el archivo marcador.jpg que será lo que utilice el juego como centro de su mundo, si no se quiere gastar en tinta, se ha comprobado que con el móvil, abriendo la imagen a pantalla completa el juego lo reconoce.