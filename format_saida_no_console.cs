using System;



class aula6 {
    static void Main(){
        int n1, n2 , n3;

        n1=20; n2=20; n3=30;


        Console.Write("\nn1\t=\t{0} \nn2\t=\t{1} \nn3\t=\t{2}",n1, n2, n3);// \n = quebra linha / "{indice}", variaveis / \t inseri uma tabulaçao 
    
        Console.WriteLine("\n\n");

        double valorCompras = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "pastel";

        valorVenda = valorCompras + (valorCompras * lucro);

        Console.WriteLine("produto.....: {0, 15}", produto);
        Console.WriteLine("Val.Compra..: {0, 15:c}", valorCompras);
        Console.WriteLine("lucro.......: {0, 15:p}", lucro);// :p  formato de procentagem
        Console.WriteLine("Val.venda...: {0, 15:c}", valorVenda); // "{0, 15:c}" 0  indice :c  formato de moeda 15 e uma tabulaçao/espaço
    
        
        
    }
}