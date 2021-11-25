using System;

namespace net.Models
{
    public class Factura
    {
        public int Numero { get; set; }
        public string Concepto { get; set; }
        public double Importe { get; set; }
        public string TipoIVA { get; set; }

        public bool Pagada { get; set; }

        public Factura(int Numero, string Concepto, double Importe, string TipoIVA, bool Pagada)
        {

            this.Numero = Numero;
            this.Concepto = Concepto;
            this.Importe = Importe;
            this.TipoIVA = TipoIVA;
            this.Pagada = Pagada;
        }
        public Factura()
        {

        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                if (Numero == ((Factura)obj).Numero)
                {
                    return true;
                }else {
                    return false;
                }
            }
        }
        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }
    }
}
