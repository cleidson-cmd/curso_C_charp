using System;


class casal{
    public string nomeBoy;
    public string nomeGirl;
    public int qtdBeijo;

    public casal(string nomeBoy, string nomeGirl){
        this.nomeBoy = nomeBoy;
        this.nomeGirl = nomeGirl;
        qtdBeijo = 0;
        return ;

    }

    public beijo beijar(){
        qtdBeijo++;
        return new beijo(nomeBoy, nomeGirl, qtdBeijo);
    }

    public class beijo{

        public string nomeBoy; 
        public string nomeGirl;
        public int qtdBeijo;

   

        public beijo(string nomeBoy,string nomeGirl,int qtdBeijo){
            this.nomeBoy = nomeBoy;
            this.nomeGirl = nomeGirl;
            this.qtdBeijo = qtdBeijo;
            Console.WriteLine("========================================");
            Console.WriteLine("Boy: {0}\nGirl: {1}\nCasal com: {2} beijos",nomeBoy,nomeGirl,qtdBeijo);
            Console.WriteLine("========================================");
           
        }



    }


    class principal{
        public static void Main(){
            casal casal01 = new casal("veinho", "leleide");
            casal casal02 = new casal("cleisinho", "jessika");
            casal casal03 = new casal("joao", "maria");

            casal01.beijar();
            casal03.beijar();
            casal02.beijar();
            casal03.beijar();
            casal02.beijar();

        }
    }
}
