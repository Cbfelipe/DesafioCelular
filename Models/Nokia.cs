using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCelular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string mei, int memoria) : base (numero, modelo, mei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no Nokia!");
        }
    }
}
