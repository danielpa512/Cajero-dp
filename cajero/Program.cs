using System;

namespace ATM
{
    class Program
    {
        private static string username = "admin";
        private static string password = "1234";
        private static decimal saldo = 1000.00m;

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Cajero Automático");

            if (Login())
            {
                Console.WriteLine("Inicio de sesión exitoso");
                // Aquí se pueden llamar las funciones de depósito, retiro, consulta de saldo y transferencia
                // Ejemplo:
                Depositar();
                Retirar();
                ConsultarSaldo();
                Transferir();
            }
            else
            {
                Console.WriteLine("Inicio de sesión fallido");
            }
        }
        static bool Login()
        {
            Console.Write("Ingrese su usuario : ");
            string inputUsername = Console.ReadLine();
            Console.Write("Ingrese su contraseña:: ");
            string inputPassword = Console.ReadLine();
            return inputUsername == username && inputPassword == password;
        }
        static void Depositar()
        {
            Console.Write("Ingrese la cantidad a depositar: ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());
            saldo += cantidad;
            Console.WriteLine($"Has depositado {cantidad:C}. Tu saldo actual es {saldo:C}.");
        }
        static void Retirar()
        {
            Console.Write("Ingrese la cantidad a retirar: ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine($"Has retirado {cantidad:C}. Tu saldo actual es {saldo:C}.");
            }
            else
            {
                Console.WriteLine("Saldo insuficientes .");
            }
        }
        static void ConsultarSaldo()
        {
            Console.WriteLine($"Tu saldo actual es {saldo:C}.");
        }
        static void Transferir()
        {
            Console.Write("Ingrese la cantidad a transferir: ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ingrese el número de cuenta destinatario: ");
            string cuentaDestinatario = Console.ReadLine();
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                Console.WriteLine($"Has transferido {cantidad:C} a la cuenta {cuentaDestinatario}. Tu saldo actual es {saldo:C}.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}