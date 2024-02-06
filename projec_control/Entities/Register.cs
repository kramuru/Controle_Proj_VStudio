using System;


namespace projec_control.Entities
{
    internal class Register
    {
    
    public void Cadastro()
        {
            System.Console.Write("Entre com o ID do projeto: ");
            string id = Console.ReadLine()!;
            Directory.CreateDirectory(@"C:\Users\bscd\Documents" + id);
            string path = @"C:\Users\bscd\Documents" + id + "/" + id + ".txt";
            System.Console.WriteLine("Entre com o nome do projeto: ");
            string name = Console.ReadLine()!;
            //using(StreamWriter sw = new StreamWriter(path,true)){
            //sw.WriteLine(name);
            File.AppendAllText(path, name + "\r");
            Thread.Sleep(1000);
            Console.Clear();
            Menu menu = new Menu();
        }

        public void RegistraDemanda()
        {
            Demand demanda;
            System.Console.Write("Informe o Projeto para qual vai cadastrar a solicitação: ");
            string id = Console.ReadLine()!.ToUpper();
            string path = @"C:\Users\bscd\Documents" + id + "/" + id + ".txt";
            if (File.Exists(path))
            {
                System.Console.Write("Informe o tipo da solicitação(SNOW,GM, NS, OM, CHG): ");
                string tipo = Console.ReadLine()!.ToUpper();
                System.Console.Write("Informe o número da solicitação: ");
                string sId = Console.ReadLine()!.ToUpper();
                System.Console.Write("Informe o objeto da solicitação: ");
                string objeto = Console.ReadLine()!.ToUpper();
                demanda = new Demand(tipo, sId, objeto);
                System.Console.WriteLine(demanda);
                demanda.CadastraDemanda(path, demanda.ToString());
               

            }
            else
            {
                System.Console.WriteLine("Projeto não existe, use a opção 1 para cadastro");
                Thread.Sleep(2000);
                Console.Clear();
                Menu option = new Menu();
                option.Option();


            }
        }

        public void ConsultaRegistros()
        {
            System.Console.Write("Informe o projeto para pesquisa: ");
            string id = Console.ReadLine()!.ToUpper();
            string path = @"C:\Users\bscd\Documents" + id + "/" + id + ".txt";
            if (File.Exists(path))
            {
                System.Console.Write("Informe o tipo da solicitação(SNOW,GM, NS, OM, CHG): ");
                string tipo = Console.ReadLine()!.ToUpper();
                foreach (string line in File.ReadAllLines(path))
                {
                    if (line.Contains(tipo))
                    {
                        System.Console.WriteLine(line);

                    }

                }
                Console.ReadKey();
                Console.Clear();
                Menu option = new Menu();
                option.Option();
            }
            else
            {
                System.Console.WriteLine("Projeto não existe, use a opção 1 para cadastro");
                Thread.Sleep(2000);
                Console.Clear();
                Menu option = new Menu();
                option.Option();
            }





        }
    }
}
