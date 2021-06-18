using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;

namespace Datos
{
    public class PlazoFijoMapper
    {

        public List<PlazoFijo> TraerTodos()
        {
            string json = WebHelper.Get("/plazofijo");
            List<PlazoFijo> resultado =MapList(json);
            return resultado;
        }

        public List<PlazoFijo> MapList(string json)
        {
            List<PlazoFijo> resultado = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
            return resultado;
        }

        public  TransacctionResult Insertar(PlazoFijo plazoFijo)
        {
            string json = WebHelper.Post("/plazofijo");
            NamevalueCollection result = ReverseMap(plazoFijo);

            TransacctionResult resultadoTrasnsaccion = MapResultado(result);
            return resultadoTranasaccion;
        }

    
       
        private NameValueCollection ReverseMap(PlazoFijo plazoFijo)
        {
            NameValueCollection n = new NameValueCollection();
           n.Add("id", plazoFijo.Id.ToString());
           n.Add("idCliente", plazoFijo.IdCliente.ToString());
           n.Add("Tipo", plazoFijo.Tipo.ToString());
           n.Add("Tasa", plazoFijo.Tasa.ToString());
           n.Add("Dias", plazoFijo.Dias.ToString("yyyy-MM-dd"));
           n.Add("CapitalInicial", plazoFijo.CapitalInicial.ToString());
           n.Add("Interes", plazoFijo.Interes.ToString());
           n.Add("MontoFinal", plazoFijo.MontoFinal.ToString());
           n.Add("Usuario", ConfigurationManager.AppSettings["Registro"]);
           return n;
        }

        private TransacctionResult MapResultado(string json)
        {


        }
    }
}
