using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class MegaSenaModel
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public List<int> numeros { get; set; }
       
    }
}
