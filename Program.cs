using System;

namespace BootcampLocaliza
{
	class Program
	{
		static void Main(string[] args)
		{ 
      int diaInicio, diaTermino;
      int horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
      int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
      int Z = 0;
      int Y = 0;
      int X = 0;
      int W = 0;
      //continue escrevendo a solucao

      string[] dadosInicio = Console.ReadLine().Split();
      diaInicio = Convert.ToInt32(dadosInicio[1]);

      string[] dadosMomentoInicio = Console.ReadLine().Split();
      horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
      minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
      segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

      string[] dadosTermino = Console.ReadLine().Split();
      diaTermino = Convert.ToInt32(dadosTermino[1]);

      string[] dadosMomentoTermino = Console.ReadLine().Split();
      horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
      minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
      segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);   

      int transformaSegundosInicio = segundoMomentoInicio + (minutoMomentoInicio*60) +
                                      (horaMomentoInicio*3600) + (diaInicio*86400);
                                           
      int transformaSegundosTermino = segundoMomentoTerminio + (minutoMomentoTermino*60) +
                                      (horaMomentoTermino*3600) + (diaTermino*86400);

      int somaTotalSegundos = transformaSegundosTermino - transformaSegundosInicio;
            
      W = somaTotalSegundos / 86400;
      somaTotalSegundos %= 86400;
      Console.WriteLine("{0} dia(s)", W);
            
      X = somaTotalSegundos / 3600;
      somaTotalSegundos %= 3600;
      Console.WriteLine("{0} hora(s)", X);
            
      Y = somaTotalSegundos / 60;
      somaTotalSegundos %= 60;
      Console.WriteLine("{0} minuto(s)", Y);
            
      Z = somaTotalSegundos;
      Console.WriteLine("{0} segundo(s)", Z);
    }
  }
}