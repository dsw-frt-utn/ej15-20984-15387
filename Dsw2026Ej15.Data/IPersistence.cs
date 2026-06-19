using Dsw2026Ej15.Domain;

namespace Dsw2026Ej15.Data
{
    public interface IPersistence
    {
        // Contratos: Cualquiera que use esta interfaz, tiene garantizado encontrar estas dos listas
        List<Doctor> Doctors { get; set; }
        List<Speciality> Specialities { get; set; }
    }
}