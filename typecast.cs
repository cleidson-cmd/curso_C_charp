using System;

class aula11{

    static void Main(){

        int n1 = 10;
        float n2 = n1;//converte automaticamente de inte pra float por ser uma conersao segura

        Console.WriteLine(n2);



        float n3 = 10.5f;
        //int n4 = n3; nesse caso nao coverte automatico por nao ser uma conversao segura quando  float fr passado paa int ele erdera o valor da fraçao

        int n4 = (int)n3; //nesse caso tem que cnverter manualmente dessa forma. esse tipo de conversao é chamado de typecast oi cast
        Console.WriteLine("automatico {0} manual ou typecast {1}", n2, n3);

    
    }
}