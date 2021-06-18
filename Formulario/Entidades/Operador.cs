using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operador
    {
        private List<PlazoFijo> plazoFijo;

        public List<PlazoFijo> PlazoFijo
        {
            get { return plazoFijo; }
            set { plazoFijo = value; }
        }

        private double _montoTotal;

        public double MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }

        private double _comision;

        public double Comision
        {
            get { return _comision; }
            set { _comision = value; }
        }

        public Operador()
        {
            plazoFijo = new List<PlazoFijo>();
            
        }
    }
}
