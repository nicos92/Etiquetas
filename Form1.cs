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
using Etiquetas.vistas;
using System.Threading;
using Etiquetas.Singleton;
using Etiquetas.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Etiquetas
{
    public partial class FormMain : MaterialForm
    {
        private List<string[]> _lista;
        public FormMain()
        {
            InitializeComponent();
            CargaTemaRed();
            BckTablaData.WorkerReportsProgress = true;


        }

        public void CargaTemaRed()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Indigo700, TextShade.WHITE);
        }





        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            string fecha = TxtFecha.Text.Trim();
            string numero = TxtNumero.Text.Trim().ToUpper();
            string destino = TxtDestino.Text.Trim().ToUpper();
            string tipo = ComboBoxTipo.Text;
            string descripcion = TxtModificacion.Text.Trim();

            int result;
            if (tipo == "AMBOS")
            {
                result = await ServModificacion.IngresarModificacionDobleAsync(fecha, numero, destino, descripcion);
            }
            else
            {
                result = await ServModificacion.IngresarModificacionAsync(fecha, numero, destino, tipo, descripcion);
            }
            CleanFormIngreso();
            Resultado(result, "INGRESO");

        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
             await GetListModificaionesAsync();
            //IntercambiovistaListView(true);
            

            ListView.Items.Clear();
            foreach (string[] item in _lista)
            {

                // Simula una tarea larga
                var listvi = new ListViewItem(item);
                ListView.Items.Add(listvi);

            }
            IntercambiovistaListView(false);
            Util.CartelConfirmInfo("Carga Completa", "BUSQUEDA");

        }

        public void IntercambiovistaListView(bool vista)
        {
            if (vista)
            {
                ImgTablaData.Image = Properties.Resources.icons8_loading_infinity;
            }
            else
            {
                ImgTablaData.Image = Properties.Resources.techny_working_with_big_data_on_server;
            }
            VistaLoading.Visible = vista;
            ProgressBarTop.Visible = vista;

            ListView.Visible = !vista;
        }

        private void BckTablaData_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            foreach (string[] item in _lista)
            {

                // Simula una tarea larga
                Thread.Sleep(100);
                BckTablaData.ReportProgress(count++);
           

            }

            
            


        }

        private void BckTablaData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarTop.Value = e.ProgressPercentage;
        }

        private void BckTablaData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBarTop.Visible = false;
        }


        public async Task GetListModificaionesAsync()
        {
            string tipo = ComboTipo.Text != "INTERNA" && ComboTipo.Text != "EXTERNA" ? "" : ComboTipo.Text;
            string destino = ComboDestino.Text.ToUpper();
            string numero = ComboNumero.Text.ToUpper();
            _lista = await ServModificacion.GetModificacionListAsync(tipo, destino, numero);
           
        }

        private void Resultado(int result, string titulo)
        {
            if(result >= 1) Util.CartelConfirmInfo(titulo + " correcto", titulo.ToUpper());
            else Util.CartelError(titulo + " incorrecto", titulo.ToUpper());
        }




        private void BtnVer_Click(object sender, EventArgs e)
        {

            IntercambioVistaTablaData(TablaData.Visible);
        }


        public void IntercambioVistaTablaData(bool vista)
        {


            VistaLoading.Visible = vista;
            TablaData.Visible = !vista;


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
            ComboDestino.Enabled = true;
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
            await Eliminacionmodificacion();

        }

        private async Task Eliminacionmodificacion()
        {
            if (ListView.SelectedItems.Count > 0)
            {


                DialogResult dresult = Util.CartelConfirmWarn("¿Estas Seguro que querés eliminar?", "ELIMINACION");

                if (dresult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(ListView.SelectedItems[0].Text);

                    int result = await ServModificacion.DeleteLogicoModificacionAsync(id);

                    HabilitarBtnsConsulta(false);
                    Resultado(result, "Eliminacion");

                    if (result >= 1)
                    {
                        ListView.Items.Remove(ListView.SelectedItems[0]);

                    }
                }
            }
            else
            {
                Util.CartelError("No hay ningun elemento seleccionado", "Error Seleccion");
            }
        }

        public void BtnActualizar_Click(object sender, EventArgs e)
        {
            
           SingleModificacion.Instance.SetModificacion(
            Convert.ToInt32(ListView.SelectedItems[0].SubItems[0].Text),
             ListView.SelectedItems[0].SubItems[1].Text,
            ListView.SelectedItems[0].SubItems[2].Text,
            ListView.SelectedItems[0].SubItems[3].Text,
            ListView.SelectedItems[0].SubItems[4].Text,
            ListView.SelectedItems[0].SubItems[5].Text);



            ActulizarModificacion AMForm = new(ListView, ImgTablaData, ListView.SelectedItems[0]);
            AMForm.ShowDialog();
            
        }

        public void TemaIndigo()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.DeepOrange700, TextShade.WHITE);
        }

        

        private void HabilitarBtnsConsulta(bool bol)
        {
            BtnActualizar.Enabled = bol;
            BtnEliminar.Enabled = bol;
        }

        private void ListView_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show(ListView.SelectedItems[0].Text);
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            HabilitarBtnsConsulta(true);

        }
    } 
}
