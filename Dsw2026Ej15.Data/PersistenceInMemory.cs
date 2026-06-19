using Dsw2026Ej15.Domain;
using System.Text.Json;

namespace Dsw2026Ej15.Data
{
    // Esta clase implementa la interfaz IPersistence
    // Va a mantener los datos vivos en la memoria mientras la app este funcionando
    public class PersistenceInMemory : IPersistence
    {
        //aqui dos listas doctor y especialidad, que simulan nuestra base de datos en la memoria
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Speciality> Specialities { get; set; } = new List<Speciality>();

        //   al instanciar esta clase lo primero que se ejecuta es el constructor
        public PersistenceInMemory()
        {
            // Llamamos al metodo privado para cargar los datos
            // Como el constructor no puede ser "async", usamos .Wait() para obligarlo a esperar que termine de leer el archivo
            LoadSpecialities().Wait();
        }

        // Metodo privado para obtener las especialidades desde el archivo JSON
        private async Task LoadSpecialities()
        {
            try
            {
                // Definimos el nombre del archivo de datos
                string archivo = "specialities.json";

                // Primero verificamos si el archivo realmente existe para no romper el programa
                if (File.Exists(archivo))
                {
                    // Leemos todo el texto del archivo (basado en el apunte) 
                    var json = await File.ReadAllTextAsync(archivo);

                    // Transformamos ese texto JSON a nuestra lista de objetos Speciality
                    // La opcion PropertyNameCaseInsensitive es para que no importe si las mayusculas no coinciden exacto
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var especialidadesCargadas = JsonSerializer.Deserialize<List<Speciality>>(json, opciones);

                    // Si la conversion salio bien y no esta vacia, la guardamos en nuestra lista global
                    if (especialidadesCargadas != null)
                    {
                        Specialities = especialidadesCargadas;
                        Console.WriteLine("Especialidades cargadas con exito.");
                    }
                }
                else
                {
                    Console.WriteLine("Aviso: El archivo de especialidades no se encuentra en la ruta.");
                }
            }
            catch (Exception ex)
            {
                // Si algo falla durante la lectura, capturamos el error
                Console.WriteLine("Error al procesar el archivo: " + ex.Message);
            }
        }
    }
}