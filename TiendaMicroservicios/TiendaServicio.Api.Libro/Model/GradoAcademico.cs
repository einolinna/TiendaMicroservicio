﻿namespace TiendaServicio.Api.AutorLibro.Model
{
    public class GradoAcademico
    {
        public int GradoAcademicoId { get; set; }
        public string Nombre { get; set; }  
        public string CentroAcademico { get; set; }
        public DateTime? FechaGrado { get; set; }
        public int AutorId { get; set; }    
        public Autor Autor { get; set; }


    }
}
