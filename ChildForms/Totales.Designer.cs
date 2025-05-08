namespace PedidoXperto.ChildForms
{
    partial class Totales
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
            Total = new Label();
            panelTop = new Panel();
            label4 = new Label();
            label3 = new Label();
            Exit = new Button();
            label7 = new Label();
            Iva = new Label();
            Enter = new Button();
            label2 = new Label();
            label1 = new Label();
            Descuento = new Label();
            label6 = new Label();
            SubTotal = new Label();
            label9 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // Total
            // 
            Total.Anchor = AnchorStyles.None;
            Total.FlatStyle = FlatStyle.Flat;
            Total.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            Total.ForeColor = Color.White;
            Total.Location = new Point(343, 242);
            Total.Name = "Total";
            Total.Size = new Size(99, 25);
            Total.TabIndex = 23;
            Total.Text = "0";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(Exit);
            panelTop.Controls.Add(label7);
            panelTop.Cursor = Cursors.Hand;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(606, 88);
            panelTop.TabIndex = 22;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(332, 108);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 27;
            label4.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(272, 9);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 0;
            label3.Text = "TOTALES";
            label3.MouseDown += label3_MouseDown;
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
            Exit.Location = new Point(526, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(80, 32);
            Exit.TabIndex = 4;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(194, 108);
            label7.Name = "label7";
            label7.Size = new Size(89, 31);
            label7.TabIndex = 25;
            label7.Text = "TIENDA";
            // 
            // Iva
            // 
            Iva.Anchor = AnchorStyles.None;
            Iva.Cursor = Cursors.Hand;
            Iva.FlatStyle = FlatStyle.Flat;
            Iva.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            Iva.ForeColor = Color.White;
            Iva.Location = new Point(343, 200);
            Iva.Name = "Iva";
            Iva.Size = new Size(99, 31);
            Iva.TabIndex = 21;
            Iva.Text = "0";
            // 
            // Enter
            // 
            Enter.Anchor = AnchorStyles.Top;
            Enter.BackColor = SystemColors.ActiveBorder;
            Enter.Cursor = Cursors.Hand;
            Enter.FlatAppearance.BorderSize = 0;
            Enter.FlatStyle = FlatStyle.Flat;
            Enter.ForeColor = Color.Black;
            Enter.Location = new Point(241, 288);
            Enter.Name = "Enter";
            Enter.Size = new Size(141, 38);
            Enter.TabIndex = 20;
            Enter.Text = "Aceptar";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 200);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 18;
            label2.Text = "IVA";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(192, 242);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 19;
            label1.Text = "TOTAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Descuento
            // 
            Descuento.Anchor = AnchorStyles.None;
            Descuento.Cursor = Cursors.Hand;
            Descuento.FlatStyle = FlatStyle.Flat;
            Descuento.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            Descuento.ForeColor = Color.White;
            Descuento.Location = new Point(343, 158);
            Descuento.Name = "Descuento";
            Descuento.Size = new Size(99, 31);
            Descuento.TabIndex = 26;
            Descuento.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(169, 158);
            label6.Name = "label6";
            label6.Size = new Size(135, 31);
            label6.TabIndex = 24;
            label6.Text = "DESCUENTO";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubTotal
            // 
            SubTotal.Anchor = AnchorStyles.None;
            SubTotal.Cursor = Cursors.Hand;
            SubTotal.FlatStyle = FlatStyle.Flat;
            SubTotal.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            SubTotal.ForeColor = Color.White;
            SubTotal.Location = new Point(343, 109);
            SubTotal.Name = "SubTotal";
            SubTotal.Size = new Size(99, 31);
            SubTotal.TabIndex = 28;
            SubTotal.Text = "0";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(178, 109);
            label9.Name = "label9";
            label9.Size = new Size(116, 31);
            label9.TabIndex = 27;
            label9.Text = "SUBTOTAL";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Totales
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(606, 338);
            Controls.Add(SubTotal);
            Controls.Add(label9);
            Controls.Add(Total);
            Controls.Add(panelTop);
            Controls.Add(Descuento);
            Controls.Add(label6);
            Controls.Add(Iva);
            Controls.Add(Enter);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Totales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Totales";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label Total;
        private Panel panelTop;
        private Label label3;
        private Button Exit;
        public Label Iva;
        private Button Enter;
        private Label label2;
        private Label label1;
        public Label label4;
        private Label label7;
        public Label Descuento;
        private Label label6;
        public Label SubTotal;
        private Label label9;
    }
}