
using System;
using System.Linq;



namespace cadastroProduto
{
    public static class Program
    {
        public static void Main(){
            
            Console.WriteLine("sistema de cadastro de produtos"); 
            Produto produto = new Produto();
            produto.cadastrarPro();
            produto.exibirProduto();

        }
        class Produto{
            public string Nome {get;set;}
            public string Categoria {get;set;}
       

        public void cadastrarPro(){
            Console.WriteLine("Digite o nome do produto:");
             Nome = Console.ReadLine();
             Console.WriteLine("Digite a categoria do produto:");
             Categoria = Console.ReadLine();
        }
        public void exibirProduto(){
            Console.WriteLine($"Nome do produto: {Nome}");
            Console.WriteLine($"Categoria do produto: {Categoria}");

        }
    
      }

    }
}
