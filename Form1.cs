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

            if (tipo == "AMBOS")
            {
               ServModificacion.IngresarModificacionDobleAsync(fecha, numero, destino, descripcion);
            }
            else
            {
               ServModificacion.IngresarModificacionAsync(fecha, numero, destino, tipo, descripcion);
            }

        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            string tipo = ComboTipo.Text != "INTERNA" && ComboTipo.Text != "EXTERNA" ? "" : ComboTipo.Text;
            string destino = ComboDestino.Text.ToUpper();
            string numero = ComboNumero.Text.ToUpper();
            //TablaData.DataSource = ServModificacion.GetModificacionList(tipo, destino, numero);
            TablaData.DataSource = await ServModificacion.GetModificacionListAsync(tipo,destino, numero);
            IntercambioVistaTablaData(false);
            Util.CartelConfirmInfo("Carga Completa", "Busqueda");
        }

        public void IntercambioVistaTablaData(bool vista)
        {
            ImgTablaData.Visible = vista;
            TablaData.Visible = !ImgTablaData.Visible;
        }



        private async void CargarDestinos()
        {
            ComboDestino.Items.Clear();
            if (ComboDestino.Items.Count == 0)
            {
                foreach (var item in await ServModificacion.GetListDestinosAsync(ComboTipo.Text))
                {
                    ComboDestino.Items.Add(item);
                };
            }
        }



        private async void CargarNumeros(string tipo, string destino)
        {
            ComboNumero.Items.Clear();
            if (ComboNumero.Items.Count == 0)
            {
                foreach (var item in await ServModificacion.GetListNumerosAsync(tipo, destino))
                {
                    ComboNumero.Items.Add(item);
                };
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

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dresult = Util.CartelConfirmWarn("Estas Seguro que querés eliminar?", "ELIMINACION");

            if (dresult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(TablaData.CurrentRow.Cells[0].Value);

                await ServModificacion.DeleteLogicoModificacionAsync(id);
                IntercambioVistaTablaData(true);
            }

            

        }
    }
}
