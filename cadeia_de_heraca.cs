using System;

namespace aula35
{
    class veiculos
    {

        public int rodas;

        public int velMax;

        public bool ligado;

        public veiculos(int rodas)
        {
            this.rodas = rodas;
        }

        public void ligar()
        {
            ligado = true;
        }

        public void desligar()
        {
            ligado = false;
        }

        public void setRodas(int rodas){//limitado valor max 40 e min 0 de quatidades de rodas
            if (rodas <0){
                this.rodas = 0;
            }else if (rodas > 40){
                this.rodas = 40;
            }else{
                this.rodas = rodas;
            }
        }

        public string GetLigado()
        {
            return (ligado? "sim":"nao");//operador ternario equivale a if e else
            /* if (ligado)
            {
                return "Sim";
            }
            else
            {
                return "Nao";
            } */
        }

        public int GetRodas(){
            return rodas;
        }


    }

    class carro : veiculos
    {//classe derivada herda a classe base que é veiculos

        public string nome;
        public string cor;

        public carro(string nome, string cor): base(4) //esta herdando a classe base para acessar
                                                    //4 seria o argumento do metodo rodas ja que ele tem que ter 1 argumento
        {
            this.cor = cor;
            this.nome = nome;
            desligar();
            rodas = 4;
            velMax = 120;
        }

    }


    public class aula35
    {

        static void Main()
        {
            carro car = new carro("Lamborguine", "preto");

            carroCombate carcom = new carroCombate();

            //car.ligar() = true;//consigo acessar ligar que pertence a veiculos que carro esta herdando porque esta public
            Console.WriteLine("nome-------:{0}", car.nome);
            Console.WriteLine("cor--------:{0}", car.cor);
            Console.WriteLine("velocidade-:{0}", car.velMax);
            Console.WriteLine("Lgado------:{0}", car.GetLigado());
            if (car.ligado == false)
            {
                car.ligado = true;
            }
            Console.WriteLine("Lgado------:{0}", car.GetLigado());
            Console.WriteLine("rodas------:{0}", car.GetRodas());

            Console.WriteLine("\n==========================================\n");

            Console.WriteLine("nome-------:{0}", carcom.nome);
            Console.WriteLine("cor--------:{0}", carcom.cor);
            Console.WriteLine("velocidade-:{0}", carcom.velMax);
            Console.WriteLine("Lgado------:{0}", carcom.GetLigado());
            if (car.ligado == false)
            {
                car.ligado = true;
            }
            Console.WriteLine("Lgado------:{0}", carcom.GetLigado());
            Console.WriteLine("rodas------:{0}", carcom.GetRodas());
            Console.WriteLine("Muniçao----:{0}", carcom.Monicao);


            if (car.ligado == true)
            {
                car.ligado = false;
            }
        }
    }
//
    class carroCombate:carro{//carroCombate é derivado da classe carro que é sua classe base
       public int Monicao;
       public carroCombate():base("carro de combate", "vermelho"){//os argumentos da classe base que é carro(nome e cor)
            Monicao = 100;
            setRodas(6);
        }
        
    }
}

