namespace PedidoXperto.ChildForms
{
    partial class Existencias
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
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            ExistenciaAlmacen = new Label();
            Enter = new Button();
            label2 = new Label();
            label1 = new Label();
            ExistenciaTienda = new Label();
            Descripcion = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 88);
            panelTop.TabIndex = 15;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(250, 5);
            label3.Name = "label3";
            label3.Size = new Size(113, 22);
            label3.TabIndex = 0;
            label3.Text = "EXISTENCIA";
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
            Exit.Location = new Point(542, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 27);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // ExistenciaAlmacen
            // 
            ExistenciaAlmacen.Anchor = AnchorStyles.None;
            ExistenciaAlmacen.Cursor = Cursors.Hand;
            ExistenciaAlmacen.FlatStyle = FlatStyle.Flat;
            ExistenciaAlmacen.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            ExistenciaAlmacen.ForeColor = Color.White;
            ExistenciaAlmacen.Location = new Point(345, 132);
            ExistenciaAlmacen.Name = "ExistenciaAlmacen";
            ExistenciaAlmacen.Size = new Size(99, 31);
            ExistenciaAlmacen.TabIndex = 14;
            ExistenciaAlmacen.Text = "0";
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = SystemColors.ActiveBorder;
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(222, 277);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 38);
            Enter.TabIndex = 13;
            Enter.Text = "Aceptar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(180, 132);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 9;
            label2.Text = "ALMACEN";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 174);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 10;
            label1.Text = "TIENDA";
            // 
            // ExistenciaTienda
            // 
            ExistenciaTienda.Anchor = AnchorStyles.None;
            ExistenciaTienda.FlatStyle = FlatStyle.Flat;
            ExistenciaTienda.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            ExistenciaTienda.ForeColor = Color.White;
            ExistenciaTienda.Location = new Point(345, 174);
            ExistenciaTienda.Name = "ExistenciaTienda";
            ExistenciaTienda.Size = new Size(99, 25);
            ExistenciaTienda.TabIndex = 16;
            ExistenciaTienda.Text = "0";
            // 
            // Descripcion
            // 
            Descripcion.Anchor = AnchorStyles.None;
            Descripcion.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Descripcion.ForeColor = Color.White;
            Descripcion.Location = new Point(12, 33);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(582, 83);
            Descripcion.TabIndex = 17;
            Descripcion.TextAlign = ContentAlignment.MiddleCenter;
            Descripcion.MouseDown += Descripcion_MouseDown;
            // 
            // Existencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(Descripcion);
            Controls.Add(ExistenciaTienda);
            Controls.Add(panelTop);
            Controls.Add(ExistenciaAlmacen);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Existencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Existencias";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Button Enter;
        private Label label2;
        private Label label1;
        public Label ExistenciaAlmacen;
        public Label ExistenciaTienda;
        public Label Descripcion;
    }
}