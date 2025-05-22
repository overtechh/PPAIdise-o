using System;

namespace CierreOrdenApp.Entidades
{
    public class MotivoTipo
    {
        public string Descripcion { get; set; }
        public string Comentario { get; set; }  // ✅ Esta es la propiedad que te está faltando

        public MotivoTipo() { }

        public MotivoTipo(string descripcion, string comentario = "")
        {
            Descripcion = descripcion;
            Comentario = comentario;
        }

        public string getDescripcion()
        {
            return Descripcion;
        }

        public override string ToString()
        {
            return $"{Descripcion}: {Comentario}";
        }
    }
}

