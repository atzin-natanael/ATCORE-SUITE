namespace PedidoXperto.ChildForms
{
    partial class FormCrearPedido
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
            Titulo = new Label();
            Exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            button2 = new Button();
            lblNombreCliente = new Label();
            txtBox_clienteId = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            TxtPedido = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Dock = DockStyle.Left;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1236, 50);
            Titulo.TabIndex = 3;
            Titulo.Text = "CREAR PEDIDO";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.ActiveCaptionText;
            Exit.Cursor = Cursors.Hand;
            Exit.Dock = DockStyle.Right;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(1242, 0);
            Exit.Name = "Exit";
            Exit.Size = new Size(141, 50);
            Exit.TabIndex = 2;
            Exit.Text = "Salir";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1383, 822);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(Titulo);
            panel1.Controls.Add(Exit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 50);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 50);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1383, 772);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lblNombreCliente);
            panel2.Controls.Add(txtBox_clienteId);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(TxtPedido);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1106, 772);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(906, 725);
            button2.Name = "button2";
            button2.Size = new Size(186, 35);
            button2.TabIndex = 23;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.Anchor = AnchorStyles.Top;
            lblNombreCliente.FlatStyle = FlatStyle.Flat;
            lblNombreCliente.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblNombreCliente.Location = new Point(542, 16);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(550, 23);
            lblNombreCliente.TabIndex = 22;
            lblNombreCliente.Text = "NombreDelCliente";
            lblNombreCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBox_clienteId
            // 
            txtBox_clienteId.Anchor = AnchorStyles.Top;
            txtBox_clienteId.Location = new Point(179, 14);
            txtBox_clienteId.Name = "txtBox_clienteId";
            txtBox_clienteId.Size = new Size(348, 27);
            txtBox_clienteId.TabIndex = 21;
            txtBox_clienteId.TextChanged += txtBox_clienteId_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 20;
            label3.Text = "Cliente:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(444, 133);
            label1.Name = "label1";
            label1.Size = new Size(215, 23);
            label1.TabIndex = 19;
            label1.Text = "Articulos en el Pedido:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1081, 441);
            dataGridView1.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(533, 54);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(95, 27);
            numericUpDown1.TabIndex = 17;
            // 
            // TxtPedido
            // 
            TxtPedido.Anchor = AnchorStyles.Top;
            TxtPedido.Location = new Point(178, 54);
            TxtPedido.Name = "TxtPedido";
            TxtPedido.Size = new Size(348, 27);
            TxtPedido.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label4.Location = new Point(11, 56);
            label4.Name = "label4";
            label4.Size = new Size(161, 23);
            label4.TabIndex = 11;
            label4.Text = "Codigo Articulo:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(634, 52);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dataGridView2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1106, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 772);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label2.Location = new Point(45, 133);
            label2.Name = "label2";
            label2.Size = new Size(189, 23);
            label2.TabIndex = 20;
            label2.Text = "Recomendaciones:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.BackgroundColor = SystemColors.Window;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 175);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(252, 441);
            dataGridView2.TabIndex = 19;
            // 
            // FormCrearPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1383, 822);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormCrearPedido";
            Text = "FormCrearPedido";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Titulo;
        private Button Exit;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label4;
        private TextBox TxtPedido;
        private Label label1;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox txtBox_clienteId;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView2;
        private Button button2;
        private Label lblNombreCliente;
    }
}