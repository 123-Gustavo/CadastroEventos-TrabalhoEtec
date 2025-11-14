using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEventos_TrabalhoEtec.Resources.Models
{
    public class Evento
    {
        public string nome { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public int numeroParticipantes { get; set; }
        public string local { get; set; }
        public double valorIngresso { get; set; }

        public int CalcularDuracaoDias
        {
            get => dataFim.Subtract(dataInicio).Days;
        }

        public double CalcularReceitaTotal
        {
            get => numeroParticipantes * valorIngresso;
        }
    }
}
