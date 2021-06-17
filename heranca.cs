using System;


class veiculos{

    public int rodas;

    public int velMax;
        
    public bool ligado;

    public void ligar(){
        ligado = true;
    }

    public void desligar(){
        ligado = false;
    }

    public string GetLigado(){
        if (ligado){
            return "Sim";
        }else{
            return "Nao";
        }
    }

    
}

class carro : veiculos{//classe derivada herda a classe base que é veiculos
    
    public string nome;
    public string cor;

    public carro(string nome, string cor){
        this.cor = cor;
        this.nome = nome;
        desligar();
        rodas = 4;
        velMax = 120;
    }

} 


public class aula34{

    static void Main(){
        carro car = new carro("Lamborguine", "preto");
        //car.ligar() = true;//consigo acessar ligar que pertence a veiculos que carro esta herdando porque esta public
        Console.WriteLine("nome-------:{0}",car.nome);
        Console.WriteLine("cor--------:{0}",car.cor);
        Console.WriteLine("velocidade-:{0}",car.velMax);
        Console.WriteLine("Lgado------:{0}",car.GetLigado());
        if (car.ligado == false){
            car.ligado = true;
        }
        Console.WriteLine("Lgado------:{0}",car.GetLigado());
        Console.WriteLine("rodas------:{0}",car.rodas);
        if (car.ligado == true){
            car.ligado = false;
        }
    }
}

