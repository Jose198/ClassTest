using System;

namespace Clases_Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            UserClass user= new UserClass();
            user.name="Jose";
            user.course="Programacion";
            user.Id=1;

            user.UserInfo();

        }
    }
}
