namespace hotel.models
{
    public class Pessoa
    {
        public string? Nome;
        public string? Sobrenome;

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}