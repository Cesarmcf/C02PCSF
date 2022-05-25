using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_RegistoDetalhesCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            carro.MostrarMenuGeral();
            carro.LerMenuGeral();

            bool showmenu = true;

            do
            {
                carro.MostrarMenuGeral();
                carro.LerMenuGeral();
                showmenu = carro.DecidirMenu();
            } while (showmenu);

            /*
            while (showmenu)
            {
                showmenu = carro.DecidirMenu();

            }
            */
            
        }
    }
}
