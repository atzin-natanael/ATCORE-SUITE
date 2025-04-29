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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Titulo = new Label();
            Exit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            panel5 = new Panel();
            Tabla = new DataGridView();
            panel4 = new Panel();
            label4 = new Label();
            Cb_Vendedor = new ComboBox();
            txtBox_clienteNombre = new TextBox();
            txtBox_clienteId = new TextBox();
            Save = new Button();
            lblNombreCliente = new Label();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel3 = new Panel();
            panel7 = new Panel();
            panel10 = new Panel();
            label5 = new Label();
            panel9 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel8 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabla).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Titulo.BackColor = Color.White;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.Black;
            Titulo.Location = new Point(0, 0);
            Titulo.Margin = new Padding(0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(1242, 50);
            Titulo.TabIndex = 3;
            Titulo.Text = "CREACIÓN DE PEDIDO";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Right;
            Exit.BackColor = Color.FromArgb(60, 60, 60);
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseOverBackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(1242, 0);
            Exit.Margin = new Padding(0);
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
            panel1.BackColor = Color.White;
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
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
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 772);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(Tabla);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 178);
            panel5.Name = "panel5";
            panel5.Size = new Size(968, 594);
            panel5.TabIndex = 25;
            // 
            // Tabla
            // 
            Tabla.AllowUserToAddRows = false;
            Tabla.AllowUserToDeleteRows = false;
            Tabla.BackgroundColor = Color.Beige;
            Tabla.BorderStyle = BorderStyle.None;
            Tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Tabla.ColumnHeadersHeight = 50;
            Tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Tabla.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4 });
            Tabla.Dock = DockStyle.Fill;
            Tabla.EnableHeadersVisualStyles = false;
            Tabla.GridColor = Color.Black;
            Tabla.Location = new Point(0, 0);
            Tabla.MultiSelect = false;
            Tabla.Name = "Tabla";
            Tabla.RowHeadersVisible = false;
            Tabla.RowHeadersWidth = 50;
            Tabla.Size = new Size(968, 594);
            Tabla.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(Cb_Vendedor);
            panel4.Controls.Add(txtBox_clienteNombre);
            panel4.Controls.Add(txtBox_clienteId);
            panel4.Controls.Add(Save);
            panel4.Controls.Add(lblNombreCliente);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(968, 178);
            panel4.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 26;
            label4.Text = "Vendedor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cb_Vendedor
            // 
            Cb_Vendedor.FlatStyle = FlatStyle.Flat;
            Cb_Vendedor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cb_Vendedor.FormattingEnabled = true;
            Cb_Vendedor.Location = new Point(138, 3);
            Cb_Vendedor.Name = "Cb_Vendedor";
            Cb_Vendedor.Size = new Size(276, 27);
            Cb_Vendedor.TabIndex = 25;
            // 
            // txtBox_clienteNombre
            // 
            txtBox_clienteNombre.Location = new Point(201, 72);
            txtBox_clienteNombre.Name = "txtBox_clienteNombre";
            txtBox_clienteNombre.Size = new Size(370, 27);
            txtBox_clienteNombre.TabIndex = 23;
            // 
            // txtBox_clienteId
            // 
            txtBox_clienteId.Location = new Point(9, 72);
            txtBox_clienteId.Name = "txtBox_clienteId";
            txtBox_clienteId.Size = new Size(154, 27);
            txtBox_clienteId.TabIndex = 21;
            txtBox_clienteId.TextChanged += txtBox_clienteId_TextChanged;
            txtBox_clienteId.KeyDown += txtBox_clienteId_KeyDown;
            // 
            // Save
            // 
            Save.AutoSize = true;
            Save.BackColor = Color.FromArgb(60, 60, 60);
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatAppearance.MouseOverBackColor = Color.Gray;
            Save.FlatStyle = FlatStyle.Flat;
            Save.ForeColor = Color.White;
            Save.Location = new Point(823, 3);
            Save.Name = "Save";
            Save.Size = new Size(145, 33);
            Save.TabIndex = 0;
            Save.Text = "Guardar Pedido";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.FlatStyle = FlatStyle.Flat;
            lblNombreCliente.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            lblNombreCliente.ForeColor = Color.Black;
            lblNombreCliente.Location = new Point(3, 44);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(160, 21);
            lblNombreCliente.TabIndex = 22;
            lblNombreCliente.Text = "Clave Cliente";
            lblNombreCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(201, 44);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 20;
            label3.Text = "Nombre del cliente";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(351, 150);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 19;
            label1.Text = "Articulos en el Pedido:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(768, 725);
            button2.Name = "button2";
            button2.Size = new Size(186, 35);
            button2.TabIndex = 23;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(968, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(415, 772);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 178);
            panel7.Name = "panel7";
            panel7.Size = new Size(415, 594);
            panel7.TabIndex = 22;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(label5);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(46, 286);
            panel10.Name = "panel10";
            panel10.Size = new Size(369, 286);
            panel10.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(133, 121);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 20;
            label5.Text = "TOTALES";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView1);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(46, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(369, 286);
            panel9.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(369, 286);
            dataGridView1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(46, 594);
            panel8.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(415, 178);
            panel6.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(127, 133);
            label2.Name = "label2";
            label2.Size = new Size(209, 25);
            label2.TabIndex = 20;
            label2.Text = "Recomendaciones:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Column2
            // 
            Column2.HeaderText = "Codigo";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Descripcion";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.Name = "Column4";
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
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabla).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Titulo;
        private Button Exit;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button Save;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TextBox txtBox_clienteId;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label lblNombreCliente;
        private DataGridView Tabla;
        private Panel panel5;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Panel panel8;
        private Panel panel10;
        private Label label5;
        private Panel panel9;
        private TextBox txtBox_clienteNombre;
        private Label label4;
        private ComboBox Cb_Vendedor;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}