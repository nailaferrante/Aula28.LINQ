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

            //Exemplo 2 - Linq
            /*List<Alunos> aluno = new List<Alunos>(){
                new Alunos{Id=20, Nome="Fernanda",Email="fernanda@terra.com.br",Idade=20},
                new Alunos{Id=15, Nome="Tadeu",Email="tadeu@terra.com.br",Idade=55},
                new Alunos{Id=56, Nome="Pablo",Email="pablo@terra.com.br",Idade=18},
                new Alunos{Id=68, Nome="Martha",Email="marthaa@terra.com.br",Idade=28}
            };
            
            var al = from x in aluno where x.Idade >20 && x.Idade <50 select x;
            foreach(Alunos w in al)
                Console.WriteLine(w.Nome+","+w.Email+","+w.Idade);*/

            //Exemplo 3 - Linq com Lambda
            /*List<Alunos> aluno = new List<Alunos>(){
                new Alunos{Id=20, Nome="Fernanda",Email="fernanda@terra.com.br",Idade=20},
                new Alunos{Id=15, Nome="Tadeu",Email="tadeu@terra.com.br",Idade=55},
                new Alunos{Id=56, Nome="Pablo",Email="pablo@terra.com.br",Idade=18},
                new Alunos{Id=68, Nome="Martha",Email="marthaa@terra.com.br",Idade=28}
            };
            var al = aluno.Where(z=> z.Idade>20 && z.Idade< 50);
            foreach(var p in al)
                Console.WriteLine(p.Nome);*/

            //Exemplo 4 
            /*List<Alunos> aluno = new List<Alunos>(){
                new Alunos{Id=20, Nome="Fernanda",Email="fernanda@terra.com.br",Idade=20},
                new Alunos{Id=15, Nome="Tadeu",Email="tadeu@terra.com.br",Idade=55},
                new Alunos{Id=56, Nome="Pablo",Email="pablo@terra.com.br",Idade=18},
                new Alunos{Id=68, Nome="Martha",Email="marthaa@terra.com.br",Idade=28}
            };
            var al = from b in aluno where b.Email.Contains("terra") orderby b.Id descending select b ; // orderby = ordernar e descending = decrescente
            foreach(var p in al)
                Console.WriteLine(p.Nome);*/

            //Exemplo 5
            /*List<Alunos> aluno = new List<Alunos>(){
                new Alunos{Id=20, Nome="Fernanda",Email="fernanda@terra.com.br",Idade=20},
                new Alunos{Id=15, Nome="Tadeu",Email="tadeu@terra.com.br",Idade=55},
                new Alunos{Id=56, Nome="Pablo",Email="pablo@terra.com.br",Idade=18},
                new Alunos{Id=68, Nome="Martha",Email="marthaa@terra.com.br",Idade=28}
            };
            var al = aluno.Count( x => x.Email.Contains("terra")); // Count = contar
                Console.WriteLine(al);*/

            //Exemplo 6 = Exemplo de join
            List<Produtos> prod = new List<Produtos>(){
                new Produtos {idProduto = 1, NomeProduto = "Lápis", Preco = 2, idFornecedor = 30},
                new Produtos {idProduto = 2, NomeProduto = "Borracha", Preco = 5, idFornecedor = 41},
                new Produtos {idProduto = 3, NomeProduto = "Caneta", Preco = 6, idFornecedor = 30},
                new Produtos {idProduto = 4, NomeProduto = "Caderno", Preco = 20, idFornecedor = 41}
            };

            List<Fornecedor> forne = new List<Fornecedor>(){
                new Fornecedor{idFornecedor = 30, RazaoSocial = "Faber Castel", Telefone = "111"},
                new Fornecedor{idFornecedor = 41, RazaoSocial = " Bic", Telefone = "222"},
                new Fornecedor{idFornecedor = 51, RazaoSocial = "Chameco", Telefone = "333"}
            };
            var resultado = prod.Join(
                forne,
                p => p.idFornecedor, // o join espera o nome dos campos que são idênticos
                f => f.idFornecedor,
                (p,f) => new {
                    pNome = p.NomeProduto,
                    fRazao = f.RazaoSocial
                }
            );
            foreach(var x in resultado)
                Console.WriteLine(x.pNome + " - " + x.fRazao);
        }
    }
}
