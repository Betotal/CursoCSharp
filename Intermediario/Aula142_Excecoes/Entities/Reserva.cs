using System;
using Aula142_Excecoes.Entities.Exceptions;

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
            if (checkOut <= checkIn)
            {
                throw new DomainException("Data de Check-out deve ser maior que a data de entrada");
            }
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
            DateTime now = DateTime.Now;
            if (now > checkin || now > checkout)
            {
                throw new DomainException("Reserva só é permitida para datas futuras"); 
                // throw -> Lança nova instância de Exceção
                // assim como o return, throw encerra o método 
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Data de Check-out deve ser maior que a data de entrada");
            }
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
