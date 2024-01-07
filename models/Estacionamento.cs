using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO.models
{
    public class Estacionamento
    {
                private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> listaVeiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
       
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();
                  if (listaVeiculos.Any(x => x.ToUpper() == placa)){
                    Console.WriteLine("Este veículo já está estacionado!!");
                  }else{
                    listaVeiculos.Add(placa); 
                    Console.WriteLine("Veículo adicionado com sucesso!!");}
            }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
        
               string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (listaVeiculos.Any(x => x.ToUpper() == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
               int.TryParse(Console.ReadLine(), out int horas);
                decimal  valorTotal = precoInicial + precoPorHora * horas;
                
                listaVeiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (listaVeiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                int contador = 0;
                foreach (string item in listaVeiculos){
                    Console.WriteLine($"Lista de veículos estacionados: {contador} - {item}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}