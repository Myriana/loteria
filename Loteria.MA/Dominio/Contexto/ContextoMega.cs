using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contexto
{
    public class ContextoMega
    {
        private List<MegaSenaModel> megaSenas { get; set; }

        public ContextoMega()
        {
            megaSenas = new List<MegaSenaModel>();
        }

        public void CadastrarMegaSena(MegaSenaModel ms)
        {
            megaSenas.Add(ms);
        }
        public List<MegaSenaModel> ObterTodasMegaSenas()
        {
            return megaSenas;
        }

        public MegaSenaModel ObterUltimaMegaSena()
        {
            return megaSenas.OrderBy(x => x.id).LastOrDefault();
        }
    }
}
