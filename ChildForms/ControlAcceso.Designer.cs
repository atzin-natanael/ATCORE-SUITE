namespace ATCORE_SUITE.ChildForms
{
    partial class ControlAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAcceso));
            ForgetPw = new Label();
            Enter = new Button();
            TxtPw = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Cb_Usuario = new ComboBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // ForgetPw
            // 
            ForgetPw.AutoSize = true;
            ForgetPw.Cursor = Cursors.Hand;
            ForgetPw.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgetPw.ForeColor = Color.White;
            ForgetPw.Location = new Point(230, 210);
            ForgetPw.Name = "ForgetPw";
            ForgetPw.Size = new Size(156, 20);
            ForgetPw.TabIndex = 0;
            ForgetPw.Text = "Olvidé mi contraseña";
            ForgetPw.Click += ForgetPw_Click;
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
            Enter.Location = new Point(244, 276);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 3;
            Enter.Text = "Autorizar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            Enter.MouseEnter += Enter_MouseEnter;
            Enter.MouseLeave += Enter_MouseLeave;
            // 
            // TxtPw
            // 
            TxtPw.Font = new Font("Microsoft Sans Serif", 12F);
            TxtPw.Location = new Point(168, 167);
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
            label2.Location = new Point(55, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 167);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 10;
            label1.Text = "Contraseña";
            // 
            // Cb_Usuario
            // 
            Cb_Usuario.Anchor = AnchorStyles.None;
            Cb_Usuario.FlatStyle = FlatStyle.Flat;
            Cb_Usuario.Font = new Font("Microsoft Sans Serif", 12F);
            Cb_Usuario.FormattingEnabled = true;
            Cb_Usuario.Location = new Point(168, 105);
            Cb_Usuario.Name = "Cb_Usuario";
            Cb_Usuario.Size = new Size(295, 28);
            Cb_Usuario.TabIndex = 1;
            Cb_Usuario.KeyPress += Cb_Usuario_KeyPress;
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
            panelTop.TabIndex = 30;
            panelTop.MouseDown += panelTop_MouseDown_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(271, 15);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 0;
            label3.Text = "Autorizar";
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
            Exit.TabIndex = 0;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click_1;
            // 
            // ControlAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(606, 338);
            Controls.Add(panelTop);
            Controls.Add(Cb_Usuario);
            Controls.Add(ForgetPw);
            Controls.Add(Enter);
            Controls.Add(TxtPw);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ControlAcceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ControlAcceso";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ForgetPw;
        private Button Enter;
        private TextBox TxtPw;
        private Label label2;
        private Label label1;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        public ComboBox Cb_Usuario;
    }
}