using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Presentation
{
    public class Alumno
    {
        public string Guid { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaHora { get; set; }

        public Alumno() {

        }
        public Alumno(int id, string nombre, string apellidos, string dni, int edad, DateTime fechaNacimiento, DateTime fechaHora, string guid)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.Edad = edad;
            this.FechaNacimiento = fechaNacimiento;
            this.FechaHora = fechaHora;
            this.Guid = guid;
        }
    }
}
