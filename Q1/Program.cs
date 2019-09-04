using System;

namespace C__Development_and_Studies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int numero = 5;
            int resultado;

            resultado = Calcular(numero);

            Console.WriteLine("Resultado: {0}",resultado);
            Console.ReadKey();
        }

        static int Calcular (int numero){
            int resultado = new int();
            if (numero<=0){
                return 1;
            }else{
                //resultado = numero * Calcular(numero-1);
                for (int cont=numero;cont>0;cont--){
                    resultado+=numero*numero-1;
                }
                return resultado;
            }
        }
    }
}
