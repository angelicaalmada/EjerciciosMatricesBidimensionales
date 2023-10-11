using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatricesBidimensionales
{
    public class MatricesBidimensionales
    {
        public void ejercicio1()
        {
            int[,] numero = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                Console.WriteLine($"elementos de la fila {i}");
                for (int x = 0; x < numero.GetLength(1); x++)
                {
                    Console.WriteLine(numero[i, x] + " ");
                }
                Console.WriteLine();
            }

        }

        public void ejercicio2()
        {
            string[,] colores = new string[,] { { "rojo", "Verde" }, { "Azul", "Amarillo" } };
            for (int i = 0; i < colores.GetLength(0); i++)
            {
                Console.WriteLine($"colores de la fila {i}");
                for (int x = 0; x < colores.GetLength(1); x++)
                {
                    Console.WriteLine(colores[i, x] + " ");
                }
                Console.WriteLine();

            }
        }



        //-------------------------------------------------------------------------------------------------
        public void ejercicio3()
        {
            double[,] decimales = new double[,] { { 1.2, 2.5, 1.3 }, { 2.5, 1.8, 3.2 }, { 1.3, 2.5, 1.2 }, { 1.4, 2.6, 1.8 } };
            double suma = 0;
            for (int i = 0; i < decimales.GetLength(0); i++)
            {
                for (int x = 0; x < decimales.GetLength(1); x++)
                {
                    suma = suma + decimales[i, x];
                    Console.WriteLine($"los num son {decimales[i, x]}");
                }

            }

            Console.WriteLine("la suma de los decimales es " + suma);
        }




        //---------------------------------------------------------------------------------------------

        public void ejercicio4()
        {
            char[,] caracteres = new char[,] { {'A', 'B', 'C', 'D'}, {'E', 'F', 'G', 'H'} };
            for (int i = 0; i<caracteres.GetLength(0); i++)
            {
                for(int x = 0; x<caracteres.GetLength(1); x++)
                {
                    Console.Write(caracteres[i,x] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
