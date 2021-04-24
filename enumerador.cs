using System;

class aula10{

    enum diasSemana{ domingo, segunda, terca, quarta, quinta, sexta, sabado};
    static void Main(){

        diasSemana ds = diasSemana.domingo; // ds é a variavel que pega o valor especifico do dia da semana        
        Console.WriteLine(ds);
        
        diasSemana ds2 = (diasSemana)3; // ds2 e a variavel que pega o valor da semna no indice 3 = quarta 
        Console.WriteLine("volor do indece 3 é igual a: {0}",ds2);

        int ds3 = (int)diasSemana.segunda;// recebe o indice em numero em que o dia esta
        Console.WriteLine("a posiçao de segunda em numero e: {0} ",ds3); 



}

}