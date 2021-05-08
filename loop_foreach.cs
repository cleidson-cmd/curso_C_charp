using System;

class aula22{
    static void Main(){

        int[] num = new int[5]{11, 22, 33, 44 ,55};

        for (int i = 0; i < num.Length; i++){
            
        Console.WriteLine(num[i]);
        }


        foreach(int n in num){//criei a variavael 'n' do mesmo tipo de 'num' e peguei todos os valor de 'num' e atribui a 'n'
            Console.WriteLine(n);//aqui dentro nao pode atribuir valor a variavel criada no foreach 
                                 //ex: n = 0;  nao pode    
        }
    
    }
}