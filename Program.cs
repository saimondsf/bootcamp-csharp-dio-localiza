using System;
using Classes.Herança;

namespace BootcampLocaliza
{
    class Program
    {
        enum Estacao
        {
            Outono,
            Inverno,
            Verao,
            Primavera
        }

        static void Main(string[] args)
        {
            Estacao a = Estacao.Outono;
            Console.WriteLine(a);
            
            Ponto[] algumponto = new Ponto[10];

            for(int i = 0; i < 10; i++){
                 algumponto[i] = new Ponto(i, i);
                 algumponto[i].Mostrar();
            }
        }
    }
}
