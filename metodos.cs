using System;


class aula24
{
    static void Main()
    {
        int v1 = Convert.ToInt32(Console.ReadLine());
        int v2 = Convert.ToInt32(Console.ReadLine());
        ola();//chamando o metodo ola
        soma(v1, v2);
        int pega = subtracao(v1, v2);//pegando o retorno do metodo adicao e guardando na variavel pega
        Console.WriteLine("retorno do metodo subtracao: {0}", pega);
    }


    static void ola()//criando o metodo ola
    {
        Console.WriteLine("Ola mundo!");
    }

    static void soma(int n1, int n2){//metodos com o void nao retorna nada
        int res = n1 + n2;
        Console.WriteLine("soma entre {0} e {1} = {2}",n1, n2, res);
        Console.WriteLine("tabuada de {0}", n1);

        for (int i =0; i < 11; i++){//cauculando a tabuada
            res = n1 * i;
            Console.WriteLine("{0} X {1} = {2}",i,n1,res);
        }
    }

    static int subtracao(int r1, int r2){//metodos sem void pode retornar alguma coisa
                                        //nesse caso retorna o res 
        int res = r1 - r2;
        return res;
    }


}
