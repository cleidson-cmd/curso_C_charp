using System;

class calc(){
    //sobrcarga de metodos são mais de um metodo com o mesmo nome porem com quantiddes de argumentos diferentes
    //pode ser com tipos diferentes
    public int soma(int n1, int n2){
        return n1 + n2;
    }
    

    public int soma(double n1, double n2, double n3){
        return n1 + n2 + n3;
    }
    
    //passando parametos dinamico 
    public int soma(params double[]n){
        double soma;
        for (int i = 0; i <= n.Length; i++){
            soma += n[i];            
        }
        return soma;
        
    }
    
}




class aula47
{
    static void main(){

    var res;
    calc Calc = new calc();
    res = Calc.soma(3,7);
    console.WriteLine(res);

    }
}