using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Teste.ConsoleApp.Reserva;

namespace Teste.ConsoleApp
{
    internal class ControleReserva
    {
        public class ListaDeReservas
        {

            private List<Reserva> reservas;
            public List<Reserva> Reservas
            {
                get
                {
                    return reservas;
                }
            }

            public ListaDeReservas()
            {
                reservas = new List<Reserva>();
            }

            public Boolean InserirReserva(Reserva reserva)
            {
                Boolean resultado = true;
                try
                {
                    Reserva r = reservas.Find(x => x.Dias_reserva == reserva.Dias_reserva);

                    if (r == null)
                    {
                        reservas.Add(reserva);
                    }
                    else
                    {
                        resultado = false;
                    }
                }
                catch (Exception erro)
                {
                    resultado = false;
                }
                return resultado;
            }
            public Boolean AlterarReserva(Reserva reserva)
            {
                Boolean resultado = false;
                Reserva r = reservas.Find(x => x.Dias_reserva == reserva.Dias_reserva);
                if (r != null)
                {
                    r.Nome_reserva = reserva.Nome_reserva;
                    r.Dias_reserva = reserva.Dias_reserva;
                    r.Revista_reserva = reserva.Revista_reserva;
                    resultado = true;
                }
                return resultado;
            }
            public Boolean ExcluirReserva(int dias_reserva)
            {
                Boolean resultado = false;
                Reserva r = reservas.Find(x => x.Dias_reserva == dias_reserva);
                if (r != null)
                {
                    resultado = reservas.Remove(r);
                }
                return resultado;
            }
            public List<Reserva> LocalizarReserva(String nome_reserva)
            {
                List<Reserva> localizar_reserva = reservas.FindAll(x => x.Nome_reserva.Contains(nome_reserva.ToUpper()));
                return localizar_reserva;
            }

            public List<Reserva> ListarPorCategoria(DiasRevistas dias_revista)
            {
                List<Reserva> localizar_reserva = reservas.FindAll(x => x.Dias_revista.Equals(dias_revista));
                return localizar_reserva;
            }
        }
    }
}
