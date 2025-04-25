using CP2_Julio_Joao_Lucas_Csharp.Models;

namespace CP2_Julio_Joao_Lucas_Csharp.Services
{
    public class AgendaService
    {
        public List<Paciente> Pacientes { get; private set; }
        public List<Medico> Medicos { get; private set; }
        public Dictionary<int, Consulta> Consultas { get; private set; }

        private int consultaIdCounter = 1;

        public AgendaService()
        {
            Pacientes = new List<Paciente>();
            Medicos = new List<Medico>();
            Consultas = new Dictionary<int, Consulta>();
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }

        public void CadastrarMedico(Medico medico)
        {
            Medicos.Add(medico);
        }

        public void AgendarConsulta(int pacienteId, int medicoId, DateTime dataHora)
        {
            var paciente = Pacientes.FirstOrDefault(p => p.Id == pacienteId);
            var medico = Medicos.FirstOrDefault(m => m.Id == medicoId);

            if (paciente != null && medico != null)
            {
                var consulta = new Consulta(consultaIdCounter++, paciente, dataHora);
                medico.AdicionarConsulta(consulta);
                Consultas[consulta.Id] = consulta;
                Console.WriteLine("Consulta agendada com sucesso!");
            }
            else
            {
                Console.WriteLine("Paciente ou Médico não encontrado!");
            }
        }

        public void ListarConsultas()
        {
            foreach (var medico in Medicos)
            {
                Console.WriteLine($"\nMédico: {medico.Nome} ({medico.Especialidade})");

                foreach (var consulta in medico.Consultas)
                {
                    Console.WriteLine($"Consulta #{consulta.Id} - Paciente: {consulta.Paciente.Nome}, Data/Hora: {consulta.DataHora}");
                }
            }
        }

        public void RelatorioDiario(DateOnly data)
        {
            var consultasHoje = Consultas.Values
                .Where(c => DateOnly.FromDateTime(c.DataHora) == data)
                .OrderBy(c => c.DataHora)
                .ToList();

            if (!consultasHoje.Any())
            {
                Console.WriteLine("Nenhuma consulta para o dia selecionado.");
                return;
            }

            Console.WriteLine($"\nRelatório de {data}:");
            Console.WriteLine($"Total de Consultas: {consultasHoje.Count}");

            Console.WriteLine($"Primeira Consulta: {consultasHoje.First().DataHora}");
            Console.WriteLine($"Última Consulta: {consultasHoje.Last().DataHora}");

            var intervalos = new List<TimeSpan>();
            for (int i = 1; i < consultasHoje.Count; i++)
            {
                intervalos.Add(consultasHoje[i].DataHora - consultasHoje[i - 1].DataHora);
            }

            if (intervalos.Count > 0)
            {
                var intervaloMedio = new TimeSpan((long)intervalos.Average(ts => ts.Ticks));
                Console.WriteLine($"Intervalo Médio: {intervaloMedio.TotalMinutes:F1} minutos");
            }
        }
    }
}
