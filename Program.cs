using System;

namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double AreaX = 60;
            double AreaY = 60;
            double AreaZ = 60;

            if (AreaX == AreaY && AreaY == AreaZ)
            {
                Console.WriteLine("Triangulo é Eqüilátero!");
            }

            else if (AreaX == AreaY || AreaY == AreaZ && AreaZ != AreaX)
            {
                Console.WriteLine("O Triangulo é Isósceles!");
            }

            else if (AreaX != AreaY && AreaY != AreaZ && AreaZ != AreaX)
            {
                Console.WriteLine("O Triangulo é Escaleno!");
            }

            else if (AreaX + AreaY < AreaZ  || AreaX + AreaZ < AreaY  || AreaY + AreaZ < AreaX)
            {
                Console.WriteLine("Triângulo inválido");
            }

            Console.ReadLine();
        }
    }
}
