using System;

namespace BootcampLocaliza
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeVezes = 9;

            int[] a = new int [3];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            int[] t = a;

            for(int i=0; i < numeroDeVezes; i++){
                Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
            }
        }
    }
}
