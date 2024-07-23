using Etiquetas.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string fecha = TxtFecha.Text;
            string numero = TxtNumero.Text;
            string destino = TxtDestino.Text;
            string tipo = SwitchEti.Checked ? "INTERNA" : "EXTERNA";
            string descripcion = TxtModificacion.Text;

            ServModificacion.IngresarModificacion(fecha, numero, destino, tipo, descripcion);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
        }
    }
}
