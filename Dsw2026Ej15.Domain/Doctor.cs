using System;

namespace Dsw2026Ej15.Domain
{
    // La clase Doctor hereda de BaseEntity, por lo tanto también tiene su propio Id.
    public class Doctor : BaseEntity
    {
        // Nombre completo del médico
        public string Name { get; set; }

        // Número de licencia o matrícula médica del profesional
        public string LicenseNumber { get; set; }

        // Un valor verdadero/falso para saber si el médico está activo en el sistema
        public bool IsActive { get; set; }

        // Esta propiedad relaciona al Doctor con su Especialidad.
        // Es del mismo tipo de la clase Speciality que creamos antes.
        public Speciality Speciality { get; set; }
    }
}