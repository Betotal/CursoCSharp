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
            GravaReserva(numQuarto, checkIn, checkOut);
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public string VerificaErro(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (now > checkin || now > checkout)
            {
                return "Reserva só é permitida para datas futuras";
            }
            if (checkout <= checkin)
            {
                return "Data de Check-out deve ser maior que a data de entrada";
            }
            return null;
        }

        public void GravaReserva(int numQuarto, DateTime checkIn, DateTime checkOut)
        { 
            NumQuarto = numQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
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
