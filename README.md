Información del proyecto, Este proyecto consiste en dos crud sencillos, simulando una Libreria con solo dos tablas. Autores y Libros

Solo FUNCIONA un crud (autores)

INFORMACIÓN ADICIONAL --- No se necesita descargar ningun paquete Nuget, solo se necesita tener una instancia de SQL server activa y funcional

EXPLICACIÓN DE USO: Al momento de abrir el proyecto, solo se necesita ir a la sección de appsettings y cambiar el nombre del servidor por el suyo...para cambiar la base de datos se puede hacer de igual forma por una que ustedes
deseen...puesto que este proyecto esta hecho para poder crear una base de datos de sql desde el propio proyecto. 

En este caso solo se necesita o si se desea cambiar la base de datos a crear solo tienen que ubicar esto en el appsettings (Database=LibreriaCRUD) por el nombre que ustedes deseen que tenga la base de datos.
Una vez hecho esto, necesitan crear la base de datos. Tienen que ir a *Herramientas*, *Administrador de paquetes nuget*, y finalmente hacer click en la *consola de administración de paquetes Nuget* y ejecutar el siguiente comando

Update-Database, esto creara automaticamente nustra base de datos en nuestro servidor de SQL server
