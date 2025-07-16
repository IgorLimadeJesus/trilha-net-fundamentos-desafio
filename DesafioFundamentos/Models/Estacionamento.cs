namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 5;
        private decimal precoPorHora = 5;
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

            // Verifica se o veículo já está estacionado
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Desculpe, esse veículo já está estacionado.");
            }
            else
            {
                // Adiciona o veículo à lista de veículos
                veiculos.Add(placa);
                Console.WriteLine($"O veículo {placa} foi adicionado com sucesso!");
            }

        }

        public void RemoverVeiculo()
        {
            decimal valorTotal = 0;

            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;

                valorTotal = precoInicial + precoPorHora * horas;

                Console.WriteLine($"O veículo {placa} permaneceu por {horas} horas e o valor total é: R$ {valorTotal}");

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
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
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
