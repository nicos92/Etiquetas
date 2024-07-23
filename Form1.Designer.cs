﻿namespace Etiquetas
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ProgressBarTop = new MaterialSkin.Controls.MaterialProgressBar();
            this.TabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.PageIngreso = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.BtnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TxtModificacion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.SwitchEti = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtNumero = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtDestino = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtFecha = new MaterialSkin.Controls.MaterialTextBox2();
            this.PageConsulta = new System.Windows.Forms.TabPage();
            this.CardOpciones = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVer = new MaterialSkin.Controls.MaterialButton();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.CardData = new MaterialSkin.Controls.MaterialCard();
            this.TablaData = new System.Windows.Forms.DataGridView();
            this.CardFiltros = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.ComboTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboNumero = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboDestino = new MaterialSkin.Controls.MaterialComboBox();
            this.PageConfig = new System.Windows.Forms.TabPage();
            this.TabControlMain.SuspendLayout();
            this.PageIngreso.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.PageConsulta.SuspendLayout();
            this.CardOpciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CardData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaData)).BeginInit();
            this.CardFiltros.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBarTop
            // 
            this.ProgressBarTop.Depth = 0;
            this.ProgressBarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarTop.Enabled = false;
            this.ProgressBarTop.Location = new System.Drawing.Point(3, 64);
            this.ProgressBarTop.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBarTop.Name = "ProgressBarTop";
            this.ProgressBarTop.Size = new System.Drawing.Size(794, 5);
            this.ProgressBarTop.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarTop.TabIndex = 0;
            this.ProgressBarTop.Value = 1;
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.PageIngreso);
            this.TabControlMain.Controls.Add(this.PageConsulta);
            this.TabControlMain.Controls.Add(this.PageConfig);
            this.TabControlMain.Depth = 0;
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.ImageList = this.imageList1;
            this.TabControlMain.Location = new System.Drawing.Point(3, 69);
            this.TabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlMain.Multiline = true;
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(794, 428);
            this.TabControlMain.TabIndex = 2;
            // 
            // PageIngreso
            // 
            this.PageIngreso.Controls.Add(this.materialCard2);
            this.PageIngreso.Controls.Add(this.materialCard1);
            this.PageIngreso.ImageKey = "pngwing.com.png";
            this.PageIngreso.Location = new System.Drawing.Point(4, 31);
            this.PageIngreso.Name = "PageIngreso";
            this.PageIngreso.Padding = new System.Windows.Forms.Padding(10);
            this.PageIngreso.Size = new System.Drawing.Size(786, 393);
            this.PageIngreso.TabIndex = 0;
            this.PageIngreso.Text = "Ingresos";
            this.PageIngreso.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.BtnGuardar);
            this.materialCard2.Controls.Add(this.TxtModificacion);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(10, 233);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(10);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(766, 150);
            this.materialCard2.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BtnGuardar.Depth = 0;
            this.BtnGuardar.HighEmphasis = true;
            this.BtnGuardar.Icon = global::Etiquetas.Properties.Resources.icons8_guardar_50;
            this.BtnGuardar.ImageKey = "icons8-guardar-50.png";
            this.BtnGuardar.ImageList = this.imageList1;
            this.BtnGuardar.Location = new System.Drawing.Point(644, 53);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnGuardar.Size = new System.Drawing.Size(116, 36);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnGuardar.UseAccentColor = false;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel48.png");
            this.imageList1.Images.SetKeyName(1, "checkmark48.png");
            this.imageList1.Images.SetKeyName(2, "close48.png");
            this.imageList1.Images.SetKeyName(3, "conexOK.png");
            this.imageList1.Images.SetKeyName(4, "error48 (2).png");
            this.imageList1.Images.SetKeyName(5, "error48.png");
            this.imageList1.Images.SetKeyName(6, "filebasic.png");
            this.imageList1.Images.SetKeyName(7, "gummy-tv-room.png");
            this.imageList1.Images.SetKeyName(8, "iconerror.ico");
            this.imageList1.Images.SetKeyName(9, "iconOk.ico");
            this.imageList1.Images.SetKeyName(10, "icons8-analytics-32.png");
            this.imageList1.Images.SetKeyName(11, "icons8-art-32.png");
            this.imageList1.Images.SetKeyName(12, "icons8-borrow-book-32.png");
            this.imageList1.Images.SetKeyName(13, "icons8-box-64.png");
            this.imageList1.Images.SetKeyName(14, "icons8-date-64.png");
            this.imageList1.Images.SetKeyName(15, "icons8-email-24.png");
            this.imageList1.Images.SetKeyName(16, "icons8-goal-24.png");
            this.imageList1.Images.SetKeyName(17, "icons8-home-50.png");
            this.imageList1.Images.SetKeyName(18, "icons8-line-chart-48.png");
            this.imageList1.Images.SetKeyName(19, "icons8-notification-24.png");
            this.imageList1.Images.SetKeyName(20, "icons8-pallet-50.png");
            this.imageList1.Images.SetKeyName(21, "icons8-password-25.png");
            this.imageList1.Images.SetKeyName(22, "icons8-password-64.png");
            this.imageList1.Images.SetKeyName(23, "icons8-person-25.png");
            this.imageList1.Images.SetKeyName(24, "icons8-person-64.png");
            this.imageList1.Images.SetKeyName(25, "icons8-settings-50.png");
            this.imageList1.Images.SetKeyName(26, "icons8-table-32.png");
            this.imageList1.Images.SetKeyName(27, "icons8-typing-24.png");
            this.imageList1.Images.SetKeyName(28, "icons8-us-dollar-26.png");
            this.imageList1.Images.SetKeyName(29, "info48.png");
            this.imageList1.Images.SetKeyName(30, "mute.png");
            this.imageList1.Images.SetKeyName(31, "notification50.png");
            this.imageList1.Images.SetKeyName(32, "ok48.png");
            this.imageList1.Images.SetKeyName(33, "pngwing.com.png");
            this.imageList1.Images.SetKeyName(34, "vol.png");
            this.imageList1.Images.SetKeyName(35, "icons8-basura-64.png");
            this.imageList1.Images.SetKeyName(36, "icons8-búsqueda-50.png");
            this.imageList1.Images.SetKeyName(37, "icons8-editar-64.png");
            this.imageList1.Images.SetKeyName(38, "icons8-guardar-50.png");
            this.imageList1.Images.SetKeyName(39, "icons8-visible-50.png");
            // 
            // TxtModificacion
            // 
            this.TxtModificacion.AnimateReadOnly = false;
            this.TxtModificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtModificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtModificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtModificacion.Depth = 0;
            this.TxtModificacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtModificacion.HideSelection = true;
            this.TxtModificacion.Location = new System.Drawing.Point(14, 14);
            this.TxtModificacion.MaxLength = 32767;
            this.TxtModificacion.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtModificacion.Name = "TxtModificacion";
            this.TxtModificacion.PasswordChar = '\0';
            this.TxtModificacion.ReadOnly = false;
            this.TxtModificacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtModificacion.SelectedText = "";
            this.TxtModificacion.SelectionLength = 0;
            this.TxtModificacion.SelectionStart = 0;
            this.TxtModificacion.ShortcutsEnabled = true;
            this.TxtModificacion.Size = new System.Drawing.Size(568, 122);
            this.TxtModificacion.TabIndex = 0;
            this.TxtModificacion.TabStop = false;
            this.TxtModificacion.Text = "Modificacion: ";
            this.TxtModificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtModificacion.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.SwitchEti);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.TxtNumero);
            this.materialCard1.Controls.Add(this.TxtDestino);
            this.materialCard1.Controls.Add(this.TxtFecha);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 10);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(10);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(766, 230);
            this.materialCard1.TabIndex = 0;
            // 
            // SwitchEti
            // 
            this.SwitchEti.AutoSize = true;
            this.SwitchEti.BackColor = System.Drawing.Color.White;
            this.SwitchEti.Depth = 0;
            this.SwitchEti.Location = new System.Drawing.Point(108, 177);
            this.SwitchEti.Margin = new System.Windows.Forms.Padding(0);
            this.SwitchEti.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SwitchEti.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchEti.Name = "SwitchEti";
            this.SwitchEti.Ripple = true;
            this.SwitchEti.Size = new System.Drawing.Size(123, 37);
            this.SwitchEti.TabIndex = 5;
            this.SwitchEti.Text = "INTERNA";
            this.SwitchEti.UseVisualStyleBackColor = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(37, 185);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "EXTERNA";
            // 
            // TxtNumero
            // 
            this.TxtNumero.AnimateReadOnly = false;
            this.TxtNumero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNumero.Depth = 0;
            this.TxtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNumero.HideSelection = true;
            this.TxtNumero.Hint = "NUMERO";
            this.TxtNumero.LeadingIcon = global::Etiquetas.Properties.Resources.icons8_una_página_50;
            this.TxtNumero.Location = new System.Drawing.Point(17, 71);
            this.TxtNumero.MaxLength = 32767;
            this.TxtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.PasswordChar = '\0';
            this.TxtNumero.PrefixSuffixText = null;
            this.TxtNumero.ReadOnly = false;
            this.TxtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNumero.SelectedText = "";
            this.TxtNumero.SelectionLength = 0;
            this.TxtNumero.SelectionStart = 0;
            this.TxtNumero.ShortcutsEnabled = true;
            this.TxtNumero.Size = new System.Drawing.Size(250, 48);
            this.TxtNumero.TabIndex = 2;
            this.TxtNumero.TabStop = false;
            this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNumero.TrailingIcon = null;
            this.TxtNumero.UseSystemPasswordChar = false;
            // 
            // TxtDestino
            // 
            this.TxtDestino.AnimateReadOnly = false;
            this.TxtDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDestino.Depth = 0;
            this.TxtDestino.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDestino.HideSelection = true;
            this.TxtDestino.Hint = "DESTINO";
            this.TxtDestino.LeadingIcon = global::Etiquetas.Properties.Resources.icons8_activar_el_modo_avión_50;
            this.TxtDestino.Location = new System.Drawing.Point(17, 125);
            this.TxtDestino.MaxLength = 32767;
            this.TxtDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDestino.Name = "TxtDestino";
            this.TxtDestino.PasswordChar = '\0';
            this.TxtDestino.PrefixSuffixText = null;
            this.TxtDestino.ReadOnly = false;
            this.TxtDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDestino.SelectedText = "";
            this.TxtDestino.SelectionLength = 0;
            this.TxtDestino.SelectionStart = 0;
            this.TxtDestino.ShortcutsEnabled = true;
            this.TxtDestino.Size = new System.Drawing.Size(250, 48);
            this.TxtDestino.TabIndex = 1;
            this.TxtDestino.TabStop = false;
            this.TxtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDestino.TrailingIcon = null;
            this.TxtDestino.UseSystemPasswordChar = false;
            // 
            // TxtFecha
            // 
            this.TxtFecha.AnimateReadOnly = false;
            this.TxtFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtFecha.Depth = 0;
            this.TxtFecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtFecha.HideSelection = true;
            this.TxtFecha.Hint = "FECHA";
            this.TxtFecha.LeadingIcon = global::Etiquetas.Properties.Resources.icons8_calendario_50;
            this.TxtFecha.Location = new System.Drawing.Point(17, 17);
            this.TxtFecha.MaxLength = 32767;
            this.TxtFecha.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.PasswordChar = '\0';
            this.TxtFecha.PrefixSuffixText = null;
            this.TxtFecha.ReadOnly = false;
            this.TxtFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtFecha.SelectedText = "";
            this.TxtFecha.SelectionLength = 0;
            this.TxtFecha.SelectionStart = 0;
            this.TxtFecha.ShortcutsEnabled = true;
            this.TxtFecha.Size = new System.Drawing.Size(250, 48);
            this.TxtFecha.TabIndex = 0;
            this.TxtFecha.TabStop = false;
            this.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFecha.TrailingIcon = null;
            this.TxtFecha.UseSystemPasswordChar = false;
            // 
            // PageConsulta
            // 
            this.PageConsulta.Controls.Add(this.CardOpciones);
            this.PageConsulta.Controls.Add(this.CardData);
            this.PageConsulta.Controls.Add(this.CardFiltros);
            this.PageConsulta.ImageKey = "icons8-analytics-32.png";
            this.PageConsulta.Location = new System.Drawing.Point(4, 31);
            this.PageConsulta.Name = "PageConsulta";
            this.PageConsulta.Padding = new System.Windows.Forms.Padding(10);
            this.PageConsulta.Size = new System.Drawing.Size(786, 393);
            this.PageConsulta.TabIndex = 3;
            this.PageConsulta.Text = "Consultas";
            this.PageConsulta.UseVisualStyleBackColor = true;
            // 
            // CardOpciones
            // 
            this.CardOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardOpciones.Controls.Add(this.tableLayoutPanel1);
            this.CardOpciones.Depth = 0;
            this.CardOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CardOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardOpciones.Location = new System.Drawing.Point(10, 333);
            this.CardOpciones.Margin = new System.Windows.Forms.Padding(14);
            this.CardOpciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardOpciones.Name = "CardOpciones";
            this.CardOpciones.Padding = new System.Windows.Forms.Padding(1);
            this.CardOpciones.Size = new System.Drawing.Size(766, 50);
            this.CardOpciones.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.BtnVer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnActualizar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnVer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnVer.Depth = 0;
            this.BtnVer.HighEmphasis = true;
            this.BtnVer.Icon = global::Etiquetas.Properties.Resources.icons8_visible_50;
            this.BtnVer.Location = new System.Drawing.Point(114, 6);
            this.BtnVer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnVer.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnVer.Size = new System.Drawing.Size(76, 36);
            this.BtnVer.TabIndex = 0;
            this.BtnVer.Text = "Ver";
            this.BtnVer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnVer.UseAccentColor = false;
            this.BtnVer.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.HighEmphasis = true;
            this.BtnActualizar.Icon = global::Etiquetas.Properties.Resources.icons8_editar_64;
            this.BtnActualizar.Location = new System.Drawing.Point(311, 6);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnActualizar.Size = new System.Drawing.Size(137, 36);
            this.BtnActualizar.TabIndex = 1;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnActualizar.UseAccentColor = false;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.HighEmphasis = true;
            this.BtnEliminar.Icon = global::Etiquetas.Properties.Resources.icons8_basura_64;
            this.BtnEliminar.Location = new System.Drawing.Point(550, 6);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEliminar.Size = new System.Drawing.Size(116, 36);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnEliminar.UseAccentColor = false;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // CardData
            // 
            this.CardData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardData.Controls.Add(this.TablaData);
            this.CardData.Depth = 0;
            this.CardData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardData.Location = new System.Drawing.Point(35, 60);
            this.CardData.Margin = new System.Windows.Forms.Padding(25);
            this.CardData.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardData.Name = "CardData";
            this.CardData.Padding = new System.Windows.Forms.Padding(14);
            this.CardData.Size = new System.Drawing.Size(716, 275);
            this.CardData.TabIndex = 1;
            // 
            // TablaData
            // 
            this.TablaData.AllowUserToAddRows = false;
            this.TablaData.AllowUserToDeleteRows = false;
            this.TablaData.AllowUserToOrderColumns = true;
            this.TablaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaData.Location = new System.Drawing.Point(14, 14);
            this.TablaData.Name = "TablaData";
            this.TablaData.ReadOnly = true;
            this.TablaData.Size = new System.Drawing.Size(688, 247);
            this.TablaData.TabIndex = 0;
            // 
            // CardFiltros
            // 
            this.CardFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardFiltros.Controls.Add(this.tableLayoutPanel2);
            this.CardFiltros.Depth = 0;
            this.CardFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardFiltros.Location = new System.Drawing.Point(10, 10);
            this.CardFiltros.Margin = new System.Windows.Forms.Padding(14);
            this.CardFiltros.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardFiltros.Name = "CardFiltros";
            this.CardFiltros.Padding = new System.Windows.Forms.Padding(1);
            this.CardFiltros.Size = new System.Drawing.Size(766, 55);
            this.CardFiltros.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.BtnBuscar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboTipo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboNumero, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ComboDestino, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 53);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.DrawShadows = false;
            this.BtnBuscar.HighEmphasis = true;
            this.BtnBuscar.Icon = global::Etiquetas.Properties.Resources.icons8_búsqueda_50;
            this.BtnBuscar.Location = new System.Drawing.Point(555, 8);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnBuscar.Size = new System.Drawing.Size(105, 36);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnBuscar.UseAccentColor = false;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // ComboTipo
            // 
            this.ComboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboTipo.AutoResize = false;
            this.ComboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboTipo.Depth = 0;
            this.ComboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboTipo.DropDownHeight = 174;
            this.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipo.DropDownWidth = 121;
            this.ComboTipo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Hint = "Tipo";
            this.ComboTipo.IntegralHeight = false;
            this.ComboTipo.ItemHeight = 43;
            this.ComboTipo.Items.AddRange(new object[] {
            "EXTERNA",
            "INTERNA"});
            this.ComboTipo.Location = new System.Drawing.Point(92, 3);
            this.ComboTipo.MaxDropDownItems = 4;
            this.ComboTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(120, 49);
            this.ComboTipo.StartIndex = 0;
            this.ComboTipo.TabIndex = 0;
            // 
            // ComboNumero
            // 
            this.ComboNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboNumero.AutoResize = false;
            this.ComboNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboNumero.Depth = 0;
            this.ComboNumero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboNumero.DropDownHeight = 174;
            this.ComboNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNumero.DropDownWidth = 121;
            this.ComboNumero.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboNumero.FormattingEnabled = true;
            this.ComboNumero.Hint = "Numero";
            this.ComboNumero.IntegralHeight = false;
            this.ComboNumero.ItemHeight = 43;
            this.ComboNumero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ComboNumero.Location = new System.Drawing.Point(396, 3);
            this.ComboNumero.MaxDropDownItems = 4;
            this.ComboNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboNumero.Name = "ComboNumero";
            this.ComboNumero.Size = new System.Drawing.Size(120, 49);
            this.ComboNumero.StartIndex = 0;
            this.ComboNumero.TabIndex = 2;
            // 
            // ComboDestino
            // 
            this.ComboDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboDestino.AutoResize = false;
            this.ComboDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboDestino.Depth = 0;
            this.ComboDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboDestino.DropDownHeight = 174;
            this.ComboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDestino.DropDownWidth = 121;
            this.ComboDestino.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboDestino.FormattingEnabled = true;
            this.ComboDestino.Hint = "Destino";
            this.ComboDestino.IntegralHeight = false;
            this.ComboDestino.ItemHeight = 43;
            this.ComboDestino.Items.AddRange(new object[] {
            "CHINA",
            "UE",
            "USA",
            "HEBREO"});
            this.ComboDestino.Location = new System.Drawing.Point(244, 3);
            this.ComboDestino.MaxDropDownItems = 4;
            this.ComboDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboDestino.Name = "ComboDestino";
            this.ComboDestino.Size = new System.Drawing.Size(120, 49);
            this.ComboDestino.StartIndex = 0;
            this.ComboDestino.TabIndex = 1;
            // 
            // PageConfig
            // 
            this.PageConfig.ImageKey = "icons8-settings-50.png";
            this.PageConfig.Location = new System.Drawing.Point(4, 31);
            this.PageConfig.Name = "PageConfig";
            this.PageConfig.Size = new System.Drawing.Size(786, 393);
            this.PageConfig.TabIndex = 2;
            this.PageConfig.Text = "Configuracion";
            this.PageConfig.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.TabControlMain);
            this.Controls.Add(this.ProgressBarTop);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControlMain;
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TabControlMain.ResumeLayout(false);
            this.PageIngreso.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.PageConsulta.ResumeLayout(false);
            this.CardOpciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.CardData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaData)).EndInit();
            this.CardFiltros.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialProgressBar ProgressBarTop;
        private MaterialSkin.Controls.MaterialTabControl TabControlMain;
        private System.Windows.Forms.TabPage PageIngreso;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage PageConfig;
        private System.Windows.Forms.TabPage PageConsulta;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TxtModificacion;
        private MaterialSkin.Controls.MaterialSwitch SwitchEti;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNumero;
        private MaterialSkin.Controls.MaterialTextBox2 TxtDestino;
        private MaterialSkin.Controls.MaterialTextBox2 TxtFecha;
        private MaterialSkin.Controls.MaterialButton BtnGuardar;
        private MaterialSkin.Controls.MaterialCard CardOpciones;
        private MaterialSkin.Controls.MaterialCard CardData;
        private MaterialSkin.Controls.MaterialCard CardFiltros;
        private MaterialSkin.Controls.MaterialComboBox ComboTipo;
        private MaterialSkin.Controls.MaterialComboBox ComboDestino;
        private MaterialSkin.Controls.MaterialComboBox ComboNumero;
        private MaterialSkin.Controls.MaterialButton BtnBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton BtnVer;
        private MaterialSkin.Controls.MaterialButton BtnActualizar;
        private MaterialSkin.Controls.MaterialButton BtnEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView TablaData;
    }
}

