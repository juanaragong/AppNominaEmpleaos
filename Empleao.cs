using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp25
{
    internal class Empleao
    {
        public  int  Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroSeguro { get; set; }

        public  int  DiasTrabajados { get; set; }


        public Empleao(int id, string nombre, string numeroS, int diasT) 
        {
           Id = id;
           Nombre = nombre;
           NumeroSeguro = numeroS;
           DiasTrabajados = diasT;
        }

    }
}
