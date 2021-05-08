using System;

class metodos_array
{
    static void Main()
    {

        Console.Clear();
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { { 11, 22, 33, 44, 55 }, { 66, 77, 88, 99, 100 } };// 2 dimensao == 2 grupos de array

        //numeros aleatorios ===========================

        Random randomm = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = randomm.Next(50);//next(max) /  next(min, max) / next()  qualquer valor sem limite ex: next(10, 20) min, max
        }
        Console.WriteLine("elemento do vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }



        //binarysearch(array,valor)


        Console.WriteLine("binarysearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);

        Console.WriteLine("Valor {0} esta na posiçao {1}", procurado, pos);
        Console.WriteLine("--------------------------------");




        //ar == array /public static void copy(ar_origem, ar_destino, qtde_elementos);

        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------");



        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);//copiando todos os dados do vertor um para o vetor3 a partir da posiçao 0
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("-----------------------------------");


        //public long getlonglenght(dimensao);
        Console.WriteLine("GetLongenght");
        long qtde_elementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("quantidades de elementos {0}", qtde_elementosVetor);
        Console.WriteLine("-------------------------------------");




        //public int GetLowerBound(dimenssao);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(1);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor Indece do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("---------------------------------------");



        //public int GetUpperBound(dimenssao);
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);//retorna o tamanho do array nesse caso 4 que sao as 5 posiçoes declarada na criaça do vetor    
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Menor Indece Do Vetor {0}", MaiorIndiceVetor);
        Console.WriteLine("---------------------------------------");


        //public object GetValue(long indice);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor da Posiçao 3 do vetor1: {0}", valor0);
        Console.WriteLine("---------------------------------------");


        //public static int IndexOf(array, valor);
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("---------------------------------------");


        //public static int LastIndexOf(array, valor);
        Console.WriteLine("astIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("indice do ultimo valor 33: {0}", indice2);
        Console.WriteLine("---------------------------------------");



        //public static void reverse(array);
        Console.WriteLine("reverse");
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("---------------------------------------");


        //public void SetValue(object valor, long pos);

        Console.WriteLine("SetValue");
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }

        Console.WriteLine("vetor 2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }


        //public static void sort(array);

        Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);


        Console.WriteLine("vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("\nvetor2");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }


        Console.WriteLine("\nvetor3");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }

    }
}