namespace PedidoXperto.ChildForms
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            TxtPw = new TextBox();
            Enter = new Button();
            Exit = new Button();
            ForgetPw = new Label();
            panelTop = new Panel();
            label3 = new Label();
            Txt_Usuario = new TextBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 153);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 91);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // TxtPw
            // 
            TxtPw.Location = new Point(168, 153);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 27);
            TxtPw.TabIndex = 2;
            TxtPw.UseSystemPasswordChar = true;
            TxtPw.KeyDown += TxtPw_KeyDown;
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = SystemColors.ActiveBorder;
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatAppearance.MouseDownBackColor = Color.Gray;
            Enter.FlatAppearance.MouseOverBackColor = Color.Gray;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(233, 260);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 3;
            Enter.Text = "Ingresar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.BackColor = SystemColors.ActiveBorder;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Gray;
            Exit.FlatAppearance.MouseOverBackColor = Color.Gray;
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
            // ForgetPw
            // 
            ForgetPw.AutoSize = true;
            ForgetPw.Cursor = Cursors.Hand;
            ForgetPw.ForeColor = Color.White;
            ForgetPw.Location = new Point(215, 193);
            ForgetPw.Name = "ForgetPw";
            ForgetPw.Size = new Size(177, 21);
            ForgetPw.TabIndex = 5;
            ForgetPw.Text = "Olvidé mi contraseña";
            ForgetPw.Click += ForgetPw_Click;
            ForgetPw.MouseEnter += ForgetPw_MouseEnter;
            ForgetPw.MouseLeave += ForgetPw_MouseLeave;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 63);
            panelTop.TabIndex = 8;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(185, 19);
            label3.Name = "label3";
            label3.Size = new Size(236, 24);
            label3.TabIndex = 0;
            label3.Text = "LOGIN PEDIDOXPERTO";
            label3.MouseDown += label3_MouseDown;
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Location = new Point(168, 91);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(295, 27);
            Txt_Usuario.TabIndex = 1;
            Txt_Usuario.KeyDown += Txt_Usuario_KeyDown_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(Txt_Usuario);
            Controls.Add(panelTop);
            Controls.Add(ForgetPw);
            Controls.Add(Enter);
            Controls.Add(TxtPw);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtPw;
        private Button Enter;
        private Button Exit;
        private Label ForgetPw;
        private Panel panelTop;
        private Label label3;
        private TextBox Txt_Usuario;
    }
}