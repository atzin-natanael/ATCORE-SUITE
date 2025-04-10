namespace ProyectoXperto
{
    partial class PedidoXperto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoXperto));
            Toppanel = new Panel();
            label1 = new Label();
            Leftpanel = new Panel();
            Hide = new Button();
            SubpanelMenu = new Panel();
            BtnValidarPedido = new Button();
            BtnNuevoPedido = new Button();
            Btnpedido = new Button();
            Primarypanel = new Panel();
            pictureBox1 = new PictureBox();
            collapseTimer = new System.Windows.Forms.Timer(components);
            BtnAdministrador = new Button();
            Toppanel.SuspendLayout();
            Leftpanel.SuspendLayout();
            SubpanelMenu.SuspendLayout();
            Primarypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Toppanel
            // 
            Toppanel.BackColor = Color.FromArgb(49, 46, 178);
            Toppanel.Controls.Add(label1);
            Toppanel.Dock = DockStyle.Top;
            Toppanel.Location = new Point(0, 0);
            Toppanel.Name = "Toppanel";
            Toppanel.Size = new Size(1008, 148);
            Toppanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(456, 21);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 0;
            label1.Text = "PedidoXperto";
            // 
            // Leftpanel
            // 
            Leftpanel.BackColor = Color.FromArgb(23, 24, 37);
            Leftpanel.Controls.Add(BtnAdministrador);
            Leftpanel.Controls.Add(Hide);
            Leftpanel.Controls.Add(SubpanelMenu);
            Leftpanel.Controls.Add(Btnpedido);
            Leftpanel.Dock = DockStyle.Left;
            Leftpanel.Location = new Point(0, 148);
            Leftpanel.Name = "Leftpanel";
            Leftpanel.Size = new Size(240, 533);
            Leftpanel.TabIndex = 1;
            Leftpanel.MouseEnter += Leftpanel_MouseEnter;
            Leftpanel.MouseLeave += Leftpanel_MouseLeave;
            // 
            // Hide
            // 
            Hide.Cursor = Cursors.Hand;
            Hide.Dock = DockStyle.Bottom;
            Hide.FlatAppearance.BorderSize = 0;
            Hide.FlatAppearance.MouseDownBackColor = Color.White;
            Hide.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 46, 178);
            Hide.FlatStyle = FlatStyle.Flat;
            Hide.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hide.ForeColor = Color.White;
            Hide.Location = new Point(0, 491);
            Hide.Name = "Hide";
            Hide.Size = new Size(240, 42);
            Hide.TabIndex = 2;
            Hide.Text = "Ocultar";
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // SubpanelMenu
            // 
            SubpanelMenu.Controls.Add(BtnValidarPedido);
            SubpanelMenu.Controls.Add(BtnNuevoPedido);
            SubpanelMenu.Dock = DockStyle.Top;
            SubpanelMenu.Location = new Point(0, 58);
            SubpanelMenu.Name = "SubpanelMenu";
            SubpanelMenu.Size = new Size(240, 119);
            SubpanelMenu.TabIndex = 1;
            // 
            // BtnValidarPedido
            // 
            BtnValidarPedido.BackColor = Color.FromArgb(60, 60, 60);
            BtnValidarPedido.Cursor = Cursors.Hand;
            BtnValidarPedido.Dock = DockStyle.Top;
            BtnValidarPedido.FlatAppearance.BorderSize = 0;
            BtnValidarPedido.FlatAppearance.MouseDownBackColor = Color.White;
            BtnValidarPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 70, 190);
            BtnValidarPedido.FlatStyle = FlatStyle.Flat;
            BtnValidarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnValidarPedido.ForeColor = Color.White;
            BtnValidarPedido.Location = new Point(0, 58);
            BtnValidarPedido.Name = "BtnValidarPedido";
            BtnValidarPedido.Size = new Size(240, 58);
            BtnValidarPedido.TabIndex = 2;
            BtnValidarPedido.Text = "Validar Pedido";
            BtnValidarPedido.UseVisualStyleBackColor = false;
            BtnValidarPedido.Click += BtnValidarPedido_Click;
            // 
            // BtnNuevoPedido
            // 
            BtnNuevoPedido.BackColor = Color.FromArgb(60, 60, 60);
            BtnNuevoPedido.Cursor = Cursors.Hand;
            BtnNuevoPedido.Dock = DockStyle.Top;
            BtnNuevoPedido.FlatAppearance.BorderSize = 0;
            BtnNuevoPedido.FlatAppearance.MouseDownBackColor = Color.White;
            BtnNuevoPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 70, 190);
            BtnNuevoPedido.FlatStyle = FlatStyle.Flat;
            BtnNuevoPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevoPedido.ForeColor = Color.White;
            BtnNuevoPedido.Location = new Point(0, 0);
            BtnNuevoPedido.Name = "BtnNuevoPedido";
            BtnNuevoPedido.Size = new Size(240, 58);
            BtnNuevoPedido.TabIndex = 1;
            BtnNuevoPedido.Text = "Nuevo Pedido";
            BtnNuevoPedido.UseVisualStyleBackColor = false;
            BtnNuevoPedido.Click += BtnNuevoPedido_Click;
            // 
            // Btnpedido
            // 
            Btnpedido.Cursor = Cursors.Hand;
            Btnpedido.Dock = DockStyle.Top;
            Btnpedido.FlatAppearance.BorderSize = 0;
            Btnpedido.FlatAppearance.MouseDownBackColor = Color.White;
            Btnpedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 46, 178);
            Btnpedido.FlatStyle = FlatStyle.Flat;
            Btnpedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnpedido.ForeColor = Color.White;
            Btnpedido.Location = new Point(0, 0);
            Btnpedido.Name = "Btnpedido";
            Btnpedido.Size = new Size(240, 58);
            Btnpedido.TabIndex = 0;
            Btnpedido.Text = "Pedidos";
            Btnpedido.UseVisualStyleBackColor = true;
            Btnpedido.Click += Btnpedido_Click;
            Btnpedido.MouseDown += Btnpedido_MouseDown;
            Btnpedido.MouseEnter += Btnpedido_MouseEnter;
            Btnpedido.MouseLeave += Btnpedido_MouseLeave;
            // 
            // Primarypanel
            // 
            Primarypanel.BackColor = Color.White;
            Primarypanel.Controls.Add(pictureBox1);
            Primarypanel.Dock = DockStyle.Fill;
            Primarypanel.Location = new Point(240, 148);
            Primarypanel.Name = "Primarypanel";
            Primarypanel.Size = new Size(768, 533);
            Primarypanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 136);
            pictureBox1.MaximumSize = new Size(466, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // collapseTimer
            // 
            collapseTimer.Interval = 300;
            collapseTimer.Tick += collapseTimer_Tick;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.Cursor = Cursors.Hand;
            BtnAdministrador.Dock = DockStyle.Top;
            BtnAdministrador.FlatAppearance.BorderSize = 0;
            BtnAdministrador.FlatAppearance.MouseDownBackColor = Color.White;
            BtnAdministrador.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 46, 178);
            BtnAdministrador.FlatStyle = FlatStyle.Flat;
            BtnAdministrador.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdministrador.ForeColor = Color.White;
            BtnAdministrador.Location = new Point(0, 177);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(240, 58);
            BtnAdministrador.TabIndex = 3;
            BtnAdministrador.Text = "Administrador";
            BtnAdministrador.UseVisualStyleBackColor = true;
            // 
            // PedidoXperto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(Primarypanel);
            Controls.Add(Leftpanel);
            Controls.Add(Toppanel);
            MinimumSize = new Size(1024, 720);
            Name = "PedidoXperto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PedidoXperto";
            WindowState = FormWindowState.Maximized;
            Toppanel.ResumeLayout(false);
            Toppanel.PerformLayout();
            Leftpanel.ResumeLayout(false);
            SubpanelMenu.ResumeLayout(false);
            Primarypanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Toppanel;
        private Label label1;
        private Panel Leftpanel;
        private Panel Primarypanel;
        private PictureBox pictureBox1;
        private Button Btnpedido;
        private Panel SubpanelMenu;
        private Button BtnValidarPedido;
        private Button BtnNuevoPedido;
        private Button Hide;
        private System.Windows.Forms.Timer collapseTimer;
        private Button BtnAdministrador;
    }
}
