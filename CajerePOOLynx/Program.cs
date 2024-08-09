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
    }
}