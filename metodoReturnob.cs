using System;

//classe galinha
class galinha{
    private string nomeGalinha;
    private int numOvo;

    //metdo galinha
    public galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }


    //retorna a classe ovo 
  
    public Ovo botar(){
        numOvo++; //numero ovo da galinha
        return new Ovo(numOvo, nomeGalinha); //retorna a cada ovo novo seu numero e a qual galinha pertence
    }
}

//classe ovo
class Ovo{
    private int numOvo;
    private string minhaGalinha;

    //metodo ovo
    public Ovo(int numOvo, string minhaGalinha){//recebe o numero do ovo e a qual galinha pertence
        //atribui o nome da galinha e numero de ovo as variaveis abaixo e em seguinda mostr as informações 
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("ovo criado: {0}\nGalinha: {1}",numOvo,minhaGalinha);
    }
}



class aula46{
    static void Main(){
        galinha g1 = new galinha("cocorico");
        galinha g2 = new galinha("cocorico2");
        galinha g3 = new galinha("cocorico3");

        g1.botar();//retorna 1 ovo para essa galinha 

        g1.botar();
        g1.botar();
        g3.botar();
        g2.botar();
    }
}