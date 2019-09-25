using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Valores
    {

        //Encapsulación de las variables que guardarán los valores ingresados por el usario.
        private int num1, num2, num3;
       
        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public int Num3
        {
            get { return num3; }
            set { num3 = value; }
        }




    }
}
