using System;

namespace Dsw2026Ej15.Domain
{
    // La clase Speciality (Especialidad) hereda de BaseEntity.
    // Al heredar (usando los dos puntos :), automáticamente ya tiene la propiedad Id.
    public class Speciality : BaseEntity
    {
        // Propiedad para el nombre de la especialidad
        public string Name { get; set; }

        // Propiedad para describir brevemente de qué trata la especialidad
        public string Description { get; set; }
    }
}