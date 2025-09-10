namespace ATCORE_SUITE.ChildForms
{
    partial class CambiarDerechosRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarDerechosRol));
            Enter = new Button();
            label2 = new Label();
            Txt_Rol = new TextBox();
            CheckList = new CheckedListBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = Color.FromArgb(50, 50, 50);
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enter.ForeColor = Color.White;
            Enter.Location = new Point(230, 292);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 42);
            Enter.TabIndex = 13;
            Enter.Text = "Cambiar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            Enter.MouseEnter += Enter_MouseEnter;
            Enter.MouseLeave += Enter_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 105);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 9;
            label2.Text = "Rol";
            // 
            // Txt_Rol
            // 
            Txt_Rol.BorderStyle = BorderStyle.FixedSingle;
            Txt_Rol.Enabled = false;
            Txt_Rol.Font = new Font("Microsoft Sans Serif", 12F);
            Txt_Rol.Location = new Point(168, 105);
            Txt_Rol.Name = "Txt_Rol";
            Txt_Rol.Size = new Size(295, 26);
            Txt_Rol.TabIndex = 11;
            // 
            // CheckList
            // 
            CheckList.BackColor = Color.FromArgb(120, 120, 120);
            CheckList.BorderStyle = BorderStyle.None;
            CheckList.CheckOnClick = true;
            CheckList.Cursor = Cursors.Hand;
            CheckList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckList.ForeColor = Color.White;
            CheckList.FormattingEnabled = true;
            CheckList.Items.AddRange(new object[] { "Enviar Ticket", "Validar Pedido", "Inventario", "Administrador de Usuarios", "Administrador de Roles" });
            CheckList.Location = new Point(168, 158);
            CheckList.Name = "CheckList";
            CheckList.Size = new Size(295, 105);
            CheckList.TabIndex = 16;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(50, 50, 50);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 55);
            panelTop.TabIndex = 23;
            panelTop.MouseDown += panelTop_MouseDown_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(200, 15);
            label3.Name = "label3";
            label3.Size = new Size(221, 24);
            label3.TabIndex = 0;
            label3.Text = "CAMBIAR DERECHOS";
            label3.MouseDown += label3_MouseDown_1;
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
            Exit.Location = new Point(542, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 55);
            Exit.TabIndex = 6;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click_1;
            // 
            // CambiarDerechosRol
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(606, 363);
            Controls.Add(panelTop);
            Controls.Add(CheckList);
            Controls.Add(Txt_Rol);
            Controls.Add(Enter);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "CambiarDerechosRol";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "CambiarRol";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Enter;
        private Label label2;
        public CheckedListBox CheckList;
        public TextBox Txt_Rol;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
    }
}