using System;

class aula15{
    static void Main(){
        int tempo =0;
        char escolha= ' ';

        inicio: //quando chamar o goto la em baixo ele volta para esse trecho chamdo de label

        Console.Clear(); // cada vez que iniciar ele limpara o prompt


        Console.WriteLine("belo Horizonte/MG a Vitoria/ES");
        Console.WriteLine("escolha o transporte: [a]Aviao | [c]Carro | [o]nibus");
        
        
        escolha = char.Parse(Console.ReadLine());
        



        switch(escolha){
            case 'a':
            case 'A':
                tempo=50;
                break;

            case 'c':
            case 'C':
                tempo = 480;
                break;

            case 'o':
            case 'O':
                tempo = 660;
                break;

            default:
                tempo = -1;
                break;

            }

        if (tempo < 0){
            Console.WriteLine("opçao invalida!");

        }else{
            Console.WriteLine("Para o Transprte escolhido o tempo é: {0} minutos", tempo);
        }

        Console.Write("Caucular outro transporte? [s/n]:  ");
        escolha = char.Parse(Console.ReadLine());
        if (escolha == 's' || escolha == 'S'){
            goto inicio;//chamando o goto ele ira voltar la pra cima o chamado label que é inicio
        }else{
            Console.Clear();
            Console.WriteLine("Fim do Programa!\n");
        }

    }
}