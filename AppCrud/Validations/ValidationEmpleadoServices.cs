using AppCrud.Models;

namespace AppCrud.Validations
{
    public  static class ValidationEmpleadoServices
    {
        public const string const1 = "prueba";
       public static bool ValidateCreate(this Empleado empleado)
        {
            if (empleado == null)
            {
                return false;
            }
            if (string.IsNullOrEmpty(empleado.NombreCompleto))
            {
                return false;
            }
            return true;


        }
    }
}
