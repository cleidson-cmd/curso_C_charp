using System;

class Base{
    public Base(){
        Console.WriteLine("classe base");
    }
}

class derivada1 : Base{
    public derivada1(){
        Console.WriteLine("classe derivda 1 que herda Base");
    }
}

class derivada2 : derivada1{
    public derivada2(){
        Console.WriteLine("classe derivada 2 que herda derivda 1");
    }
}

class aula37{
    static void Main(){
        derivada2 derivada = new derivada2();//derivada2 acessa todos os parametro, ja que herda a derivada 1 que herda base
                                                //a ordem de execuçao e sempre da base para a derivada 
    }
}