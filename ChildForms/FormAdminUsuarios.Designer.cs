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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Exit = new Button();
            Titulo = new Label();
            panelTop = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            TablaUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
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
            panelTop.Size = new Size(1383, 51);
            panelTop.TabIndex = 5;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(164, 0);
            button1.Name = "button1";
            button1.Size = new Size(137, 62);
            button1.TabIndex = 4;
            button1.Text = "AGREGAR USUARIO";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 46, 178);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 62);
            panel2.TabIndex = 5;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.DimGray;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1035, 0);
            button4.Name = "button4";
            button4.Size = new Size(155, 62);
            button4.TabIndex = 7;
            button4.Text = "CAMBIAR NOMBRE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.DimGray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(690, 0);
            button3.Name = "button3";
            button3.Size = new Size(159, 62);
            button3.TabIndex = 6;
            button3.Text = "CAMBIAR CONTRASEÑA";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.DimGray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(345, 0);
            button2.Name = "button2";
            button2.Size = new Size(159, 62);
            button2.TabIndex = 5;
            button2.Text = "ELIMINAR USUARIO";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(TablaUsuarios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 709);
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
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
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
            TablaUsuarios.Size = new Size(1383, 709);
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
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TablaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Exit;
        private Label Titulo;
        private Panel panelTop;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private DataGridView TablaUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}