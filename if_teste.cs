using System;

class aula13{

    static void Main(){
        int n1, n2, n3, n4, res;
        res=n1=n2=n3=n4=0; //atribundo 0 a todas as variveis
        float media = 0;
        string resultado = "reprovado";

        Console.Write("digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());


        res = n1 + n2 + n3 + n4;

        media = (float)res / 4;

        if (res >= 60){
            if (res >= 90){
                resultado = "aprovado com nota alta. parabens!";
            }
            else{
            resultado = "aprovado!!";
            }
        }

        else if(res >= 40){
            resultado = "recuperaçao!!";
        }

        else{
            if (res >= 38 & res < 40){
                resultado = "reprovado. quase conseguia ir para recuperaçao";
            }else{
                resultado = "reprovado!!";
            }
        }

        Console.WriteLine("Soma: {0}\nResultado: {1}\nMedia: {2}",res ,resultado, media);
    }
}