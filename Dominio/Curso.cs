using System;
using System.Collections.Generic;


namespace Dominio
{
   public class Curso
   {
        public Guid CursoId { get; init; }
        
        public string Titulo { get; set; }
        
        public string Descripcion {get;set;}

        public DateTime FechaPublicacion { get; set; }
        
        public byte[] FotoPortada {get;set;}
        

        public Precio PrecioPromocion{get;set;}

        public ICollection<Comentario> ComentarioLista{get;set;}

   }
}