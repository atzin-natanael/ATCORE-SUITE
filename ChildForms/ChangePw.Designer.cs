namespace PedidoXperto.ChildForms
{
    partial class ChangePw
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
            Lb_Title = new Label();
            Exit = new Button();
            Enter = new Button();
            TxtPw = new TextBox();
            Cb_Usuario = new ComboBox();
            LbUser = new Label();
            LbPw = new Label();
            TxtPw2 = new TextBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(Lb_Title);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 30);
            panelTop.TabIndex = 15;
            // 
            // Lb_Title
            // 
            Lb_Title.AutoSize = true;
            Lb_Title.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb_Title.ForeColor = Color.White;
            Lb_Title.Location = new Point(146, 0);
            Lb_Title.Name = "Lb_Title";
            Lb_Title.Size = new Size(294, 30);
            Lb_Title.TabIndex = 0;
            Lb_Title.Text = "CAMBIAR CONTRASENA";
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
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = SystemColors.ActiveBorder;
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(233, 264);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 13;
            Enter.Text = "Ingresar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // TxtPw
            // 
            TxtPw.Location = new Point(170, 190);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 32);
            TxtPw.TabIndex = 12;
            TxtPw.UseSystemPasswordChar = true;
            // 
            // Cb_Usuario
            // 
            Cb_Usuario.FormattingEnabled = true;
            Cb_Usuario.Location = new Point(170, 94);
            Cb_Usuario.Name = "Cb_Usuario";
            Cb_Usuario.Size = new Size(295, 31);
            Cb_Usuario.TabIndex = 11;
            // 
            // LbUser
            // 
            LbUser.FlatStyle = FlatStyle.Flat;
            LbUser.ForeColor = Color.White;
            LbUser.Location = new Point(12, 81);
            LbUser.Name = "LbUser";
            LbUser.Size = new Size(152, 54);
            LbUser.TabIndex = 9;
            LbUser.Text = "Usuario Administrador";
            LbUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbPw
            // 
            LbPw.AutoSize = true;
            LbPw.ForeColor = Color.White;
            LbPw.Location = new Point(26, 193);
            LbPw.Name = "LbPw";
            LbPw.Size = new Size(125, 23);
            LbPw.TabIndex = 10;
            LbPw.Text = "Contraseña";
            // 
            // TxtPw2
            // 
            TxtPw2.Location = new Point(170, 93);
            TxtPw2.Name = "TxtPw2";
            TxtPw2.Size = new Size(295, 32);
            TxtPw2.TabIndex = 16;
            TxtPw2.UseSystemPasswordChar = true;
            TxtPw2.Visible = false;
            // 
            // ChangePw
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(TxtPw2);
            Controls.Add(panelTop);
            Controls.Add(Enter);
            Controls.Add(TxtPw);
            Controls.Add(Cb_Usuario);
            Controls.Add(LbUser);
            Controls.Add(LbPw);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangePw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePw";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Button Exit;
        private Label Lb_Title;
        private Button Enter;
        private TextBox TxtPw;
        private ComboBox Cb_Usuario;
        private Label LbUser;
        private Label LbPw;
        private TextBox TxtPw2;
    }
}