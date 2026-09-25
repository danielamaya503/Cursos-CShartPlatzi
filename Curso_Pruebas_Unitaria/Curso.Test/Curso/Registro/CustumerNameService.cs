using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Registro
{
    public class CustumerNameService
    {
        public string GetDisplayName(string firstName, string lastName)
        {
            firstName = firstName.Trim();
            lastName = lastName.Trim();

            return $"{firstName} {lastName}";
        }

        public string GetInicials(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                return null!;

            //Tomar la primera letra del nombre y del apellido, convertirlas a mayúsculas y devolverlas en el formato "F.L."
            char firstInitial = char.ToUpper(firstName.Trim()[0]);
            char lastInitial = char.ToUpper(lastName.Trim()[0]);

            return $"{firstInitial}.{lastInitial}";
        }

        public bool IsValidName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return false;

            fullName = fullName.Trim();

            //Temga al menos un espacio en blanco entre el nombre y el apellido
            return fullName.Contains(" ");
        }
    }
}
