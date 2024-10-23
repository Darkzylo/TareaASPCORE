- generé el proyecto asp.net core mvc
- en modelos agregué las clases necesarias para el sistema de bienestar(básico)
- en dependencias, agregué lo necesario para estar entity y BBDD, que es entity framework core, entity framework core sql server y diagnostics (aunque creo que no es necesario este último para el proyecto actual).
- generé la carpeta Data y generé un contexto basado en mis clases creadas en el modelo.
- agregué en program el context
- en Conectes services agregué la BBDD express.
- agregué el string de conexión en el Json con el nombre que quería de bbdd
- ejecuté el proyecto para que genere la bbdd
- agreguo un controlador de afiliados, pero con entity, seleccionando el modelo y el context.
- en el layout se agregó el acceso al index de afiliados, apuntado al controles y action correspondiente.
- modifiqué un poco el crear y editar para que se puedan ver los enum.
-  modifiqué el select al crear una solicitud beneficio, ya que me faltaba ingresar el ID del afiliado, también en en el bind del crear se agrega el campo nuevo.

Existen tanto el mantenedor de afiliado como de solicitud beneficio, al crear una solicitud de beneficio se valida que el monto sea entre cero y 200.000

Se usan modificadores en el modelo de tipo enum tipoAfiliado, son visibles al crear o editar un afiliado.

Se usa Crud para afiliado.

