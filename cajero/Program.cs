﻿using System;

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
        static void Depositar()
        {
            Console.Write("Ingrese la cantidad a depositar: ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());
            saldo += cantidad;
            Console.WriteLine($"Has depositado {cantidad:C}. Tu saldo actual es {saldo:C}.");
        }