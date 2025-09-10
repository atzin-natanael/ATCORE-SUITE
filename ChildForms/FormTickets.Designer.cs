namespace ATCORE_SUITE.ChildForms
{
    partial class FormTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTickets));
            Titulo = new Label();
            panel1 = new Panel();
            Exit = new Button();
            BtnImprimirIsla = new Button();
            Txt_Pedido = new TextBox();
            label1 = new Label();
            printPreviewControl1 = new PrintPreviewControl();
            printPreviewControl2 = new PrintPreviewControl();
            BtnImprimirArte = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            Lb_articulosIsla = new Label();
            Lb_articulosArte = new Label();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.BackColor = Color.FromArgb(50, 50, 50);
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(398, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(411, 53);
            Titulo.TabIndex = 5;
            Titulo.Text = "ENVIAR TICKETS";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.TabIndex = 6;
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
            // BtnImprimirIsla
            // 
            BtnImprimirIsla.Anchor = AnchorStyles.None;
            BtnImprimirIsla.BackColor = Color.FromArgb(50, 50, 50);
            BtnImprimirIsla.Cursor = Cursors.Hand;
            BtnImprimirIsla.FlatAppearance.BorderSize = 0;
            BtnImprimirIsla.FlatAppearance.MouseOverBackColor = Color.White;
            BtnImprimirIsla.FlatStyle = FlatStyle.Flat;
            BtnImprimirIsla.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnImprimirIsla.ForeColor = Color.White;
            BtnImprimirIsla.Location = new Point(219, 570);
            BtnImprimirIsla.Name = "BtnImprimirIsla";
            BtnImprimirIsla.Size = new Size(184, 58);
            BtnImprimirIsla.TabIndex = 10;
            BtnImprimirIsla.Text = "Imprimir";
            BtnImprimirIsla.UseVisualStyleBackColor = false;
            BtnImprimirIsla.Click += BtnImprimirIsla_Click;
            BtnImprimirIsla.MouseEnter += BtnImprimirIsla_MouseEnter;
            BtnImprimirIsla.MouseLeave += BtnImprimirIsla_MouseLeave;
            // 
            // Txt_Pedido
            // 
            Txt_Pedido.Anchor = AnchorStyles.None;
            Txt_Pedido.BorderStyle = BorderStyle.FixedSingle;
            Txt_Pedido.CharacterCasing = CharacterCasing.Upper;
            Txt_Pedido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_Pedido.Location = new Point(488, 131);
            Txt_Pedido.MaxLength = 9;
            Txt_Pedido.Name = "Txt_Pedido";
            Txt_Pedido.Size = new Size(246, 29);
            Txt_Pedido.TabIndex = 7;
            Txt_Pedido.KeyDown += Txt_Pedido_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 131);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 8;
            label1.Text = "Folio:";
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Anchor = AnchorStyles.None;
            printPreviewControl1.AutoZoom = false;
            printPreviewControl1.BackColor = Color.Beige;
            printPreviewControl1.ForeColor = Color.Beige;
            printPreviewControl1.Location = new Point(137, 196);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(336, 355);
            printPreviewControl1.TabIndex = 11;
            printPreviewControl1.UseAntiAlias = true;
            printPreviewControl1.Zoom = 1.1D;
            // 
            // printPreviewControl2
            // 
            printPreviewControl2.Anchor = AnchorStyles.None;
            printPreviewControl2.AutoZoom = false;
            printPreviewControl2.BackColor = Color.Beige;
            printPreviewControl2.ForeColor = Color.Beige;
            printPreviewControl2.Location = new Point(697, 196);
            printPreviewControl2.Name = "printPreviewControl2";
            printPreviewControl2.Size = new Size(336, 355);
            printPreviewControl2.TabIndex = 12;
            printPreviewControl2.Zoom = 1.1D;
            // 
            // BtnImprimirArte
            // 
            BtnImprimirArte.Anchor = AnchorStyles.None;
            BtnImprimirArte.BackColor = Color.FromArgb(50, 50, 50);
            BtnImprimirArte.Cursor = Cursors.Hand;
            BtnImprimirArte.FlatAppearance.BorderSize = 0;
            BtnImprimirArte.FlatAppearance.MouseOverBackColor = Color.White;
            BtnImprimirArte.FlatStyle = FlatStyle.Flat;
            BtnImprimirArte.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnImprimirArte.ForeColor = Color.White;
            BtnImprimirArte.Location = new Point(774, 570);
            BtnImprimirArte.Name = "BtnImprimirArte";
            BtnImprimirArte.Size = new Size(184, 58);
            BtnImprimirArte.TabIndex = 13;
            BtnImprimirArte.Text = "Imprimir";
            BtnImprimirArte.UseVisualStyleBackColor = false;
            BtnImprimirArte.Click += BtnImprimirArte_Click;
            BtnImprimirArte.MouseEnter += BtnImprimirArte_MouseEnter;
            BtnImprimirArte.MouseLeave += BtnImprimirArte_MouseLeave;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Lb_articulosIsla
            // 
            Lb_articulosIsla.Anchor = AnchorStyles.None;
            Lb_articulosIsla.AutoSize = true;
            Lb_articulosIsla.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb_articulosIsla.Location = new Point(16, 116);
            Lb_articulosIsla.Name = "Lb_articulosIsla";
            Lb_articulosIsla.Size = new Size(0, 24);
            Lb_articulosIsla.TabIndex = 14;
            // 
            // Lb_articulosArte
            // 
            Lb_articulosArte.Anchor = AnchorStyles.None;
            Lb_articulosArte.AutoSize = true;
            Lb_articulosArte.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lb_articulosArte.Location = new Point(734, 116);
            Lb_articulosArte.Name = "Lb_articulosArte";
            Lb_articulosArte.Size = new Size(0, 24);
            Lb_articulosArte.TabIndex = 15;
            // 
            // printDocument2
            // 
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // FormTickets
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Beige;
            ClientSize = new Size(1180, 701);
            Controls.Add(Lb_articulosArte);
            Controls.Add(Lb_articulosIsla);
            Controls.Add(BtnImprimirArte);
            Controls.Add(printPreviewControl2);
            Controls.Add(printPreviewControl1);
            Controls.Add(BtnImprimirIsla);
            Controls.Add(Txt_Pedido);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormTickets";
            Text = "Tickets";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
    private Panel panel1;
    private Button Exit;
    private Button BtnImprimirIsla;
    private Label label1;
    private PrintPreviewControl printPreviewControl1;
    private PrintPreviewControl printPreviewControl2;
    private Button BtnImprimirArte;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private Label Lb_articulosIsla;
        private Label Lb_articulosArte;
        private System.Drawing.Printing.PrintDocument printDocument2;
        public TextBox Txt_Pedido;
    }
}