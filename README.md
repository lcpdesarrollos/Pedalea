# Pedalea
Aqui encontrara las instrucciones para ejecutar el proyecto "Pedalea"

1. Crear una carpeta en el disco "C" con el nombre "DataBases" y ejecutar el script "Script 01. Crear base de datos pedalea" que se encuentra en la carpeta Scripts dentro del proyecto Pedalea
2. Ejecutar el script "Script 02. Create user PedaleaUser and add for login" que se encuentra en la carpeta en la carpeta Scripts dentro del proyecto Pedalea
3. Cambiar el nombre del servidor de base de datos en "PedaleaConnection" del archivo appsettings.json
4. Ejecutar el script "Script 03. Table and Procedures Product" para crear la tabla y los procedimientos almacenados relacionados con los productos
5. Ejecutar el proyecto "Pedalea.API" y despues el proyecto "Pedalea.Web"
Nota: se debe cambiar la url base de la api en el archivo "appsettings.json" en el proyecto web que esta dentro de "wwwroot", el valor a cambiar es del key "BaseUrlPedaleaApi"