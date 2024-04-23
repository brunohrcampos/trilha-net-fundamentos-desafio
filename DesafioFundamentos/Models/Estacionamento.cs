using System.Diagnostics.Contracts;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            
            // Verifica se a variável placa é válida (Não é nula,vazia ou apenas espaços em brancos)
            if(!string.IsNullOrWhiteSpace(placa) && !veiculos.Contains(placa)){

                //adiciona a placa a lista e emite uma mensagem de veículo estacionado.
                veiculos.Add(placa);
                Console.WriteLine ("Veículo estacionado com sucesso!");
                
            }
            else{
                Console.WriteLine ("Veículo já se encontra estacionado ou a placa digitada é inválida! Tente novamente.");
            }

            }
        
       public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

        //Implementado
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Contains(placa))
            {
                marcadorGoto:

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int qtdHorasEstacionado;

                    if (!int.TryParse(Console.ReadLine(), out qtdHorasEstacionado)) {

                    Console.WriteLine ("Valor inválido para horas estacionadas");
                    goto marcadorGoto;
                     }

                //calcula o valor total do tempo estacionado.
                decimal valorTotal = precoInicial + (precoPorHora * qtdHorasEstacionado); 

                //remove o veiculo 
                veiculos.Remove(placa);

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
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               
            for(int i = 0; i < veiculos.Count; i++){

                Console.WriteLine($"{veiculos[i]}");
            }
            
        
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }}

