namespace ATCORE_SUITE.ChildForms
{
    partial class ChangeUserRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserRol));
            Txt_Usuario = new TextBox();
            Enter = new Button();
            label2 = new Label();
            label1 = new Label();
            Cb_Rol = new ComboBox();
            panelTop = new Panel();
            label3 = new Label();
            Exit = new Button();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.CharacterCasing = CharacterCasing.Upper;
            Txt_Usuario.Enabled = false;
            Txt_Usuario.Font = new Font("Microsoft Sans Serif", 12F);
            Txt_Usuario.Location = new Point(168, 105);
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
            Enter.Font = new Font("Microsoft Sans Serif", 12F);
            Enter.ForeColor = Color.White;
            Enter.Location = new Point(244, 231);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 50);
            Enter.TabIndex = 2;
            Enter.Text = "Modificar";
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
            label2.Location = new Point(55, 108);
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
            label1.Location = new Point(55, 167);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 10;
            label1.Text = "Rol";
            // 
            // Cb_Rol
            // 
            Cb_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            Cb_Rol.Font = new Font("Microsoft Sans Serif", 12F);
            Cb_Rol.FormattingEnabled = true;
            Cb_Rol.Location = new Point(168, 159);
            Cb_Rol.Name = "Cb_Rol";
            Cb_Rol.Size = new Size(295, 28);
            Cb_Rol.TabIndex = 1;
            Cb_Rol.KeyDown += Cb_Rol_KeyDown;
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
            panelTop.TabIndex = 29;
            panelTop.MouseDown += panelTop_MouseDown_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(244, 15);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 0;
            label3.Text = "Cambiar Rol";
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
            // ChangeUserRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(606, 338);
            Controls.Add(panelTop);
            Controls.Add(Cb_Rol);
            Controls.Add(Txt_Usuario);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeUserRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeRol";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Usuario;
        private Button Enter;
        private Label label2;
        private Label label1;
        private ComboBox Cb_Rol;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
    }
}