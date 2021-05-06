using System;

namespace BootcampLocaliza
{    
    class VariablesAndStuctures
    {
        static void Declaracoes()
        {
            int x = 1;
            int y = 4, w = 0;
            const int q = 5;
            Console.WriteLine(x);
            x = 2;
            Console.WriteLine(x + y + w + q);
        }

        static void InstrucaoIf(string[] args)
        {
            if(args.Length == 0){
                Console.WriteLine("Nenhum argumento");
            }
            else if(args.Length == 1){
                Console.WriteLine("Um argumento");
            }
            else{
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch(numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                case 2:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while( i < args.Length){
                Console.WriteLine(args[i]);
                i++;
            }

        }

        static void InstrucaoDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for(int i=0; i<args.Length; i++){
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForEach(string[] args)
        {
            foreach(string s in args){
                Console.Write(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    break;
                }

                Console.WriteLine(s);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for(int i=0; i<args.Length; i++)
            {
                if(args[i].StartsWith("/"))
                    continue;
                
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            if(args.Length == 0)
            {
                return;
            }

            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(3,4));
            Console.WriteLine(Somar(5,6));
            return;
        }

        static void InstrucaoTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if(y==0)
                    throw new DivideByZeroException();

                return x/y;
                
            }

            try
            {
                if(args.Length!=2){
                    throw new InvalidOperationException("Informe dois números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x,y));

            }
            catch(InvalidCastException e){
                Console.Write(e.Message);
            }
            catch(Exception e){
                Console.WriteLine($"Erro genérico: {e.Message} ");
            }
            finally{
                Console.Write("Até breve");
            }

        }
 
        static void InstrucaoUsing(string[] args)
        {
            
            using(System.IO.TextWriter w = System.IO.File.CreateText("teste.txt")){
                w.WriteLine("Linha 1");
                w.WriteLine("Linha 2");
                w.WriteLine("Linha 3");
            }
        }


    }
}