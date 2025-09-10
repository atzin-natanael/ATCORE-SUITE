namespace ATCORE_SUITE.ChildForms
{
    partial class ChangePasswordMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordMenu));
            TxtPw = new TextBox();
            Txt_Usuario = new TextBox();
            Enter = new Button();
            label2 = new Label();
            label1 = new Label();
            TxtPw2 = new TextBox();
            label4 = new Label();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // TxtPw
            // 
            TxtPw.CharacterCasing = CharacterCasing.Upper;
            TxtPw.Font = new Font("Microsoft Sans Serif", 12F);
            TxtPw.Location = new Point(198, 146);
            TxtPw.Name = "TxtPw";
            TxtPw.Size = new Size(295, 26);
            TxtPw.TabIndex = 1;
            TxtPw.UseSystemPasswordChar = true;
            TxtPw.KeyDown += TxtPw_KeyDown;
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Enabled = false;
            Txt_Usuario.Font = new Font("Microsoft Sans Serif", 12F);
            Txt_Usuario.Location = new Point(198, 90);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(295, 26);
            Txt_Usuario.TabIndex = 0;
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
            Enter.Location = new Point(233, 276);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 3;
            Enter.Text = "Modificar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 23;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 149);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 24;
            label1.Text = "Contraseña";
            // 
            // TxtPw2
            // 
            TxtPw2.CharacterCasing = CharacterCasing.Upper;
            TxtPw2.Font = new Font("Microsoft Sans Serif", 12F);
            TxtPw2.Location = new Point(198, 212);
            TxtPw2.Name = "TxtPw2";
            TxtPw2.Size = new Size(295, 26);
            TxtPw2.TabIndex = 2;
            TxtPw2.UseSystemPasswordChar = true;
            TxtPw2.KeyDown += TxtPw2_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 215);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 26;
            label4.Text = "Confirmar Contraseña";
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
            panelTop.TabIndex = 27;
            panelTop.MouseDown += panelTop_MouseDown_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(198, 15);
            label3.Name = "label3";
            label3.Size = new Size(199, 24);
            label3.TabIndex = 0;
            label3.Text = "Cambiar Contraseña";
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
            // ChangePasswordMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(606, 338);
            Controls.Add(panelTop);
            Controls.Add(TxtPw2);
            Controls.Add(label4);
            Controls.Add(TxtPw);
            Controls.Add(Txt_Usuario);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordMenu";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPw;
        private TextBox Txt_Usuario;
        private Button Enter;
        private Label label2;
        private Label label1;
        private TextBox TxtPw2;
        private Label label4;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
    }
}