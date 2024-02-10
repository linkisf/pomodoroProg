using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro.Domain.Ciclos
{
    public class CicloUmaHora
    {
        public int IdCiclo { get; set; }
        public bool Primeiro25 { get; set; }
        public bool Primeiro5 { get; set; }
        public bool Segundo25 { get; set; }
        public bool Segundo5 { get; set; }

        public CicloUmaHora(int idCiclo)
        {
            IdCiclo = idCiclo;
            Primeiro25 = false;
            Primeiro5 = false;
            Segundo25 = false;
            Segundo5 = false;
        }

        public int TempoCiclo()
        {
            if (!Primeiro25)
                return 1;
            else if (!Primeiro5)
                return 1;
            else if (!Segundo25)
                return 1;
            else if (!Segundo5) 
                return 1;

            return 0;
        }
    }
}
