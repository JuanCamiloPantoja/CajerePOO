using System;

namespace CajereLynx
{
    public class CajereLynx
    {
        static void Main(string[] args)
        {
            CajereLynx atm = new CajereLynx();
            atm.Run();
        }
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
        public void MainMenu()
        {
            Console.WriteLine("Menú principal:");
            Console.WriteLine("1. Retirar dinero");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Salir");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Withdraw();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    CheckBalance();
                    break;
                case 4:
                    Transfer();
                    break;
                case 5:
                    Console.WriteLine("Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
        private void Withdraw()
        {
            Console.Write("Ingrese la cantidad a retirar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            if (amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Has retirado {amount:C}.");
            }
            else
            {
                Console.WriteLine("No tienes suficiente saldo");
            }
        }
        public void Deposit()
        {
            Console.Write("Ingrese la cantidad a depositar: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            _balance += amount;
            Console.WriteLine($"Has depositado {amount:C}.");
        }
        private void CheckBalance()
        {
            Console.WriteLine($"Tu saldo actual es {_balance:C}.");
        }
        private void Transfer()
        {
            Console.Write("Ingrese la cantidad a transferir: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de cuenta destinatario: ");
            string accountNumber = Console.ReadLine();
            if (amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Has transferido {amount:C} a la cuenta {accountNumber}.");
            }
            else
            {
                Console.WriteLine("No tienes suficiente saldo");
            }
        }
    }
}
    }
}