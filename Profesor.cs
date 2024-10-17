using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp25
{
    internal class Profesor:Empleao
    {
        double sueldoProfe;

        public Profesor(int id,string nombre,string numeroS,int diasT)
            :base(id,nombre,numeroS,diasT)
        {
            sueldoProfe = 899.99;   
        }

        public double NominaNeta()
        {
            return sueldoProfe * DiasTrabajados;
        }

        public double NominaImpuesto()
        {
            return NominaNeta() * .90;
        }
    }
}
