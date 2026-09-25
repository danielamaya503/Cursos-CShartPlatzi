using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Registro
{
    //record es una clase inmutable que se utiliza para representar datos.
    // Se utiliza principalmente para crear objetos que no se pueden modificar después de su creación.
    public record class Product(int id, string name, decimal price);
    
}
