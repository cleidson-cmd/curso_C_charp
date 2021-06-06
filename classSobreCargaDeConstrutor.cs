using System;

public class usuario{
    public int energia;
    public bool vivo;

    public string nome ="jogador";

    public usuario(string n, int e, bool L){ //metodo construtor tem que ter o mesmo nome da classe que pertence
        energia = e;
        vivo = L;
        nome = n;
    }

    
    public void info(){ //detlhes do jogador
        Console.WriteLine("Nome: {0}\nEnergia: {1}\nEstado: {2}", nome, energia, vivo);
    }


}



class aula30{
static void Main(){
        
        usuario j2 = new usuario("leleide", 67, true);
        usuario j3 = new usuario("cleisinho", 100, false);//esse nome entra na variavel n que é parametro no construtor da classe 
        usuario j4 = new usuario("jessika", 50, true);
        usuario j5 = new usuario("veinho", 50, false);
        string estatoAtual = (j3.vivo == true? "vivo" : "morto");
        
    
        j2.info();
        j3.info();
        j4.info();
        Console.WriteLine("estado: {0}", estatoAtual);
        

    
    }

}