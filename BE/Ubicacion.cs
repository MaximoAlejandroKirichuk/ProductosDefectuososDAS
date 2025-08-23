using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ubicacion
    {
		public string DepositoAlmacenado { get; set; }
        public int NumeroEstante { get; set; }
        public int NivelEstante { get; set; }
        public int NumeroColumna { get; set; }

        public Ubicacion(string nroDeposito, int nroEstante, int nivelEstante, int nroColumna)
        {
			this.DepositoAlmacenado = nroDeposito;
			this.NumeroColumna = nroColumna ;
			this.NivelEstante = nivelEstante;
			this.NumeroEstante = nroEstante;
        }
        public Ubicacion() { }
        
        public override string ToString()
        {
            return $"{DepositoAlmacenado};{NumeroColumna};{NivelEstante};{NumeroEstante}";
        }
    }
}
