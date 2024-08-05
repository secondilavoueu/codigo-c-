using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Carro
    {
        public string nome;
        public string modelo;
        public int ano;
        public string cor;
        public int velocidade;


        // Construindo a classe Carro

        public Carro(string nome, string modelo, int ano, string cor, int velocidade)
        {
            this.nome = nome;
            this.modelo = modelo;
            this.ano = ano;
            this.cor = cor;
            this.velocidade = velocidade;
        }

        // Método para exibir informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("Cor: " + cor);
            Console.WriteLine("Velocidade: " + velocidade);
        }

        // Método para ligar o carro
        public void Ligar()
        {
            Console.WriteLine("O carro " + nome + " do " + modelo + " do ano " + ano + " com a cor " + cor + " e com a velocidade atual de " + velocidade + "km/h" + " está ligado.");

        }

    }
}

