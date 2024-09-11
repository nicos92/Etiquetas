using Etiquetas.Models;
using Etiquetas.Service;
using Etiquetas.Singleton;
using Etiquetas.Utils;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas.vistas
{
    public partial class ActulizarModificacion : MaterialForm
    {
        public MaterialListView TablaDataA;
        public PictureBox PictureBoxDataB;
        private ListViewItem listViewItem;

        public ActulizarModificacion(MaterialListView Tabladata, PictureBox picture)
        {
            TablaDataA = Tabladata;
            PictureBoxDataB = picture;
            InitializeComponent();

            TemaIndigo();
        }

        public ActulizarModificacion(MaterialListView Tabladata, PictureBox picture, ListViewItem listViewItem) 
        {
            TablaDataA = Tabladata;
            PictureBoxDataB = picture;
            this.listViewItem = listViewItem;
            InitializeComponent();

            TemaIndigo();

        }

        private void ActulizarModificacion_Shown(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void ActulizarModificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            TablaDataA.SelectedItems[0].SubItems[0].Text = ModActId.Text;
            TablaDataA.SelectedItems[0].SubItems[1].Text =  ModActFecha.Text;

            TablaDataA.SelectedItems[0].SubItems[2].Text =  ComboBoxTipo.Text;

            TablaDataA.SelectedItems[0].SubItems[3].Text =  ActComboDestino.Text;
            TablaDataA.SelectedItems[0].SubItems[4].Text =  ModActNumero.Text;
            TablaDataA.SelectedItems[0].SubItems[5].Text = TxtModificacion.Text;
            TablaDataA.Update();

            CargaTemaRed();

        }

        public void TemaIndigo()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.DeepOrange700, TextShade.WHITE);
        }

        public void CargaTemaRed()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Indigo700, TextShade.WHITE);
        }

        private void ActulizarModificacion_Load(object sender, EventArgs e)
        {
            CargarDestinos();

        }

        public void CargarDatos()
        {
            Modificacion mod = SingleModificacion.Instance.GetModificacion;
            ModActId.Text = mod.Id.ToString();
            ModActFecha.Text = mod.Fecha.ToString();
            ComboBoxTipo.Text = mod.Tipo.ToString();
            ModActNumero.Text = mod.Numero.ToString();
            TxtModificacion.Text = mod.Descripcion.ToString();
            ActComboDestino.Text = mod.Destino.ToString();
        }

        private async void CargarDestinos()
        {
            ActComboDestino.Items.Clear();
            if (ActComboDestino.Items.Count == 0)
            {
                foreach (var item in await ServModificacion.GetListDestinosAsync(""))
                {
                    ActComboDestino.Items.Add(item);
                };
            }
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {

            DialogResult dresult = Util.CartelConfirmWarn("¿Estas seguro que querés Actualizar?", "ACTUALIZAR");
            if (dresult == DialogResult.Yes)
            {
                await ServModificacion.UpdateModificacionAsync(
                    ModActId.Text,
                    ModActFecha.Text,
                    ComboBoxTipo.Text,
                    ActComboDestino.Text,
                    ModActNumero.Text,
                    TxtModificacion.Text
                );

                listViewItem = new ListViewItem([
                    ModActId.Text,
                    ModActFecha.Text,
                    ComboBoxTipo.Text,
                    ActComboDestino.Text,
                    ModActNumero.Text,
                    TxtModificacion.Text 
                    ]);

                

                CerrarTodo();
                TablaDataA.Update();
            }
        }


        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            await Eliminacionmodificacion();


        }

        private void Resultado(int result, string titulo)
        {
            if (result >= 1) Util.CartelConfirmInfo(titulo + " correcto", titulo.ToUpper());
            else Util.CartelError(titulo + " incorrecto", titulo.ToUpper());
        }

        private async Task Eliminacionmodificacion()
        {
            if (TablaDataA.SelectedItems.Count > 0)
            {


                DialogResult dresult = Util.CartelConfirmWarn("¿Estas Seguro que querés eliminar?", "ELIMINACION");

                if (dresult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(TablaDataA.SelectedItems[0].Text);

                    int result = await ServModificacion.DeleteLogicoModificacionAsync(id);


                    Resultado(result, "Eliminacion");

                    if (result >= 1)
                    {
                        TablaDataA.Items.Remove(TablaDataA.SelectedItems[0]);

                        CerrarTodo();
                    }
                }
            }
            else
            {
                Util.CartelError("No hay ningun elemento seleccionado", "Error Seleccion");
            }
        }
        public void CerrarTodo()
        {

            this.Close();
        }






    }

}
