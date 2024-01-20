using ExamenAPIParcial1.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenAPIParcial1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Clientes> _clientes = new List<Clientes>
        {
            new Clientes
            {
                NumeroDeCuenta = "9087789610",
                Nombre = "David Sánchez",
                TipoCuenta = TipoDeCuenta.Ahorro,
                Saldo = 500
            },
            new Clientes
            {
                NumeroDeCuenta = "90872345780",
                Nombre = "Daniel Olivo",
                TipoCuenta = TipoDeCuenta.Corriente,
                Saldo = 500
            },
            new Clientes
            {
                NumeroDeCuenta = "90223311310",
                Nombre = "Edwin Falconez",
                TipoCuenta = TipoDeCuenta.Crédito,
                Saldo = 500
            },
            new Clientes
            {
                NumeroDeCuenta = "12135090113",
                Nombre = "Carlos Dimitrakis",
                TipoCuenta = TipoDeCuenta.Ahorro,
                Saldo = 500
            },
            new Clientes
            {
                NumeroDeCuenta = "87764514093",
                Nombre = "Betsabe Correo",
                TipoCuenta = TipoDeCuenta.Crédito,
                Saldo = 500
            }
        };
        [HttpGet]
        public IEnumerable<Clientes> GetAllClients()
        {
            return _clientes;
        }
    }
}
