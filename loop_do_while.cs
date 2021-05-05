using System;

class aula21{
    static void Main(){

        string senha = "123";
        string senhauser;
        int tentativas=0;

        do{
            Console.Clear();
            Console.WriteLine("digite a senha:");
            senhauser = Console.ReadLine();
            tentativas++;
        }
        while(senha != senhauser);

        Console.WriteLine("senha correta!\ntentativas: {0}", tentativas);
        
    
    }
}