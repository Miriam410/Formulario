using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoPlazoFijo
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private double _tasa;

        public double Tasa
        {
            get { return _tasa; }
            set { _tasa = value; }
        }
        private string  _descripcion;

        public string  Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public TipoPlazoFijo(int id, double tasa, string descripcion)
        {
            this._id = id;
            this._tasa = tasa;
            this._descripcion = descripcion;
        }


    }
}
