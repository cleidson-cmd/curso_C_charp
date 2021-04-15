using System;


class aula08{

    static void Main(){
        int v1, v2, soma;
        string nome;

        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();


        Console.Write("Digite valor 1: ");
        v1 = int.Parse(Console.ReadLine());//convertendo entrada para int

        
        Console.Write("Digite valor 2: ");//sempre que passar uma entrada para uma variavel int tem que converter para int primeiro
        v2 = Convert.ToInt32(Console.ReadLine());// outra forma de converter para int outra forma de fazer a mesma coisa

        soma = v1 + v2;

        Console.WriteLine("ola: {0}! soma de {1} + {2} = {3}", nome, v1, v2, soma);


    }
}