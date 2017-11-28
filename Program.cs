using System;
using System.Collections.Generic;
using System.Linq;

namespace lambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1
            /*List<string> cidades = new List<string>();
            cidades.Add("Campinas");
            cidades.Add("Guarulhos");
            cidades.Add("Salvador");
            cidades.Add("Belo Horizonte");

            var cid = cidades.Where(x => x.Length < 10);
            foreach(string t in cid)
                Console.WriteLine(t.ToUpper());;*/

            //Exemplo 2
            /*List<Alunos> aluno = new List<Alunos>(){
                new Alunos{Id=20, Nome="Fernanda",Email="fernanda@terra.com.br",Idade=20},
                new Alunos{Id=15, Nome="Tadeu",Email="tadeu@terra.com.br",Idade=55},
                new Alunos{Id=56, Nome="Pablo",Email="pablo@terra.com.br",Idade=18},
                new Alunos{Id=68, Nome="Martha",Email="marthaa@terra.com.br",Idade=28}
            };
            
            var al = from x in aluno where x.Idade >20 && x.Idade <50 select x;
            foreach(Alunos w in al)
                Console.WriteLine(w.Nome+","+w.Email+","+w.Idade);*/

            
        }
    }
}
