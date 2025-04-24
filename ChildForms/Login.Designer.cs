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
            Cb_Usuario = new ComboBox();
            TxtPw = new TextBox();
            Enter = new Button();
            button1 = new Button();
            ForgetPw = new Label();
            panelTop = new Panel();
            label3 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 153);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 88);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // Cb_Usuario
            // 
            Cb_Usuario.FormattingEnabled = true;
            Cb_Usuario.Location = new Point(209, 88);
            Cb_Usuario.Name = "Cb_Usuario";
            Cb_Usuario.Size = new Size(295, 29);
            Cb_Usuario.TabIndex = 2;
            // 
            // TxtPw
            // 
            TxtPw.Location = new Point(209, 153);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 27);
            TxtPw.TabIndex = 3;
            TxtPw.UseSystemPasswordChar = true;
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = SystemColors.ActiveBorder;
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(237, 265);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 4;
            Enter.Text = "Ingresar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Exit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(551, 0);
            button1.Name = "button1";
            button1.Size = new Size(55, 27);
            button1.TabIndex = 6;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ForgetPw
            // 
            ForgetPw.AutoSize = true;
            ForgetPw.ForeColor = Color.White;
            ForgetPw.Location = new Point(223, 209);
            ForgetPw.Name = "ForgetPw";
            ForgetPw.Size = new Size(177, 21);
            ForgetPw.TabIndex = 7;
            ForgetPw.Text = "Olvidé mi contraseña";
            ForgetPw.Click += ForgetPw_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(button1);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 30);
            panelTop.TabIndex = 8;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(209, 5);
            label3.Name = "label3";
            label3.Size = new Size(218, 22);
            label3.TabIndex = 9;
            label3.Text = "LOGIN PEDIDOXPERTO";
            label3.MouseDown += label3_MouseDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(panelTop);
            Controls.Add(ForgetPw);
            Controls.Add(Enter);
            Controls.Add(TxtPw);
            Controls.Add(Cb_Usuario);
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
        private ComboBox Cb_Usuario;
        private TextBox TxtPw;
        private Button Enter;
        private Button button1;
        private Label ForgetPw;
        private Panel panelTop;
        private Label label3;
    }
}