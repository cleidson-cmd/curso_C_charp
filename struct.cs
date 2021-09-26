using System;

struct caRro{
    public string cor;
    public string modelo;
    public string marca;

    public caRro(string cor, string modelo,string marca){
        this.cor = cor;
        this.modelo = modelo;
        this.marca = marca;
    }

    public void info(){
        Console.WriteLine(this.cor = "goodlock");
        Console.WriteLine(this.modelo = "inform");
        Console.WriteLine(this.marca = "ola");
    }
}
class aula44{
    public static void Main(){
        caRro c1;
        c1.cor = "blue";
        c1.modelo = "da boa";
        c1.marca = "good";

        Console.WriteLine("{0} = {1} = {2}",c1.modelo, c1.cor, c1.marca);

        caRro c2 = new caRro("novo", "ok", "ta certo");

        Console.WriteLine(c2.modelo);
        c2.info();

    }
}