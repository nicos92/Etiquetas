using Etiquetas.BDConnection;
using Etiquetas.Service;
using Etiquetas.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            CargaTema();
        }

        public void CargaTema()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Indigo700, TextShade.WHITE);
        }





        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            string fecha = TxtFecha.Text.Trim();
            string numero = TxtNumero.Text.Trim().ToUpper();
            string destino = TxtDestino.Text.Trim().ToUpper();
            string tipo = ComboBoxTipo.Text;
            string descripcion = TxtModificacion.Text.Trim();

            int result;

            if (tipo == "AMBOS")
            {
                result = ServModificacion.IngresarModificacionDoble(fecha, numero, destino, descripcion);
            }
            else
            {
                result = ServModificacion.IngresarModificacion(fecha, numero, destino, tipo, descripcion);
            }

            MostrarResult(result);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            string tipo = ComboTipo.Text != "INTERNA" && ComboTipo.Text != "EXTERNA" ? "" : ComboTipo.Text;
            string destino = ComboDestino.Text.ToUpper();
            string numero = ComboNumero.Text.ToUpper();
            TablaData.DataSource = ServModificacion.GetModificacionList(tipo, destino, numero);
            ImgTablaData.Visible = false;
            TablaData.Visible = true;
            Util.CartelConfirmInfo("Carga Completa", "Busqueda");
        }



        private void CargarDestinos()
        {
            ComboDestino.Items.Clear();
            if (ComboDestino.Items.Count == 0)
            {
                foreach (var item in ServModificacion.GetListDestinos(ComboTipo.Text))
                {
                    ComboDestino.Items.Add(item);
                };
            }
        }



        private void CargarNumeros(string tipo, string destino)
        {
            ComboNumero.Items.Clear();
            if (ComboNumero.Items.Count == 0)
            {
                foreach (var item in ServModificacion.GetListNumeros(tipo, destino))
                {
                    ComboNumero.Items.Add(item);
                };
            }
        }

        private void MostrarResult(int result)
        {
            if (result > 0)
            {
                Util.CartelConfirmInfo("Ingreso correcto", "INGRESO");
                CleanFormIngreso();
            }
            else
            {
                Util.CartelConfirmInfo("No se realizo el ingreso", "INGRESO");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            CargarDestinos();

        }



        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {
            BtnGuardarEnabled();
        }

        private void BtnGuardarEnabled()
        {
            BtnGuardar.Enabled = (TxtFecha.Text.Length > 0 && TxtNumero.Text.Length > 0 && TxtDestino.Text.Length > 0 && TxtModificacion.Text.Length > 0);
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            BtnGuardarEnabled();
        }

        private void TxtDestino_TextChanged(object sender, EventArgs e)
        {
            BtnGuardarEnabled();
        }

        private void TxtModificacion_TextChanged(object sender, EventArgs e)
        {
            BtnGuardarEnabled();
        }

        private void CleanFormIngreso()
        {
            TxtFecha.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
            TxtNumero.Clear();
            TxtDestino.Clear();
            TxtModificacion.Clear();
            ComboDestino.Items.Clear();
            ComboNumero.Items.Clear();
        }

        private void ComboTipo_DropDownClosed(object sender, EventArgs e)
        {
            ComboDestino.Enabled = true;
            ComboNumero.Enabled = false;
            CargarDestinos();
        }



        private void ComboTipo_DropDown(object sender, EventArgs e)
        {
            ComboNumero.Enabled = false;
            ComboDestino.Enabled = false;
        }

        private void ComboDestino_DropDownClosed(object sender, EventArgs e)
        {
            ComboNumero.Enabled = true;
            CargarNumeros(ComboTipo.Text, ComboDestino.Text);
        }

      

        
    }
}
