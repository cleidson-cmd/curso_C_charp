using System;
class aula17{
    static void Main(){

       int[,] n = new int[3,5];// uma virgla no int[,]  e no new int[qtd_linha, qud_colunas] ex: new int[3,5]

       //int[] num = new int[3, 5] {11, 22, 33}, {12,13,14}, {23, 24, 25}; // criando matriz com valores

       // string[] veiculos = new string[6];
       
       n[0, 0] = 011; // inserindo na linha 0 coluna 0
       n[0, 1] = 022; // inserindo na linha 0 coluna 1
       n[0, 2] = 033; // inserindo na linha 0 coluna 2
       n[0, 3] = 044; // inserindo na linha 0 coluna 3
       n[0, 4] = 055; // inserindo na linha 0 coluna 4


       n[1, 0] = 111; // inserindo na linha 1 coluna 0
       n[1, 1] = 122; // inserindo na linha 1 coluna 1
       n[1, 2] = 133; // inserindo na linha 1 coluna 2
       n[1, 3] = 144; // inserindo na linha 1 coluna 3
       n[1, 4] = 155; // inserindo na linha 1 coluna 4


       n[2, 0] = 211; // inserindo na linha 2 coluna 0
       n[2, 1] = 222; // inserindo na linha 2 coluna 1
       n[2, 2] = 233; // inserindo na linha 2 coluna 2
       n[2, 3] = 244; // inserindo na linha 2 coluna 3
       n[2, 4] = 255; // inserindo na linha 2 coluna 4




       Console.WriteLine(n[0,2]); //mostrando conteudo da linha 0 coluna 2
       Console.WriteLine(n[1,2]); //mostrando conteudo da linha 1 coluna 2
       Console.WriteLine(n[2,2]); //mostrando conteudo da linha 2 coluna 2
    
    }
}