using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ValidacionesHelper
{
    public static class Validacion
    {
        public static  bool DatosValidos = false;
        public static string msg = "";

        public static bool ValidarCampo(string Valor,string campo)
        {
            if (string.IsNullOrEmpty(Valor))
            {
                msg += ("El campo "+ campo +" no debe ser vacio\n");
            }
            else
            {
               DatosValidos = true;
            }
            return MSG();
            
        }

        public static bool  MSG()
        {
            if (!string.IsNullOrEmpty(msg))
            {
                msg = "Error de datos";
                DatosValidos = false;
            }
            return DatosValidos;
        }


        public static string ValidarInt(string Num, string Campo, int valorMinimo = 0)
        {
            if (!int.TryParse(Num, out int CampoNum))
            {
                msg = "El campo " + Campo + " solo permite numeros\n";
            }
            else if (CampoNum <= valorMinimo)
            {
                msg = "El campo " + Campo + " debe ser un numero positivo\n";
            }

            return msg;
        }

        
        public static string ValidarDouble(string NumDouble, string Campo)
        {
            if (!Double.TryParse(NumDouble, out double CampoDouble))
            {
                msg = "El campo" + CampoDouble + " debe ser numerico\n";
            }
            else if (CampoDouble <= 0)
            {
                msg = "El campo" + Campo + " no puede ser negativo\n" + System.Environment.NewLine;
            }  

            return msg;
        }
        
    }
}

    


