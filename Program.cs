using Projeto_final_PARTE1.Models;


decimal valorInicial;
decimal valorHora;

Console.WriteLine("Seja bem vindo ao estacionamento!");
Console.WriteLine($"Digite o valor inicial: ");
valorInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Digite o valor da hora: ");
valorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(valorInicial, valorHora);    

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu){
    Console.Clear();
    Console.WriteLine("Digite 1 para cadastrar veículo");
    Console.WriteLine("Digite 2 para removaer veículo");
    Console.WriteLine("Digite 3 para listar veículos");
    Console.WriteLine("Digite 4 para encerrar");

    
    switch( Console.ReadLine()){
        case "1":
            estacionamento.cadastrarVeiculo();
            break;
        case "2":
            estacionamento.removerVeiculo();
            break;
        case "3":
            estacionamento.listarVeiculos();
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }

}