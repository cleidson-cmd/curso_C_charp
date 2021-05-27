using System;

class aula27
{
    static void Main()
    {
       // soma(4, 6);
        soma2();
        soma2(1);
        soma2(4, 4, 4, 4); 

       /*  static void soma(int n1, int n2)
        {//soma simples com 2 argumentos
            int ress = n1 + n2;
            Console.WriteLine("a soma entre {0} e {1} é {2}", n1, n2, ress);
        } */


        static void soma2(params int[] n)
        {//soma com varios argumentos chamada n ou array n pode ter de nenhuma a varios argumentos
            int res = 0;

            if (n.Length < 1)
            {
                Console.WriteLine("nenhum valor a ser somado");
            }

            else if (n.Length < 2)
            {
                Console.WriteLine("valores insuficientes para soma {0}", n[0]);
            }

            else
            {
                for (int i = 0; i <= n.Length; i++)
                {
                    res += n[i];
                }

                Console.WriteLine("a soma dos valores é {0} e", res);

            }




        }

    }
}
