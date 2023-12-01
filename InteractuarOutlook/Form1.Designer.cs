namespace InteractuarOutlook {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgBandejaEmail = new DataGridView();
            panelSuperior = new Panel();
            groupBox1 = new GroupBox();
            label7 = new Label();
            cbBandejasEntrada = new ComboBox();
            groupBox2 = new GroupBox();
            rdbEnviado = new RadioButton();
            rdbRecibido = new RadioButton();
            txtCuerpoFiltro = new TextBox();
            label6 = new Label();
            dtpFechaFinalFiltro = new DateTimePicker();
            dtpFechaInicioFiltro = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            btnLimpiarFiltro = new Button();
            label4 = new Label();
            btnAceptarFiltro = new Button();
            label3 = new Label();
            label1 = new Label();
            txtAsuntosFiltro = new TextBox();
            txtReceptorFiltro = new TextBox();
            txtEmisorFiltro = new TextBox();
            panelCentral = new Panel();
            panelDerecho = new Panel();
            rtbCuerpoCorreo = new RichTextBox();
            panelIzquierdo = new Panel();
            toolStrip1 = new ToolStrip();
            tbbResponderCorreoOutlook = new ToolStripButton();
            panelInferior = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgBandejaEmail).BeginInit();
            panelSuperior.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panelCentral.SuspendLayout();
            panelDerecho.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgBandejaEmail
            // 
            dgBandejaEmail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBandejaEmail.BackgroundColor = Color.White;
            dgBandejaEmail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBandejaEmail.Dock = DockStyle.Top;
            dgBandejaEmail.Location = new Point(0, 0);
            dgBandejaEmail.Name = "dgBandejaEmail";
            dgBandejaEmail.RowTemplate.Height = 25;
            dgBandejaEmail.Size = new Size(1431, 644);
            dgBandejaEmail.TabIndex = 0;
            dgBandejaEmail.CellClick += dgBandejaEmail_CellClick;
            dgBandejaEmail.CellFormatting += dgBandejaEmail_CellFormatting;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(groupBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1904, 144);
            panelSuperior.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbBandejasEntrada);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtCuerpoFiltro);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpFechaFinalFiltro);
            groupBox1.Controls.Add(dtpFechaInicioFiltro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnLimpiarFiltro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAceptarFiltro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAsuntosFiltro);
            groupBox1.Controls.Add(txtReceptorFiltro);
            groupBox1.Controls.Add(txtEmisorFiltro);
            groupBox1.Location = new Point(3, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 135);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 25);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 19;
            label7.Text = "Bandeja";
            // 
            // cbBandejasEntrada
            // 
            cbBandejasEntrada.FormattingEnabled = true;
            cbBandejasEntrada.Location = new Point(427, 21);
            cbBandejasEntrada.Name = "cbBandejasEntrada";
            cbBandejasEntrada.Size = new Size(121, 23);
            cbBandejasEntrada.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbEnviado);
            groupBox2.Controls.Add(rdbRecibido);
            groupBox2.Location = new Point(372, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 52);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enviado/Recibido";
            // 
            // rdbEnviado
            // 
            rdbEnviado.AutoSize = true;
            rdbEnviado.Location = new Point(81, 22);
            rdbEnviado.Name = "rdbEnviado";
            rdbEnviado.Size = new Size(67, 19);
            rdbEnviado.TabIndex = 12;
            rdbEnviado.Text = "Enviado";
            rdbEnviado.UseVisualStyleBackColor = true;
            // 
            // rdbRecibido
            // 
            rdbRecibido.AutoSize = true;
            rdbRecibido.Checked = true;
            rdbRecibido.Location = new Point(6, 22);
            rdbRecibido.Name = "rdbRecibido";
            rdbRecibido.Size = new Size(71, 19);
            rdbRecibido.TabIndex = 11;
            rdbRecibido.TabStop = true;
            rdbRecibido.Text = "Recibido";
            rdbRecibido.UseVisualStyleBackColor = true;
            // 
            // txtCuerpoFiltro
            // 
            txtCuerpoFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtCuerpoFiltro.Location = new Point(85, 78);
            txtCuerpoFiltro.Name = "txtCuerpoFiltro";
            txtCuerpoFiltro.Size = new Size(281, 23);
            txtCuerpoFiltro.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 81);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 16;
            label6.Text = "Cuerpo:";
            // 
            // dtpFechaFinalFiltro
            // 
            dtpFechaFinalFiltro.Format = DateTimePickerFormat.Short;
            dtpFechaFinalFiltro.Location = new Point(266, 107);
            dtpFechaFinalFiltro.Name = "dtpFechaFinalFiltro";
            dtpFechaFinalFiltro.Size = new Size(100, 23);
            dtpFechaFinalFiltro.TabIndex = 15;
            // 
            // dtpFechaInicioFiltro
            // 
            dtpFechaInicioFiltro.Format = DateTimePickerFormat.Short;
            dtpFechaInicioFiltro.Location = new Point(85, 107);
            dtpFechaInicioFiltro.Name = "dtpFechaInicioFiltro";
            dtpFechaInicioFiltro.Size = new Size(100, 23);
            dtpFechaInicioFiltro.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 113);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 13;
            label5.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 113);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 12;
            label2.Text = "Fecha Final:";
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.Location = new Point(466, 107);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(82, 23);
            btnLimpiarFiltro.TabIndex = 11;
            btnLimpiarFiltro.Text = "Limpiar";
            btnLimpiarFiltro.UseVisualStyleBackColor = true;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 25);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Receptor:";
            // 
            // btnAceptarFiltro
            // 
            btnAceptarFiltro.Location = new Point(372, 107);
            btnAceptarFiltro.Name = "btnAceptarFiltro";
            btnAceptarFiltro.Size = new Size(82, 23);
            btnAceptarFiltro.TabIndex = 10;
            btnAceptarFiltro.Text = "Aceptar";
            btnAceptarFiltro.UseVisualStyleBackColor = true;
            btnAceptarFiltro.Click += btnAceptarFiltro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 25);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Emisor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Asunto:";
            // 
            // txtAsuntosFiltro
            // 
            txtAsuntosFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtAsuntosFiltro.Location = new Point(85, 51);
            txtAsuntosFiltro.Name = "txtAsuntosFiltro";
            txtAsuntosFiltro.Size = new Size(281, 23);
            txtAsuntosFiltro.TabIndex = 2;
            // 
            // txtReceptorFiltro
            // 
            txtReceptorFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtReceptorFiltro.Location = new Point(266, 22);
            txtReceptorFiltro.Name = "txtReceptorFiltro";
            txtReceptorFiltro.Size = new Size(100, 23);
            txtReceptorFiltro.TabIndex = 1;
            // 
            // txtEmisorFiltro
            // 
            txtEmisorFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtEmisorFiltro.Location = new Point(85, 22);
            txtEmisorFiltro.Name = "txtEmisorFiltro";
            txtEmisorFiltro.Size = new Size(112, 23);
            txtEmisorFiltro.TabIndex = 0;
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(panelDerecho);
            panelCentral.Controls.Add(panelIzquierdo);
            panelCentral.Controls.Add(toolStrip1);
            panelCentral.Dock = DockStyle.Top;
            panelCentral.Location = new Point(0, 144);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1904, 672);
            panelCentral.TabIndex = 2;
            // 
            // panelDerecho
            // 
            panelDerecho.Controls.Add(rtbCuerpoCorreo);
            panelDerecho.Dock = DockStyle.Left;
            panelDerecho.Location = new Point(1431, 25);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(463, 647);
            panelDerecho.TabIndex = 3;
            // 
            // rtbCuerpoCorreo
            // 
            rtbCuerpoCorreo.BorderStyle = BorderStyle.FixedSingle;
            rtbCuerpoCorreo.Dock = DockStyle.Fill;
            rtbCuerpoCorreo.Location = new Point(0, 0);
            rtbCuerpoCorreo.Name = "rtbCuerpoCorreo";
            rtbCuerpoCorreo.ReadOnly = true;
            rtbCuerpoCorreo.Size = new Size(463, 647);
            rtbCuerpoCorreo.TabIndex = 0;
            rtbCuerpoCorreo.Text = "";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.Controls.Add(dgBandejaEmail);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 25);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(1431, 647);
            panelIzquierdo.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tbbResponderCorreoOutlook });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1904, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tbbResponderCorreoOutlook
            // 
            tbbResponderCorreoOutlook.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbbResponderCorreoOutlook.Image = (Image)resources.GetObject("tbbResponderCorreoOutlook.Image");
            tbbResponderCorreoOutlook.ImageTransparentColor = Color.Magenta;
            tbbResponderCorreoOutlook.Name = "tbbResponderCorreoOutlook";
            tbbResponderCorreoOutlook.Size = new Size(23, 22);
            tbbResponderCorreoOutlook.Text = "Responder mediante Outlook";
            tbbResponderCorreoOutlook.Click += tbbResponderCorreoOutlook_Click;
            // 
            // panelInferior
            // 
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 816);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1904, 225);
            panelInferior.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panelInferior);
            Controls.Add(panelCentral);
            Controls.Add(panelSuperior);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgBandejaEmail).EndInit();
            panelSuperior.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            panelDerecho.ResumeLayout(false);
            panelIzquierdo.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgBandejaEmail;
        private Panel panelSuperior;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtAsuntosFiltro;
        private TextBox txtReceptorFiltro;
        private TextBox txtEmisorFiltro;
        private GroupBox groupBox1;
        private Button btnLimpiarFiltro;
        private Button btnAceptarFiltro;
        private DateTimePicker dtpFechaFinalFiltro;
        private DateTimePicker dtpFechaInicioFiltro;
        private Label label5;
        private Label label2;
        private Panel panelCentral;
        private Panel panelInferior;
        private ToolStrip toolStrip1;
        private ToolStripButton tbbContestarApp;
        private ToolStripButton tbbResponderCorreoOutlook;
        private Panel panelIzquierdo;
        private Panel panelDerecho;
        private RichTextBox rtbCuerpoCorreo;
        private TextBox txtCuerpoFiltro;
        private Label label6;
        private GroupBox groupBox2;
        private RadioButton rdbEnviado;
        private RadioButton rdbRecibido;
        private Label label7;
        private ComboBox cbBandejasEntrada;
    }
}
