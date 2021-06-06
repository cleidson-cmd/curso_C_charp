using System;

public class player{
    public int energia;
    public bool vivo;

    public string nome;

    public player(string n){ //metodo construtor tem que ter o mesmo nome da classe que pertence
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~player(){
        Console.WriteLine("destruindo");//destrutor tem que ter o mesmo nome da classe que pertence ele destroi o objeto criado ex: um jogador
    } 
}



class aula29{
static void Main(){
        //string[] jogadores = new string[10]; 
//classe ogador vou chamar de j1 e atribuir um novo jogador que sera o j1, j2, j3
        
        player j1 = new player("cleidson");
        player j2 = new player("leleide");
        player j3 = new player("cleisinho");//esse nome entra na variavel n que é parametro no construtor da classe 


    
        Console.WriteLine("energia do jogador      {0} ", j1.energia);
        Console.WriteLine("status vivo do jogador  {0} ", j2.vivo);
        Console.WriteLine("nome do jogador         {0} ", j2.nome);

    
    }

}