namespace ATCORE_SUITE.Surtido
{
    partial class FormExportarIsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportarIsi));
            panel1 = new Panel();
            Exit = new Button();
            Titulo = new Label();
            Txt_Pedido = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(Titulo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 54);
            panel1.TabIndex = 7;
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
            Exit.ForeColor = Color.White;
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(1119, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(61, 54);
            Exit.TabIndex = 6;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.BackColor = Color.FromArgb(50, 50, 50);
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(422, 1);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(411, 53);
            Titulo.TabIndex = 5;
            Titulo.Text = "EXPORTAR A ISI OFFICE";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Pedido
            // 
            Txt_Pedido.Anchor = AnchorStyles.None;
            Txt_Pedido.BorderStyle = BorderStyle.FixedSingle;
            Txt_Pedido.CharacterCasing = CharacterCasing.Upper;
            Txt_Pedido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Pedido.Location = new Point(534, 140);
            Txt_Pedido.MaxLength = 9;
            Txt_Pedido.Name = "Txt_Pedido";
            Txt_Pedido.Size = new Size(246, 29);
            Txt_Pedido.TabIndex = 9;
            Txt_Pedido.KeyDown += Txt_Pedido_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(444, 140);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 10;
            label1.Text = "Folio:";
            // 
            // FormExportarIsi
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Beige;
            ClientSize = new Size(1180, 701);
            Controls.Add(Txt_Pedido);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormExportarIsi";
            Text = "FormExportarIsi";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private Label Titulo;
        public TextBox Txt_Pedido;
        private Label label1;
    }
}