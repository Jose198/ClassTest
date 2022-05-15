using System;
namespace Clases_Pruebas
{
    public class UserClass
    {
        public string name;
        public string course;
        public int Id;

        public  void UserInfo(){
            Console.WriteLine(name +" "+ course +" "+ Id);
            return;
        }

    }
}