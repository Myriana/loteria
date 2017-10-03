using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos
{
    public interface IAposta
    {
        void CadastrarApostaMegaSena(MegaSenaModel ms);
        List<MegaSenaModel> ObterTodasMegaSenas();
        MegaSenaModel ObterUltimaMegaSena();
    }
}
