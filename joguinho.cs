using System;

public class Jogadores
{
    public string Nome;
    public int life = 100;
    public bool vivo = true;

    public void getNomeOld(string name){
        string nomeOld = name;
    }
}

class play : Jogadores
{
    static void Main()
    {
        inicio:
        Console.Clear();
        
        var n = "";//guarda a resposta d jogador se quer jogar novamente


        var NomeJogador = "";//variavel que pegao nome do ogador
        Console.WriteLine("Qual Nome do Jogador?");
        NomeJogador = Console.ReadLine();//pegando o nome do jogador
        Console.Clear();

        Jogadores jogador = new Jogadores();//atribuindo um novo jogador herdando a classe jogadores
        jogador.Nome = NomeJogador; //dando nome ao jogador


        Console.WriteLine("Jogador: {0}\nVida: {1}%\ncada erro perde 25% de vida totalizando 4 tentativas", jogador.Nome, jogador.life);//informaçoes sobre jogador e partida
        Console.WriteLine("tecle Enter para começar");
        Console.ReadKey();
        Console.Clear();


        int tentativa = 0;
        int tentativas = 0;
        

        while (jogador.vivo == true)
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
                Console.WriteLine("parabens {0}, acertou!", jogador.Nome);
                Console.WriteLine("Tentativas Perdidas: {0}",tentativas);
                novamente:
                Console.WriteLine("============================");
                Console.WriteLine("==Continuar Jogando? [y,n]==");
                Console.WriteLine("============================");
                n = Console.ReadLine();
                if (n == "y" || n == "Y")
                {
                    goto inicio;
                }else if (n == "n" || n == "N"){
                    Console.Clear();
                    Console.WriteLine("Jogo Emcerrado!\npress Enter");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Valor digitado Invalido");
                    goto novamente;
                }

                break;

            }
            else
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Errou!");
                jogador.life -= 25;
                Console.WriteLine("Vida Perdida: -25%\nvida atual: {0}%", jogador.life);
                tentativas += 1;
                

                if (jogador.life == 25){
                    Console.WriteLine("========================================");
                    Console.WriteLine("============ULTIMA TENTATIVA============");
                    Console.WriteLine("========================================");
                }


                if (jogador.life <= 0)
                {
                    jogador.vivo = false;
                    Console.WriteLine("{0} Perdeu!", jogador.Nome);
                    Console.WriteLine("============================");
                Console.WriteLine("==Continuar Jogando? [y,n]==");
                Console.WriteLine("============================");
                n = Console.ReadLine();
                if (n == "y" || n == "Y")
                {
                    goto inicio;
                }else if (n == "n" || n == "N"){
                    Console.Clear();
                    Console.WriteLine("Jogo Emcerrado!\npress Enter");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Valor digitado Invalido");
                    goto inicio;
                }
                    break;
                }

                Console.WriteLine("========================================");


            }

            Console.WriteLine("Numero aleatoorio era: {0}\nnumero digitado: {1} ", NumSorteado, tentativa);
            Console.WriteLine("==Continuar==");
            Console.ReadKey();
            Console.Clear();
        }
    }
}