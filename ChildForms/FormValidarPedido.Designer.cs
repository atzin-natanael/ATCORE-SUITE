namespace PedidoXperto.ChildForms
{
    partial class FormValidarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Exit = new Button();
            Titulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtPedido = new TextBox();
            BtnPedido = new Button();
            BtnCodigo = new Button();
            TxtCodigo = new TextBox();
            Cb_Surtidor = new ComboBox();
            panel1 = new Panel();
            Cargar = new Button();
            Cancelado = new TextBox();
            Lb_Incompletos = new Label();
            Lb_renglones = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            Tabla = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.BackColor = SystemColors.ActiveCaptionText;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(1242, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(141, 50);
            Exit.TabIndex = 0;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(566, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(305, 28);
            Titulo.TabIndex = 1;
            Titulo.Text = "VALIDACION DE PEDIDOS";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 2;
            label1.Text = "SURTIDOR:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 124);
            label2.Name = "label2";
            label2.Size = new Size(267, 28);
            label2.TabIndex = 3;
            label2.Text = "CODIGO DE BARRAS:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 22);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 4;
            label3.Text = "PEDIDO:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPedido
            // 
            TxtPedido.Anchor = AnchorStyles.Top;
            TxtPedido.Location = new Point(174, 22);
            TxtPedido.Name = "TxtPedido";
            TxtPedido.Size = new Size(204, 27);
            TxtPedido.TabIndex = 5;
            // 
            // BtnPedido
            // 
            BtnPedido.Anchor = AnchorStyles.Top;
            BtnPedido.BackColor = SystemColors.ActiveCaptionText;
            BtnPedido.Cursor = Cursors.Hand;
            BtnPedido.FlatAppearance.BorderSize = 0;
            BtnPedido.FlatStyle = FlatStyle.Flat;
            BtnPedido.ForeColor = Color.White;
            BtnPedido.Location = new Point(397, 21);
            BtnPedido.Name = "BtnPedido";
            BtnPedido.Size = new Size(125, 28);
            BtnPedido.TabIndex = 6;
            BtnPedido.Text = "Validar";
            BtnPedido.UseVisualStyleBackColor = false;
            BtnPedido.Click += BtnPedido_Click;
            // 
            // BtnCodigo
            // 
            BtnCodigo.Anchor = AnchorStyles.Top;
            BtnCodigo.BackColor = SystemColors.ActiveCaptionText;
            BtnCodigo.Cursor = Cursors.Hand;
            BtnCodigo.FlatAppearance.BorderSize = 0;
            BtnCodigo.FlatStyle = FlatStyle.Flat;
            BtnCodigo.ForeColor = Color.White;
            BtnCodigo.Location = new Point(872, 126);
            BtnCodigo.Name = "BtnCodigo";
            BtnCodigo.Size = new Size(125, 28);
            BtnCodigo.TabIndex = 8;
            BtnCodigo.Text = "Agregar";
            BtnCodigo.UseVisualStyleBackColor = false;
            BtnCodigo.Click += BtnCodigo_Click;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Anchor = AnchorStyles.Top;
            TxtCodigo.Location = new Point(649, 127);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(204, 27);
            TxtCodigo.TabIndex = 7;
            // 
            // Cb_Surtidor
            // 
            Cb_Surtidor.Anchor = AnchorStyles.Top;
            Cb_Surtidor.FormattingEnabled = true;
            Cb_Surtidor.Location = new Point(174, 59);
            Cb_Surtidor.Name = "Cb_Surtidor";
            Cb_Surtidor.Size = new Size(348, 29);
            Cb_Surtidor.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(Cargar);
            panel1.Controls.Add(Cancelado);
            panel1.Controls.Add(Lb_Incompletos);
            panel1.Controls.Add(Lb_renglones);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnPedido);
            panel1.Controls.Add(Cb_Surtidor);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(BtnCodigo);
            panel1.Controls.Add(Titulo);
            panel1.Controls.Add(TxtCodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtPedido);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 171);
            panel1.TabIndex = 10;
            // 
            // Cargar
            // 
            Cargar.Anchor = AnchorStyles.Top;
            Cargar.BackColor = SystemColors.ActiveCaptionText;
            Cargar.Cursor = Cursors.Hand;
            Cargar.FlatAppearance.BorderSize = 0;
            Cargar.FlatStyle = FlatStyle.Flat;
            Cargar.ForeColor = Color.White;
            Cargar.Location = new Point(1242, 60);
            Cargar.Name = "Cargar";
            Cargar.Size = new Size(143, 28);
            Cargar.TabIndex = 15;
            Cargar.Text = "Cargar";
            Cargar.UseVisualStyleBackColor = false;
            // 
            // Cancelado
            // 
            Cancelado.Anchor = AnchorStyles.Top;
            Cancelado.Location = new Point(1018, 61);
            Cancelado.Name = "Cancelado";
            Cancelado.Size = new Size(204, 27);
            Cancelado.TabIndex = 14;
            // 
            // Lb_Incompletos
            // 
            Lb_Incompletos.Anchor = AnchorStyles.Top;
            Lb_Incompletos.FlatStyle = FlatStyle.Flat;
            Lb_Incompletos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            Lb_Incompletos.Location = new Point(1275, 140);
            Lb_Incompletos.Name = "Lb_Incompletos";
            Lb_Incompletos.Size = new Size(96, 28);
            Lb_Incompletos.TabIndex = 13;
            Lb_Incompletos.Text = "0";
            Lb_Incompletos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb_renglones
            // 
            Lb_renglones.Anchor = AnchorStyles.Top;
            Lb_renglones.FlatStyle = FlatStyle.Flat;
            Lb_renglones.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            Lb_renglones.Location = new Point(235, 140);
            Lb_renglones.Name = "Lb_renglones";
            Lb_renglones.Size = new Size(123, 28);
            Lb_renglones.TabIndex = 12;
            Lb_renglones.Text = "0";
            Lb_renglones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label5.Location = new Point(1003, 140);
            label5.Name = "label5";
            label5.Size = new Size(262, 28);
            label5.TabIndex = 11;
            label5.Text = "RENGLONES INCOMPLETOS:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label4.Location = new Point(3, 140);
            label4.Name = "label4";
            label4.Size = new Size(238, 28);
            label4.TabIndex = 10;
            label4.Text = "RENGLONES PENDIENTES:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(Tabla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 651);
            panel2.TabIndex = 11;
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.ColumnHeadersHeight = 50;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            Tabla.Dock = DockStyle.Fill;
            Tabla.Location = new Point(0, 0);
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersVisible = false;
            Tabla.Size = new Size(1383, 651);
            Tabla.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Codigo";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Descripcion";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad Solicitada";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad Revisada";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Nota";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Cantidad Pendiente";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // FormValidarPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1383, 822);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormValidarPedido";
            Text = "FormValidarPedido";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Exit;
        private Label Titulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtPedido;
        private Button BtnPedido;
        private Button BtnCodigo;
        private TextBox TxtCodigo;
        private ComboBox Cb_Surtidor;
        private Panel panel1;
        private Panel panel2;
        private DataGridView Tabla;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label Lb_Incompletos;
        private Label Lb_renglones;
        private Label label5;
        private Label label4;
        private Button Cargar;
        private TextBox Cancelado;
    }
}