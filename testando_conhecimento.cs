using System;

class app{
    static void Main(){
        
        inicio:

        int[,] registros = new int[5, 5];

        string nome_produto;
        double valor_pago_pelo_produto; 
        double lucro;
        double preco_produto;
        double taxa_porcento;
        char opcao;

     

        Console.Clear();
        //informe nome do produto
        Console.WriteLine("Nome do Produto:");
        nome_produto = Console.ReadLine();



        //informe o valor pago do produto unitario
        Console.WriteLine("quanto pagou no produto:");
        valor_pago_pelo_produto = double.Parse(Console.ReadLine());

        if (valor_pago_pelo_produto != ){
            Console.WriteLine("valor dev ser do tipo numerico\ntentar novament?[s] [n]");
            opcao = Console.ReadLine();

            switch(opcao){
                case "s":
                case "S":
                    goto inicio;
                    break;


                case "n":
                case "N":
                    Console.WriteLine("fim do programa!");
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
        

        Console.WriteLine("Nome do produto.........:{0, 15:c}", nome_produto);
        Console.WriteLine("Custo do produto........:{0, 15:c}", valor_pago_pelo_produto);
        Console.WriteLine("porcentagem de acrecimo.:{0, 15:}%", taxa_porcento);
        Console.WriteLine("valor de revenda........:{0, 15:c}", preco_produto);
        Console.WriteLine("lucro em dinheiro.......:{0, 15:c}", lucro);


        Console.WriteLine("deseja continuar? [s] [n]");
        opcao = char.Parse(Console.ReadLine());

        switch(opcao){
            case 's':
            case 'S':
                 goto inicio;
                 break;

            case 'n':
            case 'N':
                Console.Clear();
                Console.Write("fim do programa!");
                break;

            default:

                Console.WriteLine("nenhuma das opçoes esperada");
                break;

        }

       






        
    
        
    
    }
}