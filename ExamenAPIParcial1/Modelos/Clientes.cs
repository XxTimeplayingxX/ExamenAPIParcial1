namespace ExamenAPIParcial1.Modelos
{
    public class Clientes
    {
        public string NumeroDeCuenta { get; set; }
        public string Nombre { get; set; }
        public TipoDeCuenta TipoCuenta { get; set; }
        public double Saldo { get; set; }
    }
    
    public enum TipoDeCuenta
    {
        Corriente,
        Ahorro,
        Crédito
    }
}
