using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        { //objetos Quadrado, Retangulo do tipo Quadrilatero

            
           
            //isso é 1 obj    // ISSO È UM CONSTRUTOR
            Quadrilatero Quadrado = new Quadrilatero(2,3);          //primeiro objeto
            Quadrilatero Retangulo = new Quadrilatero(5, 3);        //segundo objeto

            Console.WriteLine("Área do quadrado: " + Quadrado.calcularArea());
            Console.WriteLine("Área do quadrado: " + Retangulo.calcularArea());

            Console.ReadKey();
        }
    }
    // criamos esse objeto Quadrilatero
    public class Quadrilatero
    {
        //atributos
        public double Altura;
        public double Largura;

        //Método do Construtor
        public Quadrilatero(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }
        
        //outros métodos
        public double calcularArea()
        {
            return Altura * Largura;
        }

    }
}
//objeto pessoa tem nome e idade
// quando declara o objeto ele ainda não tem area da memoria, ao colocar o comando new  e ao colocar o construtor ele cria um valor (inicialmente vazia)
//.
//Só vou ter area na memoria apos estanciar o objeto
//.

// construtor cria a caixinha q guarda os valores?

//nos podemos definir nosso proprio tipo (tipo int, string) só que nesse tipo voce pode ter uma estrutura de dados maior