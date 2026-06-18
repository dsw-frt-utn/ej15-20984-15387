using Dsw2026Ej15.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregamos los controladores al contenedor de servicios
builder.Services.AddControllers();

// VINCULAR LA CAPA DE DATOS CON LA API (Inyeccion de dependencias)
// Registramos IPersistence para que use la clase PersistenceInMemory como una instancia unica
builder.Services.AddSingleton<IPersistence, PersistenceInMemory>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();