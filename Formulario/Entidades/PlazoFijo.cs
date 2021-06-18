using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entidades
{
    [DataContract]
    public class PlazoFijo
    {
        private int _id;
        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _idCliente;
        [DataMember]
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        private int _tipo;
        [DataMember]
        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private double _tasa;
        [DataMember]
        public double Tasa
        {
            get { return _tasa; }
            set { _tasa = value; }
        }

        private int _dias;
        [DataMember]
        public int Dias
        {
            get { return _dias; }
            set { _dias = value; }
        }

        private double _capitalInicial;
        [DataMember]
        public double CapitalInicial
        {
            get { return _capitalInicial; }
            set { _capitalInicial = value; }
        }

        private double _interes;
        [DataMember]
        public double Interes
        {
            get { return (((Tasa/365)*_dias)*CapitalInicial)/ 100; }
            set { _interes = value; }
        }
        private double _montoFinal;
        [DataMember]
        public double MontoFinal
        {
            get { return (CapitalInicial+Interes); }
            set { _montoFinal = value; }
        }

        private string _usuario;

        public string Usuario = ConfigurationManager.AppSettings["Registro"];

      
    }
}
