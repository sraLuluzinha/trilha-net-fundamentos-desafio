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
            string placa=Console.ReadLine();
            veiculos.Add(placa);
          
             Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
           

            string placa =  Console.ReadLine();

            
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

               int horas = 0;
               while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
    Console.WriteLine("Por favor, insira um número válido de horas.");
                }

                decimal precoInicial = 5.00m; 
                decimal precoPorHora = 2.00m; 
                decimal valorTotal = precoInicial + precoPorHora * horas;

Console.WriteLine($"O valor total a pagar é: R${valorTotal}");


                 veiculos.Remove(veiculos.First(x => x.ToUpper() == placa.ToUpper()));

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                  foreach (string veiculo in veiculos)
                  {
                    Console.WriteLine(veiculo);
                  }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
