using System;

static public class personagem{//classe static nao permite instaciaçao apartir de classe static e nao pode ter construtores
                               //tods os membros da classe devem ser static 
    static public int energia;
    static public bool vivo;
    static public string nome ="jogador";

    static public void iniciar(string n){ //metodo construtor tem que ter o mesmo nome da classe que pertence
         energia = 100;
         vivo = true;
         nome = n;
     }
    static public void info(){ //detlhes do jogador
        Console.WriteLine("Nome: {0}\nEnergia: {1}\nEstado: {2}", nome, energia, vivo);
    }
}



class inimigo{
    static public bool alerta;
    public string nome;

    public inimigo(string n){
        alerta=false;
        nome=n;
    }

    public void info(){
        Console.WriteLine("{0} {1}", nome, alerta);
        Console.WriteLine("------------------------------------------------");
    }

}



class aula31{
static void Main(){
        
        string estatoAtual = (personagem.vivo == true? "vivo" : "morto");
        
        personagem.info();
        personagem.iniciar("cleidson");//classes staticas nao permite ser instanciada, por isso usa-se no nome da classe . propriedade
        Console.WriteLine("estado: {0}", estatoAtual);    


        inimigo i1 = new inimigo("veinhooo");
        inimigo i2 = new inimigo("nygga");
        inimigo i3 = new inimigo("jha");
        inimigo.alerta=true;
        i1.info();
        i2.info();
        i3.info();
    }

}

