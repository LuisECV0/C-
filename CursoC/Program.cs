using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.- HOLA MUNDO*/

            Console.WriteLine("hola mundo");

            /*2.-VARIABLES Y CONSTANTES */

            int numeroEntero;
            numeroEntero = 0;
            double numeroDecimal;
            numeroDecimal = 10.5;
            Console.WriteLine(numeroEntero + numeroDecimal);
            
            String texto = "texto de prueba";
            Console.WriteLine(texto);

            const int CONSTANTE = 100;
          
            Console.WriteLine(CONSTANTE);

            /*3.-OPERADORES ARITMETICOS */
            // Suma
            int suma = 5 + 3;
            Console.WriteLine("Suma: " + suma);

            // Resta
            int resta = 10 - 4;
            Console.WriteLine("Resta: " + resta);

            // Multiplicación
            int multiplicacion = 7 * 6;
            Console.WriteLine("Multiplicación: " + multiplicacion);

            // División
            double division = 20 / 4.0; // Usa 4.0 para obtener un resultado decimal
            Console.WriteLine("División: " + division);

            // Módulo
            int modulo = 10 % 3;
            Console.WriteLine("Módulo: " + modulo);

            /*4.-CONDICIONALES(IF, ELSE, ELSE-IF) */
            int numero = 5;

            if (numero > 10)
            {
                Console.WriteLine("El número es mayor que 10");
            }
            else if (numero == 10)
            {
                Console.WriteLine("El número es igual a 10");
            }
            else
            {
                Console.WriteLine("El número es menor que 10");
            }

            /*5.-CONDICIONAL SWTCH - CASE */
            int dia = 3;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                default:
                    Console.WriteLine("Fin de semana");
                    break;
            }

            /*6.-METODOS */
            static void Saludar()
            {
                Console.WriteLine("¡Hola desde el método Saludar!");
            }

            // Llamar al método
            Saludar();

            static int Sumar(int a, int b)
            {
                return a + b;
            }

            // Llamar al método con parámetros
            int resultado = Sumar(5, 7);
            Console.WriteLine("La suma es: " + resultado);

            /*7.-BUCLE FOR */
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteración: " + i);
            }

            /*8.- BUCLE WHILE */
            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Contador: " + contador);
                contador++;
            }

            /*9.- BUCLE DO WHILE */
            int numeroDoWhile = 0;

            do
            {
                Console.WriteLine("Número en do-while: " + numeroDoWhile);
                numeroDoWhile++;
            } while (numeroDoWhile < 5);

            /*10.- ARRAYS */
            int[] numeros = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Elemento en el índice " + i + ": " + numeros[i]);
            }

            // Array de cadenas
            string[] frutas = { "Manzana", "Banana", "Cereza" };

            foreach (string fruta in frutas)
            {
                Console.WriteLine("Fruta: " + fruta);
            }

        }
    }
}
