using Curso.Registro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Test
{
    public class CustomerNameServiceTest
    {
        [Fact]
        public void GetDisplayName_ValidNames_ReturnsFullName()
        {
            //Arrange
            var service = new CustumerNameService();
            var firstName = "John";
            var lastName = "Doe";

            //Act
            var result = service.GetDisplayName(firstName, lastName);

            //Assert
            Assert.Equal("John Doe", result);
        }

        [Fact]
        public void GetDisplayName_EspaciosExtras_ReturnsFullName()
        {
            //Arrange
            var service = new CustumerNameService();
            var firstName = "John ";
            var lastName = " Doe ";

            //Act
            var result = service.GetDisplayName(firstName, lastName);

            //Assert
            Assert.Equal("John Doe", result);
        }

        [Fact]
        public void GetDisplayName_RetornaPrimeroNombreYApellido()
        {
            //Arrange
            var service = new CustumerNameService();
            var firstName = "John";
            var lastName = "Doe";

            //Act
            var result = service.GetDisplayName(firstName, lastName);

            //Assert
            Assert.StartsWith("John", result);
            Assert.EndsWith("Doe", result);
        }

        [Fact]
        public void GetDisplayName_RetornaContansSpaceBetweenFirstNameAndLastName()
        {
            //Arrange
            var service = new CustumerNameService();
            var firstName = "John";
            var lastName = "Doe";

            //Act
            var result = service.GetDisplayName(firstName, lastName);

            //Assert
            Assert.Contains(" ", result);
        }

        [Fact]
        public void GetDisplayName_RetornaIniciales()
        {
            //Arrange
            var service = new CustumerNameService();
            var firstName = "John";
            var lastName = "Doe";

            //Act
            var result = service.GetInicials(firstName, lastName);

            //Assert
            Assert.Equal("J.D", result);
        }

        //Theory es una característica de xUnit que permite ejecutar un mismo método de prueba
        //con diferentes conjuntos de datos.
        [Theory]
        [InlineData("John", "")]
        [InlineData("", "Doe")]
        [InlineData("", "")]

        public void GetDisplayName_RetornaNull(string firstName, string lastName)
        {
            //Arrange
            var service = new CustumerNameService();

            //Act
            var initials = service.GetInicials(firstName, lastName);

            //Assert
            //Null es un valor que indica que no hay ningún objeto asignado a una variable.
            //En este caso, se espera que el resultado sea nulo porque el apellido está vacío.
            Assert.Null(initials);
        }


        [Fact]
        public void IsValidName_RetornaTrue()
        {
            //Arrange
            var service = new CustumerNameService();

            var name = "John Doe"; 
            //Act
            var isValid = service.IsValidName(name);

            //Assert
            Assert.True(isValid);
        }


        [Theory]
        [InlineData("John")]
        [InlineData("")]
        [InlineData("  ")]
        [InlineData(" ")]
        [InlineData(null)]
        public void IsValidName_RetornaFalse(string? name)
        {
            //Arrange
            var service = new CustumerNameService();

            //Act
            var isValid = service.IsValidName(name!);

            //Assert
            //Null es un valor que indica que no hay ningún objeto asignado a una variable.
            //En este caso, se espera que el resultado sea nulo porque el apellido está vacío.
            Assert.False(isValid);
        }

    }
}
