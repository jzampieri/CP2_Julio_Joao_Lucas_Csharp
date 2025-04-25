namespace CP2_Julio_Joao_Lucas_Csharp.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Paciente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
