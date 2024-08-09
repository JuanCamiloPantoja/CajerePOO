using System;

namespace CajereLynx
{
    public class CajereLynx
    {
        public decimal _balance = 1000.00m;
        public string _username = "admin";
        public string _password = "1234";

        public void Run()
        {
            Console.WriteLine("Bienvenido al Cajero Automático");
            if (Login())
            {
                Console.WriteLine("Inicio de sesión exitoso");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }
        public bool Login()
        {
            Console.Write("Ingrese su usuario: ");
            string username = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();
            return username == _username && password == _password;
        }

    }
}