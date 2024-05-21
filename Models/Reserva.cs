namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        
        
        public Reserva()
        {
            Hospedes = new List<Pessoa>();
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            // verificar se a capacidade é igual ou maior que os hospedes da lista
            if (Suite.Capacidade >= Hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // implementando a exceção
                throw new Exception("O número de hospedes é maior que a capacidade da suite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // retorno da quantidade de hospedes
            return Hospedes.Count;
            
        }

        public decimal CalcularValorDiaria()
        {
            // calculo da diaria
            decimal valor = DiasReservados*Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.9m; // 10%
            }

            return valor;
        }
    }
}