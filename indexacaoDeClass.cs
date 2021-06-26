using System;
namespace aula42
{
    class Car
    {
        private int[] vlMax = new int[5] { 80, 120, 260, 280, 300 };

        public int this[int i]//indexando o array
        {
            get
            {//apenas leitura /mostra o que tem pega valor existente
                return vlMax[i];
            }
            set
            {//permite a insersao de valor novo ex: input 
                if (value < 0)
                {
                    vlMax[i] = 0;
                }
                else if (value > 300)
                {
                    vlMax[i] = 300;
                }
                else
                {
                    vlMax[i] = value;
                }
            }


        }





    }

    class aula41
    {
        static void Main()
        {
            Car carro11 = new Car();
            carro11[3] = 390;//tribuindo 390 na posiçao 3

            Console.WriteLine("velocidade {0}", carro11[3]);//lendo a posicao 3
        }
    }
}




