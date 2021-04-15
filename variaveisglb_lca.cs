using System;

class aula4{

    int num=10;//variaveis globais podem ser acessada de qualque metodo dentro da classe em que ela foi criada 
                //variaveis locais nao podem ter o mesmo nome de uma global
    static void Main(){
        int num2 =0;//variaveis locais podem ter o mesmo nome desde que cada uma esteja dentro de seu local especifico
                    //para uma variavel global funcionar aqui no static void a variavel global tem que ser static tambem
                    //ex: eonde esta a variavel global a cima (int num = 10) ficaria (static int num = 10 )
    }
        void teste(){
            int num3 = 0;//variaveis locais sao interpretada apenas dentro da aria em que ela fi criada
            Console.WriteLine(num);

        }

    
}
