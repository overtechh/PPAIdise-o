using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CierreOrdenApp.Entidades
{
    public class MotivoFueraServicio
    {
        public MotivoTipo MotivoTipo { get; set; }
        public string Comentario { get; set; }

        public MotivoFueraServicio() { }

        public MotivoFueraServicio(MotivoTipo motivoTipo, string comentario)
        {
            MotivoTipo = motivoTipo;
            Comentario = comentario;
        }

        public override string ToString()
        {
            return $"- {MotivoTipo.Descripcion}: {Comentario}";
        }
    }
}

