using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepper
{
    class Dinamica
    {
        public Int32 Id { set; get; }
        public Docente Professor { set; get; }
        private List<Rodada> Rodadas { set; get; }
        private List<Grupo> Grupos { set; get; }
        private List<Participante> Participantes { set; get; }

        public Dinamica() { }

        public void AdicionarParticipante(Participante participante)
        {
            Participantes.Add(participante);
        }

        public void GerarRodadasEGrupos() { }
        public void GerarCartoes() { }
    }
}
