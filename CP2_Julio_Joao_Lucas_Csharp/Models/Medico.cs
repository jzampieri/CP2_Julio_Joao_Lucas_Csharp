namespace CP2_Julio_Joao_Lucas_Csharp.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public List<Consulta> Consultas { get; private set; }

        public Medico(int id, string nome, string especialidade)
        {
            Id = id;
            Nome = nome;
            Especialidade = especialidade;
            Consultas = new List<Consulta>();
        }

        public void AdicionarConsulta(Consulta consulta)
        {
            Consultas.Add(consulta);
        }
    }
}
