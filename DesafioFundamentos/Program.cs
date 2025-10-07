using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial da vaga: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            Console.WriteLine("----Cadastrando veículo----\n");            
            es.AdicionarVeiculo();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("----Removendo veículo----\n");            
            es.RemoverVeiculo();
            break;

        case "3":

            Console.Clear();
            Console.WriteLine("----Listando veículos----\n");            
            es.ListarVeiculos();
            break;

        case "4":
            Console.WriteLine("---Ecerrando Sistema---\n");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("---Opção Invalida---\n");
            break;
    }

    Console.WriteLine("\n---Pressione ENTER para continuar---");
    Console.ReadLine();
}

Console.WriteLine("---Saindo do Sistema---");
