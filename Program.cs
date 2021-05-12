using System;
using Classes.Herança;

namespace BootcampLocaliza
{
    class Program
    {
        static void Main(string[] args)
        {
            PontoTal[] algumvetor = new PontoTal[100];
            for(int i = 0; i < 100; i++){
                algumvetor[i] = new PontoTal(i, i);
                algumvetor[i].Mostrar();
            }
        }
    }
}
