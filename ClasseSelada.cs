using System;

sealed class pessoa{//classe selada nao pode ser hedada

}

class aluno : pessoa{//esse codigo da erro justamente por nao poder herdar uma classe sealed

}

class aula40
{
    static void Main()
    {
        aluno cleidson = new aluno();
    }
}

