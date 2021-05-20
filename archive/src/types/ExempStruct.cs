using System;

public struct PontoTal
{
    public int x, y;
    public PontoTal(int x, int y){
        this.x = x;
        this.y = y;
    }
    public void Mostrar(){
        Console.WriteLine($"{x} {y}");
    }
}