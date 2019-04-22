using System;

namespace Aula142_Excecoes.Entities
{
    class Reserva
    {
        public int NumQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva()
        {
        }

        public Reserva(int numQuarto, DateTime checkIn, DateTime checkOut)
        {
            NumQuarto = numQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;

        }

        public void UpdateReserva(DateTime checkin, DateTime checkout)
        {
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Numero do Quarto: "
                 + NumQuarto
                 + ", check-in: "
                 + CheckIn.ToString("dd/MM/yyyy")
                 + ", check-out: "
                 + CheckOut.ToString("dd/MM/yyyy")
                 + ", "
                 + Duracao()
                 + " noites.";
        }
    }
}
