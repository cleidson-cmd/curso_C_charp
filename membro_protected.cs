using System;



    class veiculo
    {
        public int velAtual;//public posso acessar fora da classe
        private int velMax;//private so posso acessar dentro da classe classes derivadas nao acesa
        protected bool ligado;//so posso usar dentro da classe e classes derivadas podem acessar em casos de herança 

        public veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public bool getligado(){
            return ligado;
        }
        
        
        public int getVelMax(){
            return velMax;
        }

        public int getAtual(){
            return velAtual;
        }
    }

    class Carro : veiculo
    {
        string nome;
        public Carro(string nome, int vm) : base(vm)
        {//o parametro que entrar em vm do metodo carro ´sera o mesmo que
         //passara para classe base que é veiculo velmax
            this.nome = nome;
            ligado=true;
            }
        }
        
           
    }


    class Aula38
    {
        static void Main()
        {
            Carro car=new Carro("gallardo", 230);

            Console.WriteLine("Velocidade Max.....{0}",car.getVelMax());
            Console.WriteLine("Nome...............{0}",car.getAtual();
            Console.WriteLine("igado..............{0}",car.GetLigado());
            Console.WriteLine("igado..............{0}",car.nome);

        }
    }

