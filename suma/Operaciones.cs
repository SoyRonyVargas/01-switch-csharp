using System;
namespace suma
{
	public class Operaciones
	{
        static int max_suma_numeros = 5;

        static double MXN = 19.34;

        private double IVA = 0.16;

        public void Clear()
        {
            Console.Clear();
        }

        public void AreaTriangulo()
        {

            Console.WriteLine("Programa de area a un triangulo \n");

            Console.WriteLine("Dame la base \n");

            double _base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame la altura \n");

            double altura = Convert.ToDouble(Console.ReadLine());

            double area = (_base * altura) / 2;

            Console.WriteLine("Area = " + area.ToString("0.00"));

        }

        public void IVACompra()
        {

            Console.WriteLine("Programa de calculo IVA a compra \n");

            Console.WriteLine("Dame el total de la compra \n");

            double total = Convert.ToDouble(Console.ReadLine());

            double iva = total * IVA;

            Console.WriteLine("IVA (" + this.IVA + ") = " + iva.ToString("0.00") + " \n");

        }

        public void DolarAPeso()
        {

            Console.WriteLine("Programa de cambio de dolares a pesos \n");

            Console.WriteLine("Dame el numero de dolares \n");

            double dolares = Convert.ToDouble(Console.ReadLine());

            double total = dolares * MXN;

            Console.WriteLine("Total pesos: $" + total.ToString("0.00") );

        }

        public void RestarNumerosUI()
        {

            Console.WriteLine("Programa de resta de numeros");

            Console.WriteLine("Dame el numero 1 \n");

            int numero_1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el numero 2 \n");

            int numero_2 = int.Parse(Console.ReadLine());

            float resta = this.RestarNumeros(numero_1, numero_2);

            Console.WriteLine(numero_1 + " - " + numero_2 + " = " + resta + " \n");

        }

        public void SumarNumeros()
        {

            int[] array_numeros = new int[max_suma_numeros];

            int i = 0;

            Console.WriteLine("Programa de suma de numeros");

            while (i < max_suma_numeros)
            {
                int n = i + 1;
                Console.WriteLine("Dame el numero " + n + " \n");
                int numero = int.Parse(Console.ReadLine());
                array_numeros[i] = numero;
                i++;
            }

            float suma = this.SumarTodosNumeros(array_numeros);

            Console.WriteLine("La suma de los 5 numeros es " + suma + " \n");

        }

        private float SumarTodosNumeros(int[] arreglo)
        {

            float suma = 0;

            for (int i = 0; i < max_suma_numeros; i++)
            {
                suma = suma + arreglo[i];
            }

            return suma;

        }

        private float RestarNumeros(int n1, int n2)
        {
            return n1 - n2;
        }

    }
}

