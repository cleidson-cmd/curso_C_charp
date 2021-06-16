using System;


class Calculos{
    public int v1;//v1 declarado global na classe

    public int v2;//v2 declarado global na classe

    public Calculos(int v1, int v2){//passa o valores inseridos par a as variveis da classe 
        this.v1 = v1;//this.v1 referencia a v1 que foi declarada global na classe  cima
        this.v2 = v2;//v2 sem o this é a v2 do metodo cauculos e nao da classe 
        //se nao tiver o this ele da erro como se quisesse atribuir a mesma variavelpara se 
    }

    public int Somar(){//soma os valores 
        return v1 + v2;
    }
}


class aula32{
    static void Main(){
        Calculos calculo = new Calculos(10,4);//instancia a classe 

        Console.WriteLine(calculo.Somar());//soma a classe instanciada
    
    }
}