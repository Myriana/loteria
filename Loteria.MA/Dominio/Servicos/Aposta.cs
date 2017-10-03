using Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Modelos;
using Dominio.Contexto;

namespace Dominio.Servicos
{
    public class Aposta : IAposta
    {
        public ContextoMega contexto;
        public Aposta()
        {
            contexto = new ContextoMega();
        }

        public void CadastrarApostaMegaSena(MegaSenaModel ms)
        {
            contexto.CadastrarMegaSena(ms);
        }

        public List<MegaSenaModel> ObterTodasMegaSenas()
        {
            return contexto.ObterTodasMegaSenas();
        }

        public MegaSenaModel ObterUltimaMegaSena()
        {
            return contexto.ObterUltimaMegaSena();
        }
    }
}
