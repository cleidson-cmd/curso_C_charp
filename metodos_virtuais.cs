using System;

class Bases{
    public Bases(){
        Console.WriteLine("classe base");
    }

    virtual public void info(){//na classe base tenho um metodo virtual que pode se sobescrito por um metodo existente em outra classe que herde a classe base
        Console.WriteLine("metodo base");//nessa parte o metodo virtual pode ficar vazio ja que ele pode ser sobescrito em outras classes
    }
}

class derivada01 : Bases{
    public derivada01(){
        Console.WriteLine("classe derivda 1 que herda Base");
    }

    override public void info(){//override sobescreve o metodo virtual info que foi definido na classe base 
        Console.WriteLine("metodo derivada 01");
    }
}

class derivada02 : derivada01{
    public derivada02(){
        Console.WriteLine("classe derivada 2 que herda derivda 1");
    }

     override public void info(){//override sobescreve o metodo virtual info que foi definido na classe base 
        Console.WriteLine("metodo derivada 02");//obs: ao imprimir ele mostrara sempre o ultimo metodo override quando chamado 
    }
}

class aula38{
    static void Main(){
        Bases Ref;//estou criando uma referencia de pase para outro metodo que o herda
        
        derivada01 derivada1 = new derivada01();//derivada2 acessa todos os parametro, ja que herda a derivada 1 que herda base
                                                //a ordem de execuçao e sempre da base para a derivada 
        derivada02 derivada2 = new derivada02();
        derivada1.info();//nesse caso estu especificando qual info override quero imprimir entre verivada 1 e 2
        derivada2.info();

        Ref = derivada1;//estou referenciando a derivada1 a base
        Ref.info();//acessando o metodo info da classe derivada01 com o Ref da classe bases
        

        
    }
}