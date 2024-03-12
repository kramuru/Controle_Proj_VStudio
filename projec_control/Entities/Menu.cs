
using System;
using projec_control.Entities;
namespace projec_control
{
    internal class Menu
    {
        string path = @"C:\Users\bscd\Documents\";
        
        public void Option()
        {
            System.Console.WriteLine(@"
█▀█ █▀█ █▀█ ░░█ █▀▀ █▀▀ ▀█▀   █▀▀ █▀█ █▄░█ ▀█▀ █▀█ █▀█ █░░
█▀▀ █▀▄ █▄█ █▄█ ██▄ █▄▄ ░█░   █▄▄ █▄█ █░▀█ ░█░ █▀▄ █▄█ █▄▄");
            System.Console.WriteLine("\n1. Cadastrar Projeto");
            System.Console.WriteLine("2. Cadastrar Solicitações");
            System.Console.WriteLine("3. Consultar Solicitações");
            System.Console.WriteLine("4. Sair");
            Console.WriteLine("\r");
            Console.WriteLine("\nLista de Projetos\r");
            string[] directory = Directory.GetDirectories(path);
            
            if (directory.Length > 0)
            {
                int n = path.Count();
                foreach (string dir in directory)
                {
                    Console.WriteLine(dir.Substring(n) + "\r");
                }
            }
            System.Console.Write("\nDigite uma opção válida (1 - 4): ");
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

