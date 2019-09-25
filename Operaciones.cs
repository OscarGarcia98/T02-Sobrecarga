using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Operaciones
    {
        //Objetos que contienen las variables a utilizar así como los métodos que se necesitan para realizar la sobrecarga
        Valores v = new Valores();
        Suma suma = new Suma();
        
        public void operaciones()       //Método que permite ingresar valores y realizar sobrecarga de datos para mostrar distintas sumas
        {
           int res1, res2, res3, res4;      //En estas variables se guardarán los resultados de cada método
        Console.WriteLine("Ingrese un valor");
            v.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un valor");
            v.Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un valor");
            v.Num3 = Convert.ToInt32(Console.ReadLine());

            res1 = suma.Sumar(v.Num1, v.Num2, v.Num3);      //La primer suma se realizará con los 3 parametros ingresados por el usuario
            res2 = suma.Sumar(v.Num1, v.Num2);              //esta suma solo se hará con dos parametros
            res3 = suma.Sumar(v.Num1);                      //Suma que utilizará un parametro y una constante ya definida en el método
            res4 = suma.Sumar();                             //Suma de dos constantes ya definidas 
            //Todos estos métodos contienen el mismo nombre y son del mismo tipo pero con diferentes parametros que permiten obtener distintos resultados
            Console.WriteLine("Suma con 3 parametros ({0} + {1} + {2}) = {3}\nSuma con 2 parametros ({0} + {1}) = {4}" +
                "\nSuma con 1 parametros y una constante ({0} + 100 ) = {5}" +
                "\nSuma con 2 constantes (5 + 10) = {6}", v.Num1,v.Num2,v.Num3, res1,res2,res3, res4);      //Muestro el resultado de cada uno y termina el programa
            Console.ReadKey();

        }




    }
}
