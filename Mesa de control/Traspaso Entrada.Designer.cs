namespace ATCORE_SUITE.Mesa_de_control
{
    partial class Traspaso_Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Traspaso_Entrada));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            Importar = new Button();
            TxtFolio = new TextBox();
            LbFolio = new Label();
            panel1 = new Panel();
            Exit = new Button();
            Titulo = new Label();
            Tabla = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            SuspendLayout();
            // 
            // Importar
            // 
            Importar.Anchor = AnchorStyles.None;
            Importar.BackColor = Color.Black;
            Importar.Cursor = Cursors.Hand;
            Importar.FlatAppearance.BorderSize = 0;
            Importar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            Importar.FlatStyle = FlatStyle.Flat;
            Importar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Importar.ForeColor = Color.White;
            Importar.Location = new Point(538, 182);
            Importar.Name = "Importar";
            Importar.Size = new Size(160, 63);
            Importar.TabIndex = 19;
            Importar.Text = "Importar";
            Importar.UseVisualStyleBackColor = false;
            Importar.Visible = false;
            Importar.Click += Importar_Click;
            // 
            // TxtFolio
            // 
            TxtFolio.Anchor = AnchorStyles.None;
            TxtFolio.BackColor = Color.White;
            TxtFolio.BorderStyle = BorderStyle.FixedSingle;
            TxtFolio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFolio.Location = new Point(470, 119);
            TxtFolio.Name = "TxtFolio";
            TxtFolio.Size = new Size(295, 29);
            TxtFolio.TabIndex = 18;
            TxtFolio.KeyDown += TxtFolio_KeyDown;
            // 
            // LbFolio
            // 
            LbFolio.Anchor = AnchorStyles.None;
            LbFolio.AutoSize = true;
            LbFolio.FlatStyle = FlatStyle.Flat;
            LbFolio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbFolio.ForeColor = Color.Black;
            LbFolio.Location = new Point(388, 119);
            LbFolio.Name = "LbFolio";
            LbFolio.Size = new Size(63, 24);
            LbFolio.TabIndex = 17;
            LbFolio.Text = "Folio:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(Titulo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 54);
            panel1.TabIndex = 15;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(50, 50, 50);
            Exit.Cursor = Cursors.Hand;
            Exit.Dock = DockStyle.Right;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.White;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(1119, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(61, 54);
            Exit.TabIndex = 6;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.BackColor = Color.FromArgb(50, 50, 50);
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(412, -1);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(411, 53);
            Titulo.TabIndex = 5;
            Titulo.Text = "Recibir Traspaso";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.AllowUserToResizeColumns = false;
            Tabla.AllowUserToResizeRows = false;
            Tabla.Anchor = AnchorStyles.None;
            Tabla.BackgroundColor = Color.Beige;
            Tabla.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            Tabla.ColumnHeadersHeight = 45;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            Tabla.DefaultCellStyle = dataGridViewCellStyle10;
            Tabla.EnableHeadersVisualStyles = false;
            Tabla.GridColor = SystemColors.Desktop;
            Tabla.Location = new Point(45, 277);
            Tabla.MultiSelect = false;
            Tabla.Name = "Tabla";
            Tabla.ReadOnly = true;
            Tabla.RowHeadersVisible = false;
            Tabla.RowTemplate.Height = 40;
            Tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tabla.Size = new Size(1063, 412);
            Tabla.TabIndex = 20;
            Tabla.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Código";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Descripción";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Traspaso_Entrada
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Beige;
            ClientSize = new Size(1180, 701);
            Controls.Add(Tabla);
            Controls.Add(Importar);
            Controls.Add(TxtFolio);
            Controls.Add(LbFolio);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Traspaso_Entrada";
            Text = "Traspaso_Entrada";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Importar;
        public TextBox TxtFolio;
        private Label LbFolio;
        private Panel panel1;
        private Button Exit;
        private Label Titulo;
        private DataGridView Tabla;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}