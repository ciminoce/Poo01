using System.Text;

namespace Poo04.Entidades
{
    public class CuentaBancaria
    {
        public string NroCuenta { get; private set; } = null!;
        public string Cliente { get; private set; } = null!;
        public decimal Saldo { get; private set; }
        public bool PermiteSobregiro { get; private set; }
        private readonly int CantidadSobregiro = 2;
        private readonly decimal MontoMaximoSobregiro = 20000;
        public CuentaBancaria()
        {
            
        }
        public CuentaBancaria(string cuenta, string cliente):this()
        {
            NroCuenta = cuenta;
            Cliente = cliente;
            
        }
        public CuentaBancaria(string cuenta, string cliente, decimal saldo,bool sobreGiro=true):this(cuenta,cliente) {
        
            Saldo = saldo;
            PermiteSobregiro=sobreGiro;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cuenta Nro: {NroCuenta}");
            sb.AppendLine($"Cliente...: {Cliente}");
            sb.AppendLine($"Saldo.....: {Saldo:C2}");
            return sb.ToString();
        }
        public void Depositar(decimal deposito)
        {
            Saldo += deposito;
        }
        public void Extraer(decimal extraccion)
        {
            if (extraccion <= Saldo)
            {
                Saldo-= extraccion;
            }
            else
            {
                throw new ArgumentException("Saldo insuficiente!!!");
            }
        }
    }
}
