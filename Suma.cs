using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Suma
    {

        public int Sumar(int num1, int num2, int num3)      //Método que utiliza 3 datos ingresados del exterior para realizar una suma
        {
            return num1 + num2 + num3;
        }
        public int Sumar(int num1, int num2)                //Método que solo utiliza 2 de los parametros ingresados
        {
            return num1 + num2;
        }
        public int Sumar(int num1)              //Método que solo utiliza un parametro y lo suma con 100
        {
            return num1 + 100;
        }
        public int Sumar()              //Método que suma dos valores 5 y 10 los cuales son constantes
        {
            return 5 + 10;
        }



    }
}
