using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //class Produtos
        //{
        //    public string Codigo;
        //    public string Descricao;
        //    public int Preco;
        //    public int Unidades;

        //    public void Dados(string codigo, string descricao, int preco, int unidades)
        //    {
        //        Codigo = codigo;
        //        Descricao = descricao;
        //        Preco = preco;
        //        Unidades = unidades;

        //    }
        //}
  

        public class Produtos
            
        {
            public string Codigo;
            public string Descricao;
            public float Preco;
            public int Quantidade;
            public string Unidades;

            public Produtos(string codigo, string descricao, float preco, int quantidade, string unidades)
            {
                Codigo = codigo;
                Descricao = descricao;
                Preco = preco;
                Quantidade = quantidade;
                Unidades = unidades;
            }

            public string DadosFormatados()
            {
                return String.Format($"| {Codigo, -13} | {Descricao, -18} | R${Preco, 8} | {Quantidade,8:F2} {Unidades, -5}| R${Preco*Quantidade,10:F2}|");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("|    Código     |     descrição      | Preço (R$) | Quant.Estoque | Preço Total |");
            Console.WriteLine("---------------------------------------------------------------------------------");

            Produtos[] vetprod = new Produtos[]{
                new Produtos("7891025101604","Leite",3.00f,15,"l"),
                new Produtos("7891000120101","Creme de Leite",3.70f,28,"lt"),                                                                             
                new Produtos("7891000100103","Leite Condensado",4.50f,23,"cx"),
                new Produtos("7891000105016","Barra Cereal",3.20f,18,"und"),
                new Produtos("7897236904805","Água",2.15f,32,"cx"),
                new Produtos("7891150036567","Caldo de galinha",1.35f,12,"cx"),
                new Produtos("7891999000538","Iogurte",2.60f,25,"und"),
                new Produtos("7896051126041","Leite Fermentado",1.80f,33,"und"),
                new Produtos("7622300830083","Biscoito Recheado",1.90f,13,"und"),
                new Produtos("4005900036728","Desodorante",11.10f,14,"und"),
                new Produtos("7896185989819","VitaminaC",35.20f,16,"und"),
                new Produtos("7898113811452","Lanche",9.50f,19,"und")
            };
            double valor = 0;
            for (int i = 0; i < vetprod.Length; i++)
            {
                Console.WriteLine(vetprod[i].DadosFormatados());
                valor += vetprod[i].Preco * vetprod[i].Quantidade;  
             
            }
               
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine($"|                                             Quantidade Total: {valor, 12:F2} |");
            Console.WriteLine("---------------------------------------------------------------------------------");
         

           /* Produtos prod1 = new Produtos()
            {
                Codigo = "7891025101604", Descricao = "Leite", Preco = 3, Quantidade = 15, Unidades = "l"
            };
            Console.WriteLine(prod1.DadosFormatados());
        */
        }
    }
}
