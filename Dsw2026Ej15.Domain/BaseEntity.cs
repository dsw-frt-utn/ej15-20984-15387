
using System;

namespace Dsw2026Ej15.Domain
{
    // Esta clase es abstracta porque no vamos a crear un "BaseEntity" directamente,
    // sino que servirá de molde base para que otras clases hereden de ella.
    public abstract class BaseEntity
    {
        // Propiedad Id de tipo Guid (un identificador único global).
        // Se usa para tener un ID seguro en lugar del clásico número entero autoincremental.
        public Guid Id { get; set; }
    }
}