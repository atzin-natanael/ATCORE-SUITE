namespace ATCORE_SUITE.ChildForms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            Txt_Usuario = new TextBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            Enter = new Button();
            TxtPw = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Rol = new Label();
            Cb_Rol = new ComboBox();
            TxtPw2 = new TextBox();
            label4 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.BorderStyle = BorderStyle.FixedSingle;
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Font = new Font("Microsoft Sans Serif", 12F);
            Txt_Usuario.ForeColor = Color.Black;
            Txt_Usuario.Location = new Point(163, 51);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(295, 26);
            Txt_Usuario.TabIndex = 1;
            Txt_Usuario.KeyDown += Txt_Usuario_KeyDown;
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
            panelTop.Size = new Size(606, 44);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(225, 10);
            label3.Name = "label3";
            label3.Size = new Size(170, 24);
            label3.TabIndex = 0;
            label3.Text = "Registrar Usuario";
            label3.MouseDown += label3_MouseDown;
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
            Exit.Size = new Size(64, 44);
            Exit.TabIndex = 6;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = Color.FromArgb(50, 50, 50);
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter.ForeColor = Color.White;
            Enter.Location = new Point(236, 246);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 5;
            Enter.Text = "Ingresar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            Enter.MouseEnter += Enter_MouseEnter;
            Enter.MouseLeave += Enter_MouseLeave;
            // 
            // TxtPw
            // 
            TxtPw.BorderStyle = BorderStyle.FixedSingle;
            TxtPw.Font = new Font("Microsoft Sans Serif", 12F);
            TxtPw.Location = new Point(163, 98);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 26);
            TxtPw.TabIndex = 2;
            TxtPw.UseSystemPasswordChar = true;
            TxtPw.KeyDown += TxtPw_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 54);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 101);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Font = new Font("Microsoft Sans Serif", 12F);
            Rol.ForeColor = Color.White;
            Rol.Location = new Point(51, 204);
            Rol.Name = "Rol";
            Rol.Size = new Size(33, 20);
            Rol.TabIndex = 0;
            Rol.Text = "Rol";
            // 
            // Cb_Rol
            // 
            Cb_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Rol.FlatStyle = FlatStyle.Flat;
            Cb_Rol.Font = new Font("Microsoft Sans Serif", 12F);
            Cb_Rol.FormattingEnabled = true;
            Cb_Rol.Location = new Point(163, 196);
            Cb_Rol.Name = "Cb_Rol";
            Cb_Rol.Size = new Size(295, 28);
            Cb_Rol.TabIndex = 4;
            Cb_Rol.KeyDown += Cb_Rol_KeyDown;
            // 
            // TxtPw2
            // 
            TxtPw2.BorderStyle = BorderStyle.FixedSingle;
            TxtPw2.Font = new Font("Microsoft Sans Serif", 12F);
            TxtPw2.Location = new Point(163, 148);
            TxtPw2.Name = "TxtPw2";
            TxtPw2.Size = new Size(295, 26);
            TxtPw2.TabIndex = 3;
            TxtPw2.UseSystemPasswordChar = true;
            TxtPw2.KeyDown += TxtPw2_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 151);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Confirmar";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(606, 308);
            Controls.Add(TxtPw2);
            Controls.Add(label4);
            Controls.Add(Cb_Rol);
            Controls.Add(Rol);
            Controls.Add(Txt_Usuario);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(TxtPw);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Button Enter;
        private TextBox TxtPw;
        private Label label2;
        private Label label1;
        private Label Rol;
        private ComboBox Cb_Rol;
        private TextBox TxtPw2;
        private Label label4;
        public TextBox Txt_Usuario;
    }
}