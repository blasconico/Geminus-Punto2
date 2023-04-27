using System;

namespace Geminus
{
    class Program
    {
        static int[] myArray = new int[] { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };
        const int numeroDeFilasColumnas = 4;
        static string[,] tabla = new string[numeroDeFilasColumnas, numeroDeFilasColumnas];
        static int actualPosicionHorizontal = 0;
        static int actualPosicionVertical = 0;

        static void Main(string[] args)
        {

            LimpiarTabla();

            for (int i = 0; i < myArray.Length; i++)
            {
                if ((i + 1) % 2 == 0)

                    MovimientoHorizontal(myArray[i]);
                else
                    MovimientoVertical(myArray[i]);

            }

            ImprimirTabla();
        }

        private static void MovimientoHorizontal(int h)
        {
            if ((actualPosicionHorizontal + h) > numeroDeFilasColumnas - 1 || (actualPosicionHorizontal + h) < 0)
                return;

            InicializarTabla();
            actualPosicionHorizontal += h;
            tabla[actualPosicionHorizontal, actualPosicionVertical] = "X";
        }

        private static void MovimientoVertical(int v)
        {
            if ((actualPosicionVertical + v) > numeroDeFilasColumnas - 1 || (actualPosicionVertical + v) < 0)
                return;
            InicializarTabla();
            actualPosicionVertical += v;
            tabla[actualPosicionHorizontal, actualPosicionVertical] = "X";
        }

        private static void InicializarTabla()
        {
            tabla[actualPosicionHorizontal, actualPosicionVertical] = "O";
        }

        private static void LimpiarTabla()
        {
            for (int i = tabla.GetLowerBound(0); i <= tabla.GetUpperBound(0); i++)
            {
                for (int j = tabla.GetLowerBound(1); j <= tabla.GetUpperBound(1); j++)
                {
                    tabla[i, j] = "O";
                }
            }
        }

        private static void ImprimirTabla()
        {
            for (int i = 0; i < numeroDeFilasColumnas; i++)
            {
                for (int j = 0; j < numeroDeFilasColumnas; j++)
                {
                    Console.Write(tabla[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
