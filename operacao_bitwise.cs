using System;


class aula9{
    static void Main(){
        int num = 10;

        num = num << 1;//operador bitwise joga os 5 primeiro bits para o final mostrando o dobro do valor total 

        Console.WriteLine(num);


        num = num >> 1; //operador bitwise joga os 5 ultimos bist para direita mostrando a medade do valor total

        Console.WriteLine(num);


        num = num << 2;//bitwise dobra 2 vezes o valor ex: se for num = 2 resultado e 8

        Console.WriteLine(num);
}
}
// bitwise ex: num = 2   num = num << 1 operador dobra gerando 4
//ex: num = 2   num = num << 2 operador dobra 2 vezes gerando 8
//assim por diante 