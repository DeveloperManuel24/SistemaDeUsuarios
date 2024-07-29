using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TareasMVC.Entidades
{
    public class Tarea
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacionId { get; set; }//Id que creo un user
        public IdentityUser UsuarioCreacion { get; set; }//Esto es la relacion directa con el usuario.
        public List<Paso> Pasos { get; set; }//Uno a muchos
        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
    }
}
