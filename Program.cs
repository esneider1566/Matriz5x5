//Nombre del estudiante: Heiler Esneider Martinez Aguilar
//Grupo: 213022_195
//Programa: Ingenieria de sistemas
//Código Fuente: autoría propia
//17/04/2024




using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];
        int suma = 0;
        int contador = 0;
        double numero = 0;

        Console.WriteLine("Este programa almacena en una matriz de 5×5 25 números que se encuentren entre el rango de 10 a 90. ");
        Console.WriteLine();

        Console.WriteLine("Luego establece cuál es la suma y el promedio de las celdas que componen el borde de la matriz (perímetro). ");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                bool entradaValida = false;

                do
                {
                    Console.Write($"Por favor, introduzca el número para la posición [{i},{j}] (entre 10 y 90): ");
                    Console.Write(" ");

                    try
                    {
                        numero = Convert.ToDouble(Console.ReadLine());

                        if (numero < 10 || numero > 90)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Debe digitar un número entre 10 y 90. ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Si el numero es decimal debe ir separado por coma (,). ");
                            Console.WriteLine();
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error de formato: Por favor ingrese un valor válido");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Error de desbordamiento: Por favor ingrese un valor válido ");
                    }

                } while (!entradaValida);

                matriz[i, j] = (int)numero;

                // Si estamos en el borde de la matriz, sumamos el número a la suma y aumentamos el contador
                if (i == 0 || i == 4 || j == 0 || j == 4)
                {
                    suma += matriz[i, j];
                    contador++;
                }
            }
        }

        double promedio = (double)suma / contador;

        Console.WriteLine("\nMatriz:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"{matriz[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSuma del borde de la matriz: {suma}");
        Console.WriteLine($"Promedio del borde de la matriz: {promedio:F2}");

        Console.WriteLine("Programa finalizado exitosamente ");
        Console.WriteLine(" ");
        Console.WriteLine("Presione la tecla Enter para continuar ");

        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }

}

