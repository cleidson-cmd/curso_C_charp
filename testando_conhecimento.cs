using System;

class app{
    static void Main(){
        string produto;
        double valorcompra; 
        double lucro;
        double precoproduto;
        double taxaporcento;

        //informe nome do produto
        Console.WriteLine("Nome do Produto:");
        produto = Console.ReadLine();



        //informe o valor pago do produto unitario
        Console.WriteLine("quanto pagou no produto:");
        valorcompra = double.Parse(Console.ReadLine());





        //quanto porcento quer ganhar emcima desse valor pago no prduto
        Console.WriteLine("porcentagem a ser adicionada em cima do valor:");
        taxaporcento = double.Parse(Console.ReadLine());

        lucro = (valorcompra * taxaporcento) / 100;
        precoproduto = valorcompra + lucro;

        Console.WriteLine("produto..............:{0, 15}", produto);
        Console.WriteLine("investido............:{0, 15:c}", valorcompra);
        Console.WriteLine("taxa de lucro........:{0, 15:p}", taxaporcento);
        Console.WriteLine("valor do produto.....:{0, 15:c}", precoproduto);
        Console.WriteLine("lucro................:{0, 15:c}", lucro);
        






        //valor que o produto sera vendido com a taxa  em % em cima    
    
        
    
    }
}