namespace CP2_Julio_Joao_Lucas_Csharp.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataHora { get; set; }
        public DateTime DataCriacao { get; set; }

        public Consulta(int id, Paciente paciente, DateTime dataHora)
        {
            Id = id;
            Paciente = paciente;
            DataHora = dataHora;
            DataCriacao = DateTime.Now;
        }
    }
}
