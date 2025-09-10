namespace ATCORE_SUITE.ChildForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            TxtPw = new TextBox();
            Enter = new Button();
            Exit = new Button();
            ForgetPw = new Label();
            panelTop = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            Cb_Usuario = new ComboBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            Enter.BackColor = Color.FromArgb(50, 50, 50);
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.White;
            Enter.Location = new Point(215, 248);
            Enter.Name = "Enter";
            Enter.Size = new Size(177, 60);
            Enter.TabIndex = 3;
            Enter.Text = "Ingresar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            Enter.MouseEnter += Enter_MouseEnter;
            Enter.MouseLeave += Enter_MouseLeave;
            // 
            // Exit
            // 
            Exit.BackColor = Color.FromArgb(50, 50, 50);
            Exit.Cursor = Cursors.Hand;
            Exit.Dock = DockStyle.Right;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Gray;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(531, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 63);
            Exit.TabIndex = 4;
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
            panelTop.BackColor = Color.FromArgb(50, 50, 50);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(pictureBox1);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(145, 19);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 6;
            label4.Text = "V1.3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(273, 19);
            label3.Name = "label3";
            label3.Size = new Size(77, 24);
            label3.TabIndex = 0;
            label3.Text = "LOGIN";
            label3.MouseDown += label3_MouseDown;
            // 
            // Cb_Usuario
            // 
            Cb_Usuario.Anchor = AnchorStyles.None;
            Cb_Usuario.FlatStyle = FlatStyle.Flat;
            Cb_Usuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cb_Usuario.FormattingEnabled = true;
            Cb_Usuario.Location = new Point(168, 91);
            Cb_Usuario.Name = "Cb_Usuario";
            Cb_Usuario.Size = new Size(295, 27);
            Cb_Usuario.TabIndex = 17;
            Cb_Usuario.KeyDown += Cb_Usuario_KeyDown;
            Cb_Usuario.KeyPress += Cb_Usuario_KeyPress;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(606, 338);
            Controls.Add(Cb_Usuario);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private ComboBox Cb_Usuario;
        private Label label4;
    }
}