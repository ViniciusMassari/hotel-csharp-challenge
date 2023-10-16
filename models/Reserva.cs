namespace hotel.models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }
        public List<Pessoa> Hospedes;
        public Suite? Suite;
        public int DiasReservados;

        public void CadastrarHospede(Pessoa hospede)
        {
            if (Suite == null)
            {
                Console.WriteLine("Suíte ainda não cadastrada");
            }
            if (Suite?.Capacidade > Hospedes.Count)
            {
                Hospedes.Add(hospede);
                Console.WriteLine($"{hospede.Nome} {hospede.Sobrenome} cadastrado(a) com sucesso");
            }
            else
            {
                Console.WriteLine("Capacidade limite da suíte foi alcançada, não foi possível cadastrar o hóspede");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            if (Suite != null)
            {
                Console.WriteLine("Suíte já cadastrada");
            }
            Suite = suite;
            Console.WriteLine("Suíte cadastrada com sucesso");
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
            {
                Console.WriteLine("Suíte ainda não cadastrada");
                return 0.00M;
            }
            decimal totalDiaria = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                decimal desconto = Suite.ValorDiaria * 0.1M;
                return totalDiaria - desconto;
            }
            return totalDiaria;
        }
    }


}