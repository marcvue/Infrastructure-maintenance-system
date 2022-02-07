# Infrastructure-maintenance-system

Infrastructure maintenance system:
Entiendo que todos los servidores que tengo local se ejecutan en máquinas virtuales.
Clase “servidor”, con dos hijas: Application Server y Database Server. Tienen las propiedades comunes (Ram, cpu, bios, hd, controladores, IP).
Clase “infrastructure”, tiene la propiedad de ancho de banda consumido
Clases de servicio:
Processing Service, que tiene que llevar a cabo el escalado, llamar a los métodos de escalado vertical. Entiendo que al realizar este escalado, se reduce el número de servidores que no cumplen las validaciones, ya que pasan a cumplir las validaciones (es el mismo requerimiento, las constraints de validación son del 90% en el caso menos restrictivo, y en el apartado de procesamiento se pide escalarlo antes que esto.)
Interpreto que la IP apipa se controlaría haciendo un check sobre alguna propiedad de la IP (no sé lo que significa que sea apipa)
Verification Service, que hace chequeos sobre una lista de constraints decididos desde una capa superior (le llegan del motor Program)
Routing Service: Tiene una lista de servidores, en mi caso los inicializa él mismo y los devuelve al servicio de verificación y el de procesado.
ClientService, recoge una lista de requerimientos para los servicios de verificación y procesado y se los transmite. (esto no sé si se tiene que hacer mediante un servicio realmente)


// Se me ocurre tarde, pero creo que la idea para poder mandar requerimientos variables es, el servicio de cliente que hace un check del input del usuario, escribe un json que dice qué validación hay que hacer, y el servicio de validación ejecuta unas funciones u otras, con los valores especificados en el json.
