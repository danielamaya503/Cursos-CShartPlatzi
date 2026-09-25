using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Registro
{
    public class ProductService
    {
        //readonly es un modificador de acceso que indica que el campo solo puede ser asignado en el constructor de
        //la clase o en la declaración del campo. Esto significa que una vez
        ///que se asigna un valor a un campo readonly, no se puede cambiar durante la vida útil del objeto.
        private readonly List<Product> products = new()
        {
            new Product(1, "Producto 1", 10.0m),
            new Product(2, "Producto 2", 20.0m),
            new Product(3, "Producto 3", 30.0m),
        };

        public IEnumerable<Product> GetProductsMinimaPrice(decimal price)
        {
            return products.Where(p => p.price >= price);
        }
    }
}
