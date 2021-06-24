using System;

abstract class Veiculo{//nao posso instanciar classe abstrata, so serve para ser herdada
                        //classe abstrata = modelo de classe apenas para ser herdada por outra classe
    protected int vel_max;
    protected int vel_atual;
    protected bool ligado;
    
    public Veiculo(){
        vel_atual = 0;
        ligado = false;
    }

    public void setigado(bool ligado){
        this.ligado = ligado;
    }

    public int getVelAtual(){
        return vel_atual;
    }

    abstract public void aceleracao(int mult);//metodo abstrato vazio
}

class carro1 : Veiculo{
    public carro1(){
        vel_max = 120;
    }

    override public void aceleracao(int mult){//obrigado chamar um metodo abstrato chando chamamos uma classe que o tenha
        vel_atual += 10 * mult;
    }

}

class aula39{
    static void Main(){
        carro1 carro = new carro1();
        carro.aceleracao(2);
        Console.WriteLine("velocidade aumentando    {0}",carro.getVelAtual());
        carro.aceleracao(-1);
        Console.WriteLine("velocidade diminuindo    {0}",carro.getVelAtual());
    }
}