using System;

namespace Classes.Herança
{
    public class Ponto3D : Ponto{

        public int z;

        public Ponto3D(int x, int y, int z) : base (x, y){
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular(){
            //Static - Para utilizar este método, não é necessário instanciar um objeto
        }

        public override void CalcularDistancia3(){
            //Override - Para sobreescrever em cima da função herdada
            Console.WriteLine($"{x} {y} {z}");
            base.CalcularDistancia3();
        }
        
    }
}