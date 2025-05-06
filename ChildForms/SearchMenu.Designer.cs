namespace PedidoXperto.ChildForms
{
    partial class SearchMenu
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Txt_Nombre = new TextBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            Buscar = new Button();
            Concepto = new Label();
            Tabla = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.CharacterCasing = CharacterCasing.Upper;
            Txt_Nombre.Font = new Font("Century Gothic", 9.75F);
            Txt_Nombre.Location = new Point(128, 54);
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.Size = new Size(365, 23);
            Txt_Nombre.TabIndex = 2;
            Txt_Nombre.KeyDown += Txt_Nombre_KeyDown;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(60, 60, 60);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(676, 44);
            panelTop.TabIndex = 15;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(236, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 22);
            label3.TabIndex = 0;
            label3.Text = "BUSCAR ARTICULO";
            label3.MouseDown += label3_MouseDown;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.BackColor = SystemColors.ActiveBorder;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(612, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 30);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Buscar
            // 
            Buscar.Anchor = AnchorStyles.Top;
            Buscar.BackColor = SystemColors.ActiveBorder;
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatAppearance.BorderSize = 0;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Century Gothic", 9.75F);
            Buscar.ForeColor = Color.Black;
            Buscar.Location = new Point(528, 50);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(87, 28);
            Buscar.TabIndex = 3;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // Concepto
            // 
            Concepto.AutoSize = true;
            Concepto.BackColor = Color.FromArgb(60, 60, 60);
            Concepto.Font = new Font("Century Gothic", 9.75F);
            Concepto.ForeColor = Color.White;
            Concepto.Location = new Point(45, 57);
            Concepto.Name = "Concepto";
            Concepto.Size = new Size(61, 17);
            Concepto.TabIndex = 0;
            Concepto.Text = "Nombre";
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.BackgroundColor = Color.FromArgb(60, 60, 60);
            Tabla.BorderStyle = BorderStyle.None;
            Tabla.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Tabla.ColumnHeadersHeight = 30;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            Tabla.Dock = DockStyle.Fill;
            Tabla.EnableHeadersVisualStyles = false;
            Tabla.Location = new Point(0, 0);
            Tabla.MultiSelect = false;
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersVisible = false;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.Size = new Size(676, 222);
            Tabla.TabIndex = 1;
            Tabla.CellDoubleClick += Tabla_CellDoubleClick;
            Tabla.KeyDown += Tabla_KeyDown;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio Lista";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            // 
            // Column4
            // 
            Column4.HeaderText = "Existencia";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(Tabla);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 222);
            panel1.TabIndex = 17;
            // 
            // SearchMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(676, 334);
            Controls.Add(panel1);
            Controls.Add(Txt_Nombre);
            Controls.Add(panelTop);
            Controls.Add(Buscar);
            Controls.Add(Concepto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchMenu";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Button Buscar;
        private Label Concepto;
        private Panel panel1;
        public TextBox Txt_Nombre;
        public DataGridView Tabla;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}