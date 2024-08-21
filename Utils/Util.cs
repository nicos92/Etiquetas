using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas.Utils
{
    public class Util
    {
        public static DialogResult CartelConfirmWarn(string msj, string titulo) => MessageBox.Show(msj, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        public static void CartelConfirmInfo(string msj, string titulo) => MessageBox.Show(msj, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        public static void CartelError(string msj, string titulo) => MessageBox.Show(msj, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);




 

        public static bool ValidarInt(TextBox text, Label label) => label.Visible = !Regex.IsMatch(text.Text, @"^(\d){0,14}$");


    }
}
