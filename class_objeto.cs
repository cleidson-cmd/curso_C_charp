using System;

public class Jogador{
    public int energia = 100;
    public bool vivo = true;


     
}



class aula28{
static void Main(){
//classe ogador vou chamar de j1 e atribuir um novo jogador que sera o j1, j2, j3
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;

        Console.WriteLine("energia do jogador 1 {0} ", j1.energia);
        Console.WriteLine("energia do jogador 2 {0} ", j2.energia);
    
    }

}