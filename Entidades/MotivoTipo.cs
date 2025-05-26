using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_sismo.Entidades
{
    public class MotivoTipo
    {
        public string descripcion { get; set; }

        public string getDescripcion()
        {
            return descripcion;
        }

        public static List<MotivoTipo> obtenerTodos()
        {
            return new List<MotivoTipo>
            {
                new MotivoTipo { descripcion = "Falla técnica" },
                new MotivoTipo { descripcion = "Mantenimiento" },
                new MotivoTipo { descripcion = "Sin energía" }
            };
        }
    }
}

