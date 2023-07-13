using ProjetoEstacionamento.Classes;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \n" +
                  "Digite o preço inicial: ");
double precoEstacionamento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora: ");
double precoHora = Convert.ToDouble(Console.ReadLine());

Estacionamento es = new Estacionamento(precoEstacionamento, precoHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Encerrar");
    int opcao = Convert.ToInt32(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            es.AdicionarVeiculo();
            break;

        case 2:
            es.RemoverVeiculo();
            break;

        case 3:
            es.ListarVeiculo();
            break;

        case 4:
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para contiuar");
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou");