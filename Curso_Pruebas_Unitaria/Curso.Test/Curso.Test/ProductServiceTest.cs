using Curso.Registro;

namespace Curso.Test
{
    public class ProductServiceTest
    {
        [Fact]
        //Hace una prueba unitaria para verificar que el método GetProductsMinimaPrice de la
        //clase ProductService devuelve una lista de productos que cumplen con un precio mínimo especificado.
        public void GetProductsMinimaPrice_MinimalPrice30_ReturnOnProduct()
        {
            //Arrange: es una sección del patrón de prueba unitario que se utiliza para preparar el entorno de prueba
            //antes de ejecutar la acción que se va a probar. En esta sección, se crean los objetos necesarios,
            //se establecen los valores iniciales y se configuran las dependencias necesarias para la prueba.

            var service = new ProductService();
            var minimalPrice = 30;

            //Act: es una sección del patrón de prueba unitario que se utiliza para ejecutar la acción que se va a probar.

            var result = service.GetProductsMinimaPrice(minimalPrice).ToList();


            //Assert: es una sección del patrón de prueba unitario que se utiliza para verificar que el resultado de la acción

            //NotEmpty verifica que la colección no esté vacía, es decir,
            //que contenga al menos un elemento. Si la colección está vacía, la prueba fallará y se generará un error.
            Assert.NotEmpty(result);
        }

        //Hace una prueba unitaria para verificar que el método GetProductsMinimaPrice de la clase ProductService
        //devuelve una lista de productos que cumplen con un precio mínimo especificado.
        [Fact]
        public void GetProductsMinimaPrice_MinimalPrice30_ReturnsProductWithTop30()
        {
            //Arrange: es una sección del patrón de prueba unitario que se utiliza para preparar el entorno de prueba
            //antes de ejecutar la acción que se va a probar. En esta sección, se crean los objetos necesarios,
            //se establecen los valores iniciales y se configuran las dependencias necesarias para la prueba.

            var service = new ProductService();
            var minimalPrice = 30;

            //Act: es una sección del patrón de prueba unitario que se utiliza para ejecutar la acción que se va a probar.

            var result = service.GetProductsMinimaPrice(minimalPrice).ToList();


            //Assert: es una sección del patrón de prueba unitario que se utiliza para verificar que el resultado de la acción

            //All verifica que todos los elementos de la colección cumplan con una condición específica.
            Assert.All(result, p => Assert.True(p.price >= 30));
        }

        [Fact]
        //Hace una prueba unitaria para verificar que el método GetProductsMinimaPrice de la clase ProductService
        //no devuelve productos con un precio menor al precio mínimo especificado.
        public void GetProductsMinimaPrice_MinimalPrice30_DoesReturnsProductWith30()
        {
            //Arrange: es una sección del patrón de prueba unitario que se utiliza para preparar el entorno de prueba
            //antes de ejecutar la acción que se va a probar. En esta sección, se crean los objetos necesarios,
            //se establecen los valores iniciales y se configuran las dependencias necesarias para la prueba.

            var service = new ProductService();
            var minimalPrice = 30;

            //Act: es una sección del patrón de prueba unitario que se utiliza para ejecutar la acción que se va a probar.

            var result = service.GetProductsMinimaPrice(minimalPrice).ToList();


            //Assert: es una sección del patrón de prueba unitario que se utiliza para verificar que el resultado de la acción

            //DoesNotContain verifica que la colección no contenga ningún elemento que cumpla con una condición específica.
            Assert.DoesNotContain(result, p => p.price < 30);
        }


        [Fact]
        //Hace una prueba unitaria para verificar que el método GetProductsMinimaPrice de la clase ProductService
        //devuelve una lista vacía cuando se especifica un precio mínimo que no coincide con ningún producto.
        public void GetProductsMinimaPrice_MinimalPrice30_RetornaColeccionVacia()
        {
            //Arrange: es una sección del patrón de prueba unitario que se utiliza para preparar el entorno de prueba
            //antes de ejecutar la acción que se va a probar. En esta sección, se crean los objetos necesarios,
            //se establecen los valores iniciales y se configuran las dependencias necesarias para la prueba.

            var service = new ProductService();
            var minimalPrice = 30000m;

            //Act: es una sección del patrón de prueba unitario que se utiliza para ejecutar la acción que se va a probar.

            var result = service.GetProductsMinimaPrice(minimalPrice).ToList();


            //Assert: es una sección del patrón de prueba unitario que se utiliza para verificar que el resultado de la acción

            //Empty verifica que la colección esté vacía, es decir, que no contenga ningún elemento. Si la colección contiene
            Assert.Empty(result);
        }

        [Fact]
        //Hace una prueba unitaria para verificar que el método GetProductsMinimaPrice de la clase ProductService
        //devuelve todos los productos cuando se especifica un precio mínimo de 0.
        public void GetProductsMinimaPrice_MinimalPrice0_RetornaTodosLosProductos()
        {
            //Arrange: es una sección del patrón de prueba unitario que se utiliza para preparar el entorno de prueba
            //antes de ejecutar la acción que se va a probar. En esta sección, se crean los objetos necesarios,
            //se establecen los valores iniciales y se configuran las dependencias necesarias para la prueba.

            var service = new ProductService();
            var minimalPrice = 0m;

            //Act: es una sección del patrón de prueba unitario que se utiliza para ejecutar la acción que se va a probar.

            var result = service.GetProductsMinimaPrice(minimalPrice).ToList();


            //Assert: es una sección del patrón de prueba unitario que se utiliza para verificar que el resultado de la acción

            //Equal verifica que el valor esperado sea igual al valor real. Si los valores no son iguales, la prueba fallará y se generará un error.
            Assert.Equal(3, result.Count);
        }


        [Fact]

        public void GetProductsMinimaPrice_MinimalPrice0_RetornaProducto1and2()
        {
            //Arrange: es una sección del patrón de prueba unitario que se utiliza para preparar el entorno de prueba
            //antes de ejecutar la acción que se va a probar. En esta sección, se crean los objetos necesarios,
            //se establecen los valores iniciales y se configuran las dependencias necesarias para la prueba.

            var service = new ProductService();
            var minimalPrice = 20m;

            //Act: es una sección del patrón de prueba unitario que se utiliza para ejecutar la acción que se va a probar.

            var result = service.GetProductsMinimaPrice(minimalPrice).ToList();


            //Assert: es una sección del patrón de prueba unitario que se utiliza para verificar que el resultado de la acción

            //Collection verifica que la colección contenga los elementos esperados en el orden esperado.
            Assert.Collection(result,
                Product => 
                { 
                    Assert.Equal(2, Product.id);
                    Assert.Equal("Producto 2", Product.name);
                    Assert.Equal(20.0m, Product.price);
                },
                Product =>
                {
                    Assert.Equal(3, Product.id);
                    Assert.Equal("Producto 3", Product.name);
                    Assert.Equal(30.0m, Product.price);
                }
                );    
        }


    }
}
