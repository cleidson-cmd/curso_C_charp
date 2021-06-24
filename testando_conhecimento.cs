using System;

class app{
    static void Main(){
        
        

        string[,] registros = new string[5, 5];//tipo strin para conseguir pegar os valores

        string nome_produto;
        double valor_pago_pelo_produto; 
        double lucro;
        double preco_produto;
        double taxa_porcento;
        char opcao;

        inicio:

        Console.Clear();
        //informe nome do produto
        Console.WriteLine("Nome do Produto:");
        nome_produto = Console.ReadLine();



        //informe o valor pago do produto unitario
        Console.WriteLine("quanto pagou no produto:");
        valor_pago_pelo_produto = double.Parse(Console.ReadLine());
        
        if (valor_pago_pelo_produto != 8){//parte incompleta preisa de reajuste===========
            Console.Clear();
            Console.WriteLine("valor deve ser do tipo numerico\ntentar novament?[s] [n]");
            opcao = char.Parse(Console.ReadLine());

            switch(opcao){
                case 's':
                case 'S':
                    goto inicio;
                


                case 'n':
                case 'N':
                    Console.Clear();
                    Console.WriteLine("fim do programa!");
                    goto fim;
                

                default:
                    Console.WriteLine("valor digitado invalido");
                    break;
            }


        }



        //quanto porcento quer ganhar emcima desse valor pago no prduto
        Console.WriteLine("porcentagem a ser adicionada em cima do valor:");
        taxa_porcento = double.Parse(Console.ReadLine());

        //taxa de porcentagem
        lucro = taxa_porcento * valor_pago_pelo_produto / 100;

        
        //preço do produto com a taxa em cima
        preco_produto = valor_pago_pelo_produto + lucro;
        
        //guardando as variaveis em uma matriz=======================
        registros[0,0] = nome_produto;
        registros[0,1] = Convert.ToString(valor_pago_pelo_produto);
        registros[0,2] = Convert.ToString(taxa_porcento);
        registros[0,3] = Convert.ToString(preco_produto);
        registros[0,4] = Convert.ToString(lucro);


        Console.WriteLine("nome do produto.........:{0, 15:c}", registros[0,0]);
        Console.WriteLine("Custo do produto........:{0, 15:c}", registros[0,1]);
        Console.WriteLine("porcentagem de acrecimo.:{0, 15:}%", registros[0,2]);
        Console.WriteLine("valor de revenda........:{0, 15:c}", registros[0,3]);
        Console.WriteLine("lucro em dinheiro.......:{0, 15:c}", registros[0,4]);


        Console.WriteLine("deseja continuar? [s] [n]");
        opcao = char.Parse(Console.ReadLine());

        switch(opcao){
            case 's':
            case 'S':
                 goto inicio;
                

            case 'n':
            case 'N':
                Console.Clear();
                Console.Write("fim do programa!");
                break;

            default:

                Console.WriteLine("nenhuma das opçoes esperada");
                break;

        }

        fim: //finaliza o programa quando intemrompido pelo user
        Console.WriteLine("programa finalizado");

       






        
    
        
    
    }
}