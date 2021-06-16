using System;

class Aula03{
    static void Main(){

        int num1, num2, res;
        num1 = 4;
        num2 = 6;
        res = num1 + num2;

        byte n1 = 10; //0 e 255
       // int num=0;
       // char letra = 'c';
       // float valor = 1.7f;
        string nome = "armazena textos e numeros";
        //var aux = 10; // nao espesificado o tipo da variavel, na compilaçao ela vai se basear no dado que recebe e auto definir seu tipo.

        Console.WriteLine("valor da variavel =: " + nome +" bytes "+n1 + "soma de" + num1 + " + " + num2 + " = "+ res);
    }
}