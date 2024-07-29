namespace TareasMVC.Entidades
{
    public class Paso
    {
        public Guid Id { get; set; }//Guid nos crea Id super unicos de manera parecida a Node
        public int TareaId { get; set; }//Nota: parece que si configuras justa abajo de esto el FK convierte a este en el FK
        public Tarea Tarea { get; set; }//Propiedad de navegacion Uno a muchos
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
        public int Orden { get; set; }
    }
}
