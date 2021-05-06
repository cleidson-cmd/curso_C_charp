using System;
class aula17{
    static void Main(){
       //int n1, n2, n3, n4, n5;
       int[] n = new int[5];// iniciando array vazia

       int[] num = new int[3] {11, 22, 33}; // criando array com valores

       int[] number = {1, 2, 3};//criando array sem especificar quantos indices ele vai ter nesse caso ficou com 3 indices
                                //nesse caso pode adcionar os valores sem se preocupar com quantidade de indice
       string[] veiculos = new string[6];
       
       n[0] = 111;
       n[1] = 222;
       n[2] = 333;
       n[3] = 444;
       n[4] = 555;

       Console.WriteLine(n[0]);
    }
}