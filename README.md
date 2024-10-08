# MVCProductsT1 - Sistema CRUD con Autenticación

Este proyecto es una aplicación ASP.NET Core MVC que implementa un sistema CRUD (Crear, Leer, Actualizar, Eliminar) para la gestión de productos. 
Además, incluye un sistema de autenticación con cookies que requiere que los usuarios inicien sesión para acceder a las funcionalidades del CRUD.

## Características

- **CRUD de Productos**: Permite crear, leer, actualizar y eliminar productos.
- **Autenticación**: Utiliza autenticación con cookies. Los usuarios deben iniciar sesión para acceder al CRUD.
- **Autorización**: Protege las rutas del CRUD para que solo usuarios autenticados puedan acceder.
- **Logout**: Los usuarios pueden cerrar sesión a través de un enlace en la interfaz.

## Tecnologías utilizadas

- **ASP.NET Core MVC**
- **Razor Views**
- **Bootstrap** (para el diseño de la interfaz)
- **Autenticación con cookies** (Microsoft.AspNetCore.Authentication.Cookies)

## Configuración del proyecto

### 1. Requisitos previos

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 o superior)
- Un IDE compatible, como [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/).

### 2. Clonar el repositorio

Clona este repositorio en tu máquina local:

```bash

