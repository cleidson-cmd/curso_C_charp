using System;



class jogador{
    public string nome; //nome é publico ode ser acessado fora da classe
    public int energia;

    private int idade;//idade é privado e so pode ser acessado dentro da classe


    public jogador (string nome){
        this.nome = nome;
        energia = 100;
        idade = 100;
    }


    public int GetIdade(){//criando um metodo que permite acessar idade de fora da classe
        return idade;
    }


    public void SetIdade(int novaIdade){//permite alterar idade fora d classe

        if (novaIdade < 0){//a idade nao pode ser maior que 100 e nem menor que 0
            if (idade + novaIdade < 0){//se a idade atual - a nova idade for menor que zero ele nao deixa ficar negativo
                idade = 0; //para na ficar negativo ele ja passa o zero para idade
            }else{
                idade += novaIdade;//se nao for fcar negativo ele abate a idade antiga com a nova
            }
        }
        else
        {
            if (idade + novaIdade > 100){//se passar se 100 ee nao deixa 
                idade = 100;// e ja atribui o 100 que é o valor maximo ermitido
            }else{
                idade += novaIdade;// se nao passar dos 100 ele permite a adiçao da ova idade 
            }

        }


    }


}


class aula33{
    static void Main(){


        jogador j1 = new jogador("bruno");
        int ide = Convert.ToInt32(Console.ReadLine());
        j1.SetIdade(ide);


        Console.WriteLine("Nome ...: {0}", j1.nome);//posso acessar nome e energia aqui porque eles sao publicos
        
        Console.WriteLine("energia : {0}", j1.energia);

        Console.WriteLine("energia : {0}", j1.GetIdade());//pegando idade atraves do metodo criado GetIdade
    
    }
}