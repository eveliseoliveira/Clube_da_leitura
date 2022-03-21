using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ConsoleApp
{
    internal class Reserva
    {
        public enum DiasRevistas { Regular, Novidade }

        public Reserva()
        {
            this.Nome_reserva = "";
            this.Dias_reserva = 1;
            this.Revista_reserva = "";

        }

        public Reserva(String nome_reserva, int dias_reserva, String revista_reserva)
        {
            this.Nome_reserva = nome_reserva;
            this.Dias_reserva = dias_reserva;
            this.Revista_reserva = revista_reserva;
        }

        private String nome_reserva;

        public String Nome_reserva
        {
            get { return nome_reserva; }
            set { nome_reserva = value.ToUpper(); }
        }

        private int dias_reserva;

        public int Dias_reserva
        {
            get { return dias_reserva; }
            set
            {
                if (value >= 0) dias_reserva = value;
                else
                {
                    throw new Exception("Permitido apenas numeros positivos!");
                }
            }
        }

        private String revista_reserva;

        public String Revista_reserva
        {
            get { return revista_reserva; }
            set { revista_reserva = value.ToUpper(); }
        }

        public Reserva reserva
        {
            get;
            set;
        }

        public DiasRevistas Dias_revista { get; set; }

    }
}
