namespace ATCORE_SUITE.ChildForms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            panelTop = new Panel();
            Exit = new Button();
            LbCodigo = new Label();
            panel2 = new Panel();
            Lb_Nota = new Label();
            LbRecibido = new Label();
            label4 = new Label();
            label3 = new Label();
            Cantidad = new NumericUpDown();
            LbPendiente = new Label();
            LbSolicitado = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(LbCodigo);
            panel1.Controls.Add(panelTop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 138);
            panel1.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(50, 50, 50);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(878, 56);
            panelTop.TabIndex = 2;
            panelTop.MouseDown += panelTop_MouseDown;
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
            Exit.ForeColor = Color.Black;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(769, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(109, 56);
            Exit.TabIndex = 0;
            Exit.TabStop = false;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // LbCodigo
            // 
            LbCodigo.BackColor = Color.FromArgb(120, 120, 120);
            LbCodigo.Dock = DockStyle.Fill;
            LbCodigo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCodigo.ForeColor = Color.White;
            LbCodigo.Location = new Point(0, 56);
            LbCodigo.Name = "LbCodigo";
            LbCodigo.Size = new Size(878, 82);
            LbCodigo.TabIndex = 1;
            LbCodigo.Text = "222";
            LbCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(Lb_Nota);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 131);
            panel2.TabIndex = 1;
            // 
            // Lb_Nota
            // 
            Lb_Nota.Dock = DockStyle.Fill;
            Lb_Nota.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lb_Nota.ForeColor = Color.White;
            Lb_Nota.Location = new Point(0, 0);
            Lb_Nota.Name = "Lb_Nota";
            Lb_Nota.Size = new Size(878, 131);
            Lb_Nota.TabIndex = 2;
            Lb_Nota.Text = "222";
            Lb_Nota.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbRecibido
            // 
            LbRecibido.AutoSize = true;
            LbRecibido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            LbRecibido.ForeColor = Color.White;
            LbRecibido.Location = new Point(432, 318);
            LbRecibido.Name = "LbRecibido";
            LbRecibido.Size = new Size(111, 24);
            LbRecibido.TabIndex = 16;
            LbRecibido.Text = "RECIBIDO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(314, 318);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 15;
            label4.Text = "RECIBIDO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(456, 398);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 14;
            label3.Text = "PIEZAS";
            // 
            // Cantidad
            // 
            Cantidad.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            Cantidad.Location = new Point(330, 393);
            Cantidad.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(120, 29);
            Cantidad.TabIndex = 13;
            Cantidad.KeyDown += Cantidad_KeyDown;
            // 
            // LbPendiente
            // 
            LbPendiente.AutoSize = true;
            LbPendiente.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            LbPendiente.ForeColor = Color.White;
            LbPendiente.Location = new Point(432, 353);
            LbPendiente.Name = "LbPendiente";
            LbPendiente.Size = new Size(137, 24);
            LbPendiente.TabIndex = 12;
            LbPendiente.Text = "SOLICITADO:";
            // 
            // LbSolicitado
            // 
            LbSolicitado.AutoSize = true;
            LbSolicitado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            LbSolicitado.ForeColor = Color.White;
            LbSolicitado.Location = new Point(432, 282);
            LbSolicitado.Name = "LbSolicitado";
            LbSolicitado.Size = new Size(137, 24);
            LbSolicitado.TabIndex = 11;
            LbSolicitado.Text = "SOLICITADO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(297, 353);
            label2.Name = "label2";
            label2.Size = new Size(123, 24);
            label2.TabIndex = 10;
            label2.Text = "PENDIENTE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 282);
            label1.Name = "label1";
            label1.Size = new Size(126, 24);
            label1.TabIndex = 9;
            label1.Text = "SOLICITADO:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(878, 447);
            Controls.Add(LbRecibido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Cantidad);
            Controls.Add(LbPendiente);
            Controls.Add(LbSolicitado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Cantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LbCodigo;
        private Panel panel2;
        private Label Lb_Nota;
        private Label LbRecibido;
        private Label label4;
        private Label label3;
        private NumericUpDown Cantidad;
        private Label LbPendiente;
        private Label LbSolicitado;
        private Label label2;
        private Label label1;
        private Panel panelTop;
        private Button Exit;
    }
}