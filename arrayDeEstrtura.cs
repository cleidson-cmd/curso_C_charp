using System;


struct caRRo{
    public string cor;
    public string modelo;
    public string marca;

    public caRRo(string cor, string modelo,string marca){
        this.cor = cor;
        this.modelo = modelo;
        this.marca = marca;
    }

    public void info(){
        Console.WriteLine(this.cor = "goodlock");
        Console.WriteLine(this.modelo = "inform");
        Console.WriteLine(this.marca = "ola");
        Console.WriteLine("--------------------------------");
    }
}
class aula45{
    public static void Main(){
        caRRo c1 = new caRRo("vermelho","modelo03", "marralo");
        caRRo[] carros = new caRRo[6];//array com limite de 6 
        
        c1.info();

        carros[0].cor = "amarelo";
        carros[0].modelo = "model0008";
        carros[0].marca = "marac03";

        carros[1].cor = "amarelo";
        carros[1].modelo = "model0008";
        carros[1].marca = "marac03";

        carros[2].cor = "amarelo";
        carros[2].modelo = "model0008";
        carros[2].marca = "marac03";

        carros[3].cor = "amarelo";
        carros[3].modelo = "model0008";
        carros[3].marca = "marac03";

        //com for
        for (int i = 0; i<= carros.Length; i++ ){
            carros[i].info();
        }

        //sem for
        carros[0].info();
        carros[1].info();
        carros[2].info();
        carros[3].info();



    }
}