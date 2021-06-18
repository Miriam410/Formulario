using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Formulario
{
    public partial class Form1 : Form
    {
        private PlazoFijoServicio _plazofijoServicio;
        private List<PlazoFijo> _listaPlazoFijo;
        public Form1()
        {
            _plazofijoServicio = new PlazoFijoServicio();
            InitializeComponent();
            cmb_TipoPlazoFijo_SelectedIndex.DataSource = null;
            cmb_TipoPlazoFijo_SelectedIndex.DataSource = _listaPlazoFijo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmb_TipoPlazoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descripcion= "";
            if ((int.Parse(cmb_TipoPlazoFijo_SelectedIndexChanged) == 0)
            {
                descripcion = "Plazo Fijo Web";
            }
            else  if(int.Parse(cmb_TipoPlazoFijo_SelectedIndexChanged))==1)
            {
                descripcion = "Plazo Fijo UVA";
            }

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Simular_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                PlazoFijo pf = new PlazoFijo();
                cmb_TipoPlazoFijo_SelectedIndex.DataSource = null;
                cmb_TipoPlazoFijo_SelectedIndex.DataSource = _listaPlazoFijo;
                pf.IdCliente = 0;
                pf.CapitalInicial = textBox2.Text.ToString("0.00");
                pf.Dias = textBox3.Text.ToString("yyyy-MM-dd");
                pf.Interes = textBox4.Text.ToString("0.00");
                pf.Tasa.Enable = true;
                pf.Interes.Enable = true;
                pf.MontoFinal.Enable = true;

                TransacctionResult t = mapper.Insert(pf);


            }
            catch 
            { 
               string msg= "{\"isOk\":false, \"id\": -1 , \"error en la petición\"}";
            }
          

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
           textBox2.Text=string.Empty;
            textBox3.Text= string.Empty;
             textBox4.Text= string.Empty;
        }
    }
}
