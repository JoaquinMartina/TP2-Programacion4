# TP2-Programación 4
Trabajo Practico  .Net Core - EntityFramework - Auth y Roles (Alumnos)


- Se realiza toda la funcionalidad posible (Faltarian encarar algunas como por ejemplo realizar edición y eliminación de una inscripción - para esto creo que es necesario una nueva tabla con PK unica)
- A modo de prueba realizo altas de inscripciones a nivel de BDD y App y la eliminación y edición desde la BDD y se refleja correctamente en la vista

- Se incluye logica y vistas con Identidad de Usuario y Roles

- Esta realizado en Visual Studio 2017, para poder ejecutar la aplicacion, se deben instalar los paquetes NuGet necesarios pero en versiones anteriores a 3.0 :
   - EntityFrameworkCore
   - EntityFrameworkCore.SqlServer
   - EntityFrameworkCore.Tools
   - AspNetCore.Identity.UI
   
- Levantar proyecto:
   
  Desde consola:
  - add-migration nombreMigracion (Correr migraciones de modelos)
  - update-database (construir Base de datos con respectivas tablas)
  
  - Compilar y Ejecutar
 
