﻿namespace ATCORE_SUITE.ChildForms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidarPedido));
            panel2 = new Panel();
            panel3 = new Panel();
            Tabla = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            Lbcancelado = new Label();
            Cancelado = new TextBox();
            panel4 = new Panel();
            Titulo = new Label();
            Exit = new Button();
            Cb_Descuentos = new CheckBox();
            Save = new Button();
            Lb_Incompletos = new Label();
            Lb_renglones = new Label();
            label5 = new Label();
            label4 = new Label();
            BtnPedido = new Button();
            Cb_Surtidor = new ComboBox();
            BtnCodigo = new Button();
            TxtCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtPedido = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 701);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Beige;
            panel3.Controls.Add(Tabla);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 451);
            panel3.TabIndex = 11;
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.AllowUserToResizeColumns = false;
            Tabla.AllowUserToResizeRows = false;
            Tabla.BackgroundColor = Color.Beige;
            Tabla.BorderStyle = BorderStyle.None;
            Tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Tabla.ColumnHeadersHeight = 50;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            Tabla.Dock = DockStyle.Fill;
            Tabla.EnableHeadersVisualStyles = false;
            Tabla.GridColor = Color.Black;
            Tabla.Location = new Point(0, 0);
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersVisible = false;
            Tabla.RowHeadersWidth = 50;
            Tabla.RowTemplate.Height = 40;
            Tabla.Size = new Size(1180, 451);
            Tabla.TabIndex = 1;
            Tabla.CellClick += Tabla_CellClick;
            Tabla.CellMouseDown += Tabla_CellMouseDown;
            Tabla.EditingControlShowing += Tabla_EditingControlShowing;
            Tabla.KeyDown += Tabla_KeyDown;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.HeaderText = "Codigo";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Descripcion";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad Solicitada";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad Revisada";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            // 
            // Column6
            // 
            Column6.HeaderText = "Nota";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.False;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            Column7.HeaderText = "Cantidad Pendiente";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(Lbcancelado);
            panel1.Controls.Add(Cancelado);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(Cb_Descuentos);
            panel1.Controls.Add(Save);
            panel1.Controls.Add(Lb_Incompletos);
            panel1.Controls.Add(Lb_renglones);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BtnPedido);
            panel1.Controls.Add(Cb_Surtidor);
            panel1.Controls.Add(BtnCodigo);
            panel1.Controls.Add(TxtCodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtPedido);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 250);
            panel1.TabIndex = 10;
            // 
            // Lbcancelado
            // 
            Lbcancelado.Anchor = AnchorStyles.Left;
            Lbcancelado.FlatStyle = FlatStyle.Flat;
            Lbcancelado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbcancelado.ForeColor = Color.Black;
            Lbcancelado.Location = new Point(315, 55);
            Lbcancelado.Name = "Lbcancelado";
            Lbcancelado.Size = new Size(165, 37);
            Lbcancelado.TabIndex = 10;
            Lbcancelado.Text = "Cargar pedido cancelado";
            Lbcancelado.TextAlign = ContentAlignment.MiddleCenter;
            Lbcancelado.Visible = false;
            // 
            // Cancelado
            // 
            Cancelado.BorderStyle = BorderStyle.FixedSingle;
            Cancelado.CharacterCasing = CharacterCasing.Upper;
            Cancelado.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelado.Location = new Point(327, 95);
            Cancelado.Name = "Cancelado";
            Cancelado.Size = new Size(140, 27);
            Cancelado.TabIndex = 9;
            Cancelado.Visible = false;
            Cancelado.KeyDown += Cancelado_KeyDown;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.Controls.Add(Titulo);
            panel4.Controls.Add(Exit);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1180, 54);
            panel4.TabIndex = 8;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top;
            Titulo.BackColor = Color.FromArgb(50, 50, 50);
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(430, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(465, 40);
            Titulo.TabIndex = 0;
            Titulo.Text = "VALIDACION DE PEDIDOS";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.BackColor = Color.FromArgb(50, 50, 50);
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(1119, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(61, 54);
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Cb_Descuentos
            // 
            Cb_Descuentos.Anchor = AnchorStyles.Right;
            Cb_Descuentos.AutoSize = true;
            Cb_Descuentos.Checked = true;
            Cb_Descuentos.CheckState = CheckState.Checked;
            Cb_Descuentos.FlatStyle = FlatStyle.Flat;
            Cb_Descuentos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cb_Descuentos.Location = new Point(1048, 58);
            Cb_Descuentos.Name = "Cb_Descuentos";
            Cb_Descuentos.Size = new Size(126, 28);
            Cb_Descuentos.TabIndex = 7;
            Cb_Descuentos.Text = "Descuentos";
            Cb_Descuentos.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Save.BackColor = Color.FromArgb(50, 50, 50);
            Save.Cursor = Cursors.Hand;
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = SystemColors.Control;
            Save.Location = new Point(948, 174);
            Save.Name = "Save";
            Save.Size = new Size(232, 54);
            Save.TabIndex = 6;
            Save.Text = "Guardar";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            Save.MouseEnter += Save_MouseEnter;
            Save.MouseLeave += Save_MouseLeave;
            // 
            // Lb_Incompletos
            // 
            Lb_Incompletos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Lb_Incompletos.FlatStyle = FlatStyle.Flat;
            Lb_Incompletos.Font = new Font("Microsoft Sans Serif", 15.75F);
            Lb_Incompletos.ForeColor = Color.Black;
            Lb_Incompletos.Location = new Point(1094, 138);
            Lb_Incompletos.Name = "Lb_Incompletos";
            Lb_Incompletos.Size = new Size(80, 28);
            Lb_Incompletos.TabIndex = 0;
            Lb_Incompletos.Text = "0";
            Lb_Incompletos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lb_renglones
            // 
            Lb_renglones.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Lb_renglones.FlatStyle = FlatStyle.Flat;
            Lb_renglones.Font = new Font("Microsoft Sans Serif", 15.75F);
            Lb_renglones.ForeColor = Color.Black;
            Lb_renglones.Location = new Point(1094, 110);
            Lb_renglones.Name = "Lb_renglones";
            Lb_renglones.Size = new Size(80, 28);
            Lb_renglones.TabIndex = 0;
            Lb_renglones.Text = "0";
            Lb_renglones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(775, 138);
            label5.Name = "label5";
            label5.Size = new Size(325, 28);
            label5.TabIndex = 0;
            label5.Text = "RENGLONES INCOMPLETOS:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(795, 110);
            label4.Name = "label4";
            label4.Size = new Size(305, 28);
            label4.TabIndex = 0;
            label4.Text = "RENGLONES PENDIENTES:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnPedido
            // 
            BtnPedido.BackColor = Color.FromArgb(50, 50, 50);
            BtnPedido.Cursor = Cursors.Hand;
            BtnPedido.FlatAppearance.BorderSize = 0;
            BtnPedido.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPedido.FlatStyle = FlatStyle.Flat;
            BtnPedido.Font = new Font("Microsoft Sans Serif", 12F);
            BtnPedido.ForeColor = Color.White;
            BtnPedido.Location = new Point(502, 96);
            BtnPedido.Name = "BtnPedido";
            BtnPedido.Size = new Size(129, 31);
            BtnPedido.TabIndex = 2;
            BtnPedido.Text = "Validar";
            BtnPedido.UseVisualStyleBackColor = false;
            BtnPedido.Visible = false;
            BtnPedido.Click += BtnPedido_Click;
            BtnPedido.KeyDown += BtnPedido_KeyDown;
            // 
            // Cb_Surtidor
            // 
            Cb_Surtidor.FlatStyle = FlatStyle.System;
            Cb_Surtidor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cb_Surtidor.FormattingEnabled = true;
            Cb_Surtidor.Location = new Point(177, 151);
            Cb_Surtidor.Name = "Cb_Surtidor";
            Cb_Surtidor.Size = new Size(290, 27);
            Cb_Surtidor.TabIndex = 3;
            Cb_Surtidor.KeyDown += Cb_Surtidor_KeyDown;
            Cb_Surtidor.KeyPress += Cb_Surtidor_KeyPress;
            // 
            // BtnCodigo
            // 
            BtnCodigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnCodigo.BackColor = Color.FromArgb(50, 50, 50);
            BtnCodigo.Cursor = Cursors.Hand;
            BtnCodigo.FlatAppearance.BorderSize = 0;
            BtnCodigo.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnCodigo.FlatStyle = FlatStyle.Flat;
            BtnCodigo.Font = new Font("Microsoft Sans Serif", 12F);
            BtnCodigo.ForeColor = Color.White;
            BtnCodigo.Location = new Point(502, 188);
            BtnCodigo.Name = "BtnCodigo";
            BtnCodigo.Size = new Size(125, 36);
            BtnCodigo.TabIndex = 5;
            BtnCodigo.Text = "Agregar";
            BtnCodigo.UseVisualStyleBackColor = false;
            BtnCodigo.Visible = false;
            BtnCodigo.Click += BtnCodigo_Click;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtCodigo.BorderStyle = BorderStyle.FixedSingle;
            TxtCodigo.Location = new Point(177, 206);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(290, 27);
            TxtCodigo.TabIndex = 4;
            TxtCodigo.KeyDown += TxtCodigo_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 150);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "SURTIDOR:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(150, 67);
            label2.TabIndex = 0;
            label2.Text = "CÓDIGO DE BARRAS:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPedido
            // 
            TxtPedido.BorderStyle = BorderStyle.FixedSingle;
            TxtPedido.CharacterCasing = CharacterCasing.Upper;
            TxtPedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPedido.Location = new Point(177, 95);
            TxtPedido.Name = "TxtPedido";
            TxtPedido.Size = new Size(290, 27);
            TxtPedido.TabIndex = 1;
            TxtPedido.KeyDown += TxtPedido_KeyDown;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 0;
            label3.Text = "PEDIDO:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormValidarPedido
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1180, 701);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormValidarPedido";
            Text = "FormValidarPedido";
            Load += FormValidarPedido_Load;
            KeyDown += FormValidarPedido_KeyDown;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private CheckBox Cb_Descuentos;
        private Button Save;
        private Label Lb_Incompletos;
        private Label Lb_renglones;
        private Label label5;
        private Label label4;
        private Button BtnPedido;
        private ComboBox Cb_Surtidor;
        private Button Exit;
        private Button BtnCodigo;
        private Label Titulo;
        private TextBox TxtCodigo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private DataGridView Tabla;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel4;
        public TextBox TxtPedido;
        public TextBox Cancelado;
        private Label Lbcancelado;
    }
}