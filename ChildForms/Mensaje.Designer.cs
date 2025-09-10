namespace ATCORE_SUITE.ChildForms
{
    partial class Mensaje
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
            LblTitulo = new Label();
            Exit = new Button();
            Btn_Aceptar = new Button();
            Texto = new RichTextBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(50, 50, 50);
            panelTop.Controls.Add(LblTitulo);
            panelTop.Controls.Add(Exit);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(444, 63);
            panelTop.TabIndex = 15;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // LblTitulo
            // 
            LblTitulo.Anchor = AnchorStyles.None;
            LblTitulo.FlatStyle = FlatStyle.Flat;
            LblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.ForeColor = Color.White;
            LblTitulo.Location = new Point(48, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(349, 42);
            LblTitulo.TabIndex = 5;
            LblTitulo.Text = "label4";
            LblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            LblTitulo.MouseDown += LblTitulo_MouseDown;
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
            Exit.Location = new Point(664, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(64, 27);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            // 
            // Btn_Aceptar
            // 
            Btn_Aceptar.Anchor = AnchorStyles.Top;
            Btn_Aceptar.BackColor = Color.FromArgb(50, 50, 50);
            Btn_Aceptar.Cursor = Cursors.Hand;
            Btn_Aceptar.FlatAppearance.BorderSize = 0;
            Btn_Aceptar.FlatAppearance.MouseDownBackColor = Color.Gray;
            Btn_Aceptar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            Btn_Aceptar.FlatStyle = FlatStyle.Flat;
            Btn_Aceptar.ForeColor = Color.White;
            Btn_Aceptar.Location = new Point(155, 189);
            Btn_Aceptar.Name = "Btn_Aceptar";
            Btn_Aceptar.Size = new Size(141, 50);
            Btn_Aceptar.TabIndex = 13;
            Btn_Aceptar.Text = "Aceptar";
            Btn_Aceptar.UseVisualStyleBackColor = false;
            Btn_Aceptar.Click += Btn_Aceptar_Click;
            Btn_Aceptar.MouseEnter += Btn_Aceptar_MouseEnter;
            Btn_Aceptar.MouseLeave += Btn_Aceptar_MouseLeave;
            // 
            // Texto
            // 
            Texto.Anchor = AnchorStyles.None;
            Texto.BackColor = Color.FromArgb(120, 120, 120);
            Texto.BorderStyle = BorderStyle.None;
            Texto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Texto.ForeColor = Color.White;
            Texto.Location = new Point(0, 88);
            Texto.Name = "Texto";
            Texto.Size = new Size(444, 95);
            Texto.TabIndex = 16;
            Texto.Text = "";
            // 
            // Mensaje
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 120, 120);
            ClientSize = new Size(444, 251);
            Controls.Add(Texto);
            Controls.Add(panelTop);
            Controls.Add(Btn_Aceptar);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Mensaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mensaje";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox Txt_Usuario;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        private Label ForgetPw;
        private RichTextBox richTextBox1;
        private TextBox TxtPw;
        private Label label2;
        private Label label1;
        public Label LblTitulo;
        public Button Btn_Aceptar;
        public RichTextBox Texto;
    }
}