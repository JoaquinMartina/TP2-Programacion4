# TP2-Laboratorio de Computación 4
Trabajo Practico  .Net Core - EntityFramework - Auth y Roles (Alumnos)


- Se reañliza toda la funcionalidad posible (Faltarian encarar algunas como por ejemplo realizar inscripciones desde una vista)
- A modo de prueba realizo las inscripciones a nivel de BDD (y la app me trae la vista de las mismas):

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
 
