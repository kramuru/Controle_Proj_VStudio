using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projec_control.Entities
{
    internal class Demand
    {
        private string Tipo;
        private string Number;
        private string Description;

        public Demand(string tipo, string number, string description)
        {
            Tipo = tipo;
            Number = number;
            Description = description;
        }


        public override string ToString()
        {
            return "\nDemanda : " +
            Tipo + " " + "No. da Demanda: " + Number + " " +
            "Descrição: " + Description;
        }

        public void CadastraDemanda(string path, string texto)
        {
            File.AppendAllText(path, texto);
            Menu menu = new Menu();
            Thread.Sleep(1000);
            Console.Clear();
            menu.Option();
        }



    }
}

