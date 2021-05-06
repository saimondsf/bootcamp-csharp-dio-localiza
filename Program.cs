using System;
using Classes.Herança;

namespace BootcampLocaliza
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(1, 2);
            Ponto3D p2 = new Ponto3D(3, 4, 5);

            p1.CalcularDistancia3();
            p2.CalcularDistancia3();
        }
    }
}
