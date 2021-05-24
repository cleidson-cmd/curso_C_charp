using System;

class aula12{
    static void Main(){
        int num = 10;
        dobrar(ref num);//ref esta referenciando o metodo a baixo, que tambem esta com ref
        dobrar1(num);//exeplo se referencia ele mostra apenas o valor da variavel sem fazer o caucul dobrar
        Console.WriteLine(num);
    
    }


    static void dobrar ( ref int valor){
        valor*=2;
    }

    static void dobrar1 (int valor){
        valor*=2;
    }

}