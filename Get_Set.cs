using System;

class Car
{
    private int vlMax;

    
    //vm retorna o vaor de vlMax que é privado
    public int vm
    {//propriedade nao precisa dos () apenas as {}
     //nao é obrigado usar os 2 get e set podendo escolher apenas um
        get
        {//apenas leitura /mostra o que tem pega valor existente
            return vlMax;
        }
        set
        {//permite a insersao de valor novo ex: input 
            if (value < 0)
            {
                vlMax = 0;
            }
            else if (value > 300)
            {
                vlMax = 300;
            }
            else
            {
                vlMax = value;
            }
        }

    }

    public Car()
    {//metodo precisa dos (){}
        this.vm = 120;
    }

}

class aula41
{
    static void Main()
    {
        Car carro11 = new Car();
        carro11.vm = 390;//recebe valor tipo set
        //ele nao vai mstrar os 390 porque n modo set esta definido tanho max de 300
        Console.WriteLine("velocidade {0}", carro11.vm);//mostra valor tipo get
    }
}


