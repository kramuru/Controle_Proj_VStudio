
using System;
using projec_control.Entities;
namespace projec_control
{
    internal class Menu
    {
        public void Option()
        {
            System.Console.WriteLine(@"
█▀█ █▀█ █▀█ ░░█ █▀▀ █▀▀ ▀█▀   █▀▀ █▀█ █▄░█ ▀█▀ █▀█ █▀█ █░░
█▀▀ █▀▄ █▄█ █▄█ ██▄ █▄▄ ░█░   █▄▄ █▄█ █░▀█ ░█░ █▀▄ █▄█ █▄▄");
            System.Console.WriteLine("\n1. Cadastrar Projeto");
            System.Console.WriteLine("2. Cadastrar Solicitações");
            System.Console.WriteLine("3. Consultar Solicitações");
            System.Console.WriteLine("4. Sair");
            System.Console.Write("Digite uma opção válida: ");
            int option = int.Parse(Console.ReadLine()!);
            Register register = new Register();
            switch (option)
            {
                case 1: //Register register = new Register();
                    register.Cadastro();
                    break;
                case 2: //Register register1 = new Register();
                    register.RegistraDemanda();
                    break;
                case 3:
                    register.ConsultaRegistros();
                    break;
                case 4:
                    System.Console.WriteLine("Até breve.");
                    break;
                default:
                    break;
            }

        }
    }
}

