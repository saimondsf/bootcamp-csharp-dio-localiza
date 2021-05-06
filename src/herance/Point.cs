using System;

namespace Classes.Herança
{
    public class Ponto{

        public int x, y;

        private int distancia;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia(){
            //Protected - Quem herdar esta classe herdará este método
        }

        private void CalcularDistancia2(){
            //Private - Só poderá ser executado dentro desta classe
        }

        public virtual void CalcularDistancia3(){
            //Virtual - Poderá ser modificada suas funcionalidades nas classes que iráo herda-la 
            Console.WriteLine("Função 'CalcularDistancia3'");
            Console.WriteLine($"{x} {y}");
        }
    }    
}

