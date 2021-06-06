using System;

public class Players
{
    public string Nome;
    public int energia;
    public bool life;

    public Players(string nome){
        Nome = nome;
        energia = 100;
        life = true;
    }
}



class players
{
    static void Main()
    {

        object[] TodosPlayers = new object[4];
        var NomeJogador = "";//variavel que pegao nome do ogador
     
        
        for (int i = 0; i <= 3; i++){
            Console.WriteLine("Qual Nome do Jogador?");
            NomeJogador = Console.ReadLine();
            Players jogador = new Players(NomeJogador);

            TodosPlayers[i] = jogador.Nome + jogador.energia + jogador.life;
            
            Console.WriteLine(TodosPlayers[i]);
            //Console.Clear();
        }

    
/* 
        
        TodosPlayers[0].life;

        Console.WriteLine("Jogador: {0}\nVida: {1}%\ncada erro perde 25% de vida totalizando 4 tentativas", TodosPlayers[0].Nome, TodosPlayers[0].energia);//informaçoes sobre jogador e partida
        Console.WriteLine("tecle Enter para começar");
        Console.ReadKey();
        Console.Clear();


        int tentativa = 0;
        int tentativas = 0;
        

        while (TodosPlayers[0].vivo == true)
        {

            
            Random numero = new Random();
            int NumSorteado = numero.Next(1, 6);//gera numero aleatorio inteiro
            //double NFracao = numero.NextDouble();//gera numero fracioada

            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
            Console.WriteLine("Qual numero sorteado entre 1 a 5:");
            tentativa = int.Parse(Console.ReadLine());
            Console.Clear();
          

            if (tentativa == NumSorteado)
            {
                Console.WriteLine("acertou! parabens");
                Console.WriteLine("Tentativas {0}",tentativas);
                break;

            }
            else
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Errou!");
                TodosPlayers[0].life -= 25;
                Console.WriteLine("perdeu: 25% de vida\nvida atual: {0}", TodosPlayers[0].life);
                tentativas += 1;

                if (TodosPlayers[0].life == 25){
                    Console.WriteLine("========================================");
                    Console.WriteLine("============ULTIMA TENTATIVA============");
                    Console.WriteLine("========================================");
                }


                if (TodosPlayers[0].life <= 0)
                {
                    TodosPlayers[0].vivo = false;
                    Console.WriteLine("{0} Perdeu!", TodosPlayers[0].Nome);
                    break;
                }

                Console.WriteLine("========================================");


            }

            Console.WriteLine("Numero aleatoorio era: {0}\nnumero digitado: {1} ", NumSorteado, tentativa);
            Console.WriteLine("==Continuar==");
            Console.ReadKey();
            Console.Clear();

        } */


    }


}