using System;
namespace aula43
{

    public interface Veiculo//interface veiculo
    {
        void Ligar();//chama asa funçoes criada na classe carro10 a baixo
        void Desligar();
        void Info();
    }

    public interface Combate
    {
        void Disparar();
    }
// herdando a interface combate e veiculo a classe carro10
    class carro10 : Veiculo, Combate{// para conseguir herdar uma interface é preciso ter todos os metodos que a interface tem. criado na classe
        public bool Ligado;
        private int Municao;
        public carro10(){
            setMunicao(100);
        }

        public void setMunicao(int qtde){
            this.Municao = qtde;
        }

        public void Ligar(){
            this.Ligado = true; 
        }

         public void Desligar(){
            this.Ligado = false; 
        }

        public void Info(){

        }

        public void Disparar(){

        }
    }

    class aula43
    {

        public static void Main()
        {

        }
    }
}