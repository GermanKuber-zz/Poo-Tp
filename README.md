# Tp de Poo -  Asp.net Core

#### Instalar Ambiente de desarrollo
 
Descargar el Runtime en caso de solo correr la app, o el sdk en caso de querer desarrollar del siguiente link:

https://www.microsoft.com/net/download/macos

#### Crear nuevo proyecto

Los siguientes comandos deben ser ejecutados desde la linea de comando (Consola)

Crear una aplicación **Asp.net Core MVC**

``` dotnet new mvc ```

Restaurar los package (los paquetes nuget)

```dotnet restore```

Ejecutar la aplicación

```dotnet run```

Luego de ejecutar la aplicación podemos ver que en la consola se muestra la url en la cual esta corriendo nuestra app ademas del puerto.

![alt text](https://github.com/GermanKuber/Poo-Tp/blob/master/Images/01.%20DotNet%20Run.png?raw=true "")


Cargamos la siguiente URL en nuestro Browser para acceder a nuestro aplicación MVP.

```http://localhost:5000/```

Y veremos una página como la siguiente:

![alt text](https://github.com/GermanKuber/Poo-Tp/blob/master/Images/02.%20Preview%20MVC.png?raw=true "")

### Agregar comportamiento

En la carpeta Models creamos una clase llamada **TpViewModel.cs**

```csharp
using System;

namespace src.Models
{
    public class TpViewModel
    {
        public string Group { get; set; }
        public DateTime Date { get; set; }
        public int MembersQuantity { get; set; }

    }
}
```