using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentBackend.Common.Logic
{
    public class Student
    {
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime HoraRegistro { get; set; }
        public Guid Student_Guid { get; set; }
        #endregion
    }
}
