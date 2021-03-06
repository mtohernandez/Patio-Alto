# Patio-Alto
Software para administradores de aeropuertos a escala pequeña capaz de agregar, modificar y eliminar tanto vuelos como pasajeros en un  aeropuerto, para el manejo de personas que entran y personas que salen del mismo. Al igual que  envié un mensaje de bienvenida vía email para todas las personas que entran, y uno de despedida  a las que se eliminan, es decir salen. Estará optimizado solo para los administradores del aeropuerto,  ellos tendrán el control de todos los vuelos, pasajeros y si se presenta el caso, reclamos.

## Estructura de datos
La forma de datos a usar será la de arboles binarios (B-Tree) para el rápido acceso de la data, SQL internamente guarda la data en “DataPages” que se guarda datos de 8KB de data donde se pueden encontrar las filas que contienen cada dato de la tabla o base de datos. Tienen 3 niveles que se pueden observar en la imagen: raíz, intermedio y hojas. Dependiendo cual sea la PRIMARY KEY que es el identificador de una fila, estos se encuentran ubicados en la raíz del árbol y dependiendo de cuantos datos tengamos (filas) tendremos mayores números de niveles intermedios. Un ejemplo para entender como funciona el B-Tree es si nos gustaría acceder al pasajero que tiene como ID 1003 automáticamente dependiendo del valor de la raíz si es menor a 1003 la búsqueda se empezara a hacer del lado derecho.


## Requerimientos Funcionales

Cada Form es independiente y cada uno compone una conexión a la base de datos que se abre cuando se realiza la consulta y se cierra al finalizar.

**Login:**

• Ingresar a la base de datos y verificar que los datos son correctos, es decir el usuario se encuentra registrado.

• Da acceso al Form de registro para crear un nuevo usuario

• Opción de salir del programa y cerrar todos los procesos.


**Registro:**

• Obtener username, contraseña, correo y edad del administrador que va a crear su nuevo usuario.

• Da lugar al Form anterior, login.


**DashBoard:**

La dashboard es el menú principal donde se pueden visualizar todos los vuelos y pasajeros que están registrados en el sistema.

• Visualizar vuelos y pasajeros

• Da lugar a los Forms agregar, modificar, eliminar tanto vuelos como pasajeros

• Abre Form de enviar reclamos.

• Cerrar la aplicación por completo

• Actualizar las visuales de la data tanto para vuelos como pasajeros

• Visualizar la hora actual


**Agregar Vuelos:**

• Se hace ingreso del ID, destino, origen, puestos disponibles (que será igual a la capacidad máxima del vuelo), hora de salida y estado del vuelo.

• El estado del vuelo puede ser DISPONIBLE o NO DISPONIBLE. Y es modificable.

• Permite conectar con la base de datos ingresar el vuelo y luego desconectar.

• Permite cancelar la operación y volver a la dashboard.


**Modificar Vuelos:**

• No permite modificar el ID del vuelo, pero si visualizarlo.

• No permite modificar el origen, pero si visualizarlo.

• Se puede cambiar el destino eligiendo de un conjunto de ciudades.

• El estado del vuelo se puede cambiar.

• La hora de salida también se puede modificar, como no hay día de salida se asume que si es menor será para el día siguiente.

• Muestra los puestos disponibles de la capacidad máxima del avión.

• Permite visualizar todos los vuelos que hay disponibles y actualizar cada vez que se hace una modificación.

• Permite cancelar la operación cerrando la pestaña y volviendo a la dashboard.

**Eliminar Vuelos:**

• No permite modificar ningún aspecto del vuelo, pero si deja visualizarlo para observar mejor los datos.

• Permite visualizar todos los vuelos para saber cuales son los que están disponibles, al igual actualizar al momento de hacer la eliminación del vuelo.

• Permite cancelar la operación cerrando la pestaña y volviendo a la dashboard.

**Agregar Pasajero:**

• Este Form tiene la capacidad de crear pasajeros que van a estar en el aeropuerto o que, si van a tomar un vuelo, en el segundo caso es obligatorio que se le asigne un Vuelo ID al pasajero para que conozca su vuelo.

• Permite visualizar los vuelos disponibles y llena el campo de Vuelo ID automáticamente.

• Se agrega el ID del pasajero

• No se permite agregar un vuelo ID ya que solo se pueden ingresar los que ya están registrados, al seleccionar con el mouse en la tabla se actualiza automáticamente.

• Se declara el estado del pasajero NORMAL o NEUTRO, el primero para una persona que va a tomar un vuelo, segundo para alguien que viene de visita.

• Datos como nombre, apellido, edad (solo mayores de 18) y correo electrónico.

• Permite cancelar la operación volviendo a la dashboard

**Modificar Pasajero:**

• No se permite modificar el ID, Vuelo ID o estado del pasajero.

• Se puede modificar el nombre, apellido, edad, correo electrónico.

• Permite visualizar los pasajeros registrados en la base de datos.

• Permite cancelar la operación y volver a la dashboard.

**Eliminar Pasajero:**

• No permite modificar ningún campo.

• Permite visualizar los pasajeros registrados.

• Llena automáticamente los datos para visualizarlos mejor.

• Permite cancelar la operación volviendo a la dashboard.


## Requerimientos Instruccionales

**Diseño del programa**

Cada cuadro representa un Form, el login como el registro se encuentran conectados se puede pasar del uno al otro las veces deseadas. Una vez registrado no se puede cerrar el login y se pasa directamente a la dashboard donde se puede visualizar la data o pasar a los otros Forms de agregar, modificar y eliminar tanto vuelos como usuarios. Los Forms de agregar y modificar, al igual el Form de reclamos se conectan a el servidor STMP de Gmail en un puerto especifico para enviar un correo a las personas que van ingresado o dejando la base de datos y los reclamos se enviar al correo de la empresa.


<img src="Patio%20Alto/map.png" width="500">

**General:**

En todos los Form se hace una regla y es que no se aceptan campos en blanco, si el administrador no selecciona un vuelo o pasajero no podrá agregarlo a la base de datos. No se permiten IDs o usuarios duplicados, el programa verifica cada que se ingresa un dato si ya esta en la base de datos.

**Vuelos:**

Los estados de los vuelos son importantes, cuando un vuelo se crea es recomendado agregarlo en DISPONIBLE para que todos los usuarios que se asignen a ese vuelo se creen en estado NORMAL, al momento de pasar al estado de vuelo NO DISPONIBLE, automáticamente se pasan todas las personas del vuelo a PENDIENTE y viceversa. Cada vez que se añade o elimina un pasajero se agrega o resta una unidad a la cantidad de puestos disponibles del vuelo, si llega a su máximo o a cero no se podrán agregar más pasajeros al vuelo.

**Pasajeros:**

Los pasajeros tienen cuatro estados: VPERDIDO, PENDIENTE, NORMAL y NEUTRO, VPERDIDO es cuando la persona estaba asociada a ese vuelo y el vuelo se elimina, PENDIENTE es cuando el vuelo pasa a NO DISPONIBLE, NORMAL cuando se añade normalmente y NEUTRO cuando solo vienen de visita al aeropuerto. Se envía un email cada que se añade un pasajero al sistema, se presentan errores cuando no se añada o se ingrese un email falso.

**Overall:**

El programa a sido comprobado en cada aspecto, sin embargo, hay algunos bugs, errores presentados: (a mejorar). No se hace siempre el llenado de los datos cuando se selecciona un pasajero o vuelo. Se pueden presentar errores externos con el servidor de GMAIL y no se lleguen a añadir las personas a la base de datos. Se puede acceder a los otros Form si se abren todos al mismo tiempo, lo cual puede resultar en perdida o no organización de datos,

**Implementación:**

Para lograr el funcionamiento se hizo uso de SSMS (sql server management studio) para la creación de la base de datos y las tablas, al igual el uso de las consultas. WinForms para la interfaz grafica y el acceso a las diferentes partes de la aplicación.

