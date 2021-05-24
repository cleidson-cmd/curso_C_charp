using System;

class aula26{
        static void Main(){
            int divid, divis, quoc, rest;
            divid = 10;
            divis = 5;
            quoc = divide(divid, divis, out rest);//associando a variavel rest a resto com o out ambas em out



            Console.WriteLine("{0} / {1} quociente: {2} resto: {3}", divid, divis, quoc, rest);
    
    }

    static int divide(int dividendo, int divisor, out int resto){//out faz com que outra variavel de saida possa ser retornada pode ter vario out em um metodo
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }


}