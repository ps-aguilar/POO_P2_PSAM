using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2_PSAM
{
    internal class Operacion
    {
        private int num1;
        private int num2;

        //Constructor

        public Operacion(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Comportamiento

        public int Suma()
        {
            return num1 + num2;
        }

        public int Resta()
        {
            return num1 - num2;
        }

        public int Multiplicacion()
        {
            return num1 * num2;
        }

        public float Division()
        {
            return (num1 / (float)num2);
        }
    }
}
