using CP2_Julio_Joao_Lucas_Csharp.Models;
using CP2_Julio_Joao_Lucas_Csharp.Services;

class Program
{
    static void Main()
    {
        var agendaService = new AgendaService();

        while (true)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Cadastrar Paciente");
            Console.WriteLine("2. Cadastrar Médico");
            Console.WriteLine("3. Agendar Consulta");
            Console.WriteLine("4. Listar Consultas");
            Console.WriteLine("5. Gerar Relatório Diário");
            Console.WriteLine("6. Listar Pacientes");
            Console.WriteLine("7. Listar Médicos");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("\nNome do Paciente: ");
                    var nomePaciente = Console.ReadLine();
                    agendaService.CadastrarPaciente(new Paciente(agendaService.Pacientes.Count + 1, nomePaciente));
                    Console.WriteLine("Paciente cadastrado com sucesso!");
                    break;

                case "2":
                    Console.Write("\nNome do Médico: ");
                    var nomeMedico = Console.ReadLine();
                    Console.Write("Especialidade: ");
                    var especialidade = Console.ReadLine();
                    agendaService.CadastrarMedico(new Medico(agendaService.Medicos.Count + 1, nomeMedico, especialidade));
                    Console.WriteLine("Médico cadastrado com sucesso!");
                    break;

                case "3":
                    Console.WriteLine("\n--- Pacientes Cadastrados ---");
                    foreach (var paciente in agendaService.Pacientes)
                    {
                        Console.WriteLine($"ID: {paciente.Id} - Nome: {paciente.Nome}");
                    }

                    Console.WriteLine("\n--- Médicos Cadastrados ---");
                    foreach (var medico in agendaService.Medicos)
                    {
                        Console.WriteLine($"ID: {medico.Id} - Nome: {medico.Nome} - Especialidade: {medico.Especialidade}");
                    }

                    Console.Write("\nDigite o ID do Paciente: ");
                    if (!int.TryParse(Console.ReadLine(), out int pacienteId))
                    {
                        Console.WriteLine("ID inválido. Operação cancelada.");
                        break;
                    }

                    Console.Write("Digite o ID do Médico: ");
                    if (!int.TryParse(Console.ReadLine(), out int medicoId))
                    {
                        Console.WriteLine("ID inválido. Operação cancelada.");
                        break;
                    }

                    Console.Write("Digite a Data e Hora da Consulta (yyyy-MM-dd HH:mm): ");
                    if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataHora))
                    {
                        Console.WriteLine("Data/Hora inválida. Operação cancelada.");
                        break;
                    }

                    agendaService.AgendarConsulta(pacienteId, medicoId, dataHora);
                    break;

                case "4":
                    agendaService.ListarConsultas();
                    break;

                case "5":
                    Console.Write("\nDigite a data para o relatório (yyyy-MM-dd): ");
                    if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly dataRelatorio))
                    {
                        Console.WriteLine("Data inválida. Operação cancelada.");
                        break;
                    }
                    agendaService.RelatorioDiario(dataRelatorio);
                    break;

                case "6":
                    Console.WriteLine("\n--- Pacientes Cadastrados ---");
                    foreach (var paciente in agendaService.Pacientes)
                    {
                        Console.WriteLine($"ID: {paciente.Id} - Nome: {paciente.Nome}");
                    }
                    break;

                case "7":
                    Console.WriteLine("\n--- Médicos Cadastrados ---");
                    foreach (var medico in agendaService.Medicos)
                    {
                        Console.WriteLine($"ID: {medico.Id} - Nome: {medico.Nome} - Especialidade: {medico.Especialidade}");
                    }
                    break;

                case "0":
                    Console.WriteLine("\nSaindo do programa...");
                    return;

                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
