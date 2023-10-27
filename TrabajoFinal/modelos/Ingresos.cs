using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal.modelos
{
    internal class Ingresos
    {
        private DateTime fecha_ingreso { get=>fecha_ingreso; set=>fecha_ingreso = value; }
        private DateTime fecha_retiro { get=>fecha_retiro; set=>fecha_retiro = value; }
        private Pacientes paciente { get => paciente;set => paciente = value; }
        private Medicos medico { get=> medico; set => medico = value; }
        private List<Practicas> Practicas;
    }
}
