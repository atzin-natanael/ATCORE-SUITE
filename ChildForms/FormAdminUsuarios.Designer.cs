namespace PedidoXperto.ChildForms
{
    partial class FormAdminUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Exit = new Button();
            Titulo = new Label();
            panelTop = new Panel();
            panel2 = new Panel();
            SubpanelMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BtnMen = new Button();
            panel1 = new Panel();
            TablaUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            SubpanelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TablaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.BackColor = SystemColors.ActiveCaptionText;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(1242, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(141, 50);
            Exit.TabIndex = 3;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(515, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(443, 28);
            Titulo.TabIndex = 4;
            Titulo.Text = "ADMINISTRADOR DE USUARIOS";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(49, 46, 178);
            panelTop.Controls.Add(Exit);
            panelTop.Controls.Add(Titulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1383, 53);
            panelTop.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 46, 178);
            panel2.Controls.Add(SubpanelMenu);
            panel2.Controls.Add(BtnMen);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 46);
            panel2.TabIndex = 5;
            // 
            // SubpanelMenu
            // 
            SubpanelMenu.Controls.Add(button5);
            SubpanelMenu.Controls.Add(button4);
            SubpanelMenu.Controls.Add(button3);
            SubpanelMenu.Controls.Add(button2);
            SubpanelMenu.Controls.Add(button1);
            SubpanelMenu.Dock = DockStyle.Fill;
            SubpanelMenu.Location = new Point(115, 0);
            SubpanelMenu.Name = "SubpanelMenu";
            SubpanelMenu.Size = new Size(1268, 46);
            SubpanelMenu.TabIndex = 7;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.FromArgb(150, 150, 150);
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(688, 0);
            button5.Name = "button5";
            button5.Size = new Size(172, 46);
            button5.TabIndex = 12;
            button5.Text = "Cambiar Contraseña";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(150, 150, 150);
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(516, 0);
            button4.Name = "button4";
            button4.Size = new Size(172, 46);
            button4.TabIndex = 11;
            button4.Text = "Cambiar Nombre";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(150, 150, 150);
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(344, 0);
            button3.Name = "button3";
            button3.Size = new Size(172, 46);
            button3.TabIndex = 10;
            button3.Text = "Editar Rol";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(150, 150, 150);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(172, 0);
            button2.Name = "button2";
            button2.Size = new Size(172, 46);
            button2.TabIndex = 9;
            button2.Text = "Eliminar Usuario";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(150, 150, 150);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(172, 46);
            button1.TabIndex = 8;
            button1.Text = "Agregar Usuario";
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnMen
            // 
            BtnMen.BackColor = Color.DimGray;
            BtnMen.Cursor = Cursors.Hand;
            BtnMen.Dock = DockStyle.Left;
            BtnMen.FlatAppearance.BorderSize = 0;
            BtnMen.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            BtnMen.FlatStyle = FlatStyle.Flat;
            BtnMen.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMen.ForeColor = Color.Black;
            BtnMen.Image = (Image)resources.GetObject("BtnMen.Image");
            BtnMen.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMen.Location = new Point(0, 0);
            BtnMen.Name = "BtnMen";
            BtnMen.Size = new Size(115, 46);
            BtnMen.TabIndex = 6;
            BtnMen.Text = "Menú";
            BtnMen.TextAlign = ContentAlignment.MiddleRight;
            BtnMen.UseVisualStyleBackColor = false;
            BtnMen.Click += BtnMen_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TablaUsuarios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 723);
            panel1.TabIndex = 6;
            // 
            // TablaUsuarios
            // 
            TablaUsuarios.AllowUserToAddRows = false;
            TablaUsuarios.AllowUserToDeleteRows = false;
            TablaUsuarios.AllowUserToResizeColumns = false;
            TablaUsuarios.AllowUserToResizeRows = false;
            TablaUsuarios.BackgroundColor = SystemColors.ActiveBorder;
            TablaUsuarios.BorderStyle = BorderStyle.None;
            TablaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TablaUsuarios.ColumnHeadersHeight = 50;
            TablaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TablaUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Column1, Column2 });
            TablaUsuarios.Dock = DockStyle.Fill;
            TablaUsuarios.EnableHeadersVisualStyles = false;
            TablaUsuarios.GridColor = Color.Black;
            TablaUsuarios.Location = new Point(0, 0);
            TablaUsuarios.Name = "TablaUsuarios";
            TablaUsuarios.ReadOnly = true;
            TablaUsuarios.RowHeadersVisible = false;
            TablaUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TablaUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaUsuarios.Size = new Size(1383, 723);
            TablaUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Usuario";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Rol";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // FormAdminUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 822);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdminUsuarios";
            Text = "FormAdminUsuarios";
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            SubpanelMenu.ResumeLayout(false);
            SubpanelMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Exit;
        private Label Titulo;
        private Panel panelTop;
        private Panel panel2;
        private Panel panel1;
        private DataGridView TablaUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button BtnMen;
        private Button button1;
        private Panel SubpanelMenu;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}