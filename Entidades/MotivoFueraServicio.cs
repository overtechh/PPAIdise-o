using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class MotivoFueraServicio
    {
      
        public MotivoTipo TipoMotivo { get; set; } = new MotivoTipo();
        public string comentario { get; set; } = string.Empty;

    }
}
