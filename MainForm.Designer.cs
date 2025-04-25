using PedidoXperto;

namespace ProyectoXperto
{
    partial class MainForm
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
            Toppanel = new Panel();
            LogOut = new Label();
            LbUsuario = new Label();
            label1 = new Label();
            Leftpanel = new Panel();
            SubPanelMenuAdmin = new Panel();
            BtnUsuarios = new Button();
            BtnAdministrador = new Button();
            Hide = new Button();
            SubpanelMenuPedido = new Panel();
            BtnValidarPedido = new Button();
            BtnNuevoPedido = new Button();
            Btnpedido = new Button();
            Primarypanel = new Panel();
            ImageMain = new PictureBox();
            collapseTimer = new System.Windows.Forms.Timer(components);
            Toppanel.SuspendLayout();
            Leftpanel.SuspendLayout();
            SubPanelMenuAdmin.SuspendLayout();
            SubpanelMenuPedido.SuspendLayout();
            Primarypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageMain).BeginInit();
            SuspendLayout();
            // 
            // Toppanel
            // 
            Toppanel.BackColor = Color.FromArgb(49, 46, 178);
            Toppanel.Controls.Add(LogOut);
            Toppanel.Controls.Add(LbUsuario);
            Toppanel.Controls.Add(label1);
            Toppanel.Dock = DockStyle.Top;
            Toppanel.Location = new Point(0, 0);
            Toppanel.Margin = new Padding(3, 4, 3, 4);
            Toppanel.Name = "Toppanel";
            Toppanel.Size = new Size(1152, 197);
            Toppanel.TabIndex = 0;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LogOut.AutoSize = true;
            LogOut.Cursor = Cursors.Hand;
            LogOut.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LogOut.ForeColor = SystemColors.Control;
            LogOut.Location = new Point(1016, 9);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(136, 23);
            LogOut.TabIndex = 2;
            LogOut.Text = "Cerrar Sesion";
            LogOut.Click += LogOut_Click;
            LogOut.MouseEnter += LogOut_MouseEnter;
            LogOut.MouseLeave += LogOut_MouseLeave;
            // 
            // LbUsuario
            // 
            LbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LbUsuario.AutoSize = true;
            LbUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbUsuario.ForeColor = SystemColors.Control;
            LbUsuario.Location = new Point(1140, 42);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(0, 23);
            LbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(521, 28);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 0;
            label1.Text = "PedidoXperto";
            // 
            // Leftpanel
            // 
            Leftpanel.BackColor = Color.FromArgb(23, 24, 37);
            Leftpanel.Controls.Add(SubPanelMenuAdmin);
            Leftpanel.Controls.Add(BtnAdministrador);
            Leftpanel.Controls.Add(Hide);
            Leftpanel.Controls.Add(SubpanelMenuPedido);
            Leftpanel.Controls.Add(Btnpedido);
            Leftpanel.Dock = DockStyle.Left;
            Leftpanel.Location = new Point(0, 197);
            Leftpanel.Margin = new Padding(3, 4, 3, 4);
            Leftpanel.Name = "Leftpanel";
            Leftpanel.Size = new Size(274, 711);
            Leftpanel.TabIndex = 1;
            Leftpanel.MouseEnter += Leftpanel_MouseEnter;
            Leftpanel.MouseLeave += Leftpanel_MouseLeave;
            // 
            // SubPanelMenuAdmin
            // 
            SubPanelMenuAdmin.Controls.Add(BtnUsuarios);
            SubPanelMenuAdmin.Dock = DockStyle.Top;
            SubPanelMenuAdmin.Location = new Point(0, 313);
            SubPanelMenuAdmin.Margin = new Padding(3, 4, 3, 4);
            SubPanelMenuAdmin.Name = "SubPanelMenuAdmin";
            SubPanelMenuAdmin.Size = new Size(274, 80);
            SubPanelMenuAdmin.TabIndex = 4;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.White;
            BtnUsuarios.Cursor = Cursors.Hand;
            BtnUsuarios.Dock = DockStyle.Top;
            BtnUsuarios.FlatAppearance.BorderSize = 0;
            BtnUsuarios.FlatAppearance.MouseDownBackColor = Color.White;
            BtnUsuarios.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUsuarios.ForeColor = Color.Black;
            BtnUsuarios.Location = new Point(0, 0);
            BtnUsuarios.Margin = new Padding(3, 4, 3, 4);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(274, 77);
            BtnUsuarios.TabIndex = 1;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.Cursor = Cursors.Hand;
            BtnAdministrador.Dock = DockStyle.Top;
            BtnAdministrador.FlatAppearance.BorderSize = 0;
            BtnAdministrador.FlatAppearance.MouseDownBackColor = Color.White;
            BtnAdministrador.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            BtnAdministrador.FlatStyle = FlatStyle.Flat;
            BtnAdministrador.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdministrador.ForeColor = Color.White;
            BtnAdministrador.Location = new Point(0, 236);
            BtnAdministrador.Margin = new Padding(3, 4, 3, 4);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(274, 77);
            BtnAdministrador.TabIndex = 3;
            BtnAdministrador.Text = "Administrador";
            BtnAdministrador.UseVisualStyleBackColor = true;
            BtnAdministrador.Click += BtnAdministrador_Click;
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
            Hide.Location = new Point(0, 655);
            Hide.Margin = new Padding(3, 4, 3, 4);
            Hide.Name = "Hide";
            Hide.Size = new Size(274, 56);
            Hide.TabIndex = 2;
            Hide.Text = "Ocultar";
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // SubpanelMenuPedido
            // 
            SubpanelMenuPedido.Controls.Add(BtnValidarPedido);
            SubpanelMenuPedido.Controls.Add(BtnNuevoPedido);
            SubpanelMenuPedido.Dock = DockStyle.Top;
            SubpanelMenuPedido.Location = new Point(0, 77);
            SubpanelMenuPedido.Margin = new Padding(3, 4, 3, 4);
            SubpanelMenuPedido.Name = "SubpanelMenuPedido";
            SubpanelMenuPedido.Size = new Size(274, 159);
            SubpanelMenuPedido.TabIndex = 1;
            // 
            // BtnValidarPedido
            // 
            BtnValidarPedido.BackColor = Color.White;
            BtnValidarPedido.Cursor = Cursors.Hand;
            BtnValidarPedido.Dock = DockStyle.Top;
            BtnValidarPedido.FlatAppearance.BorderSize = 0;
            BtnValidarPedido.FlatAppearance.MouseDownBackColor = Color.White;
            BtnValidarPedido.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnValidarPedido.FlatStyle = FlatStyle.Flat;
            BtnValidarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnValidarPedido.ForeColor = Color.Black;
            BtnValidarPedido.Location = new Point(0, 77);
            BtnValidarPedido.Margin = new Padding(3, 4, 3, 4);
            BtnValidarPedido.Name = "BtnValidarPedido";
            BtnValidarPedido.Size = new Size(274, 77);
            BtnValidarPedido.TabIndex = 2;
            BtnValidarPedido.Text = "Validar Pedido";
            BtnValidarPedido.UseVisualStyleBackColor = false;
            BtnValidarPedido.Click += BtnValidarPedido_Click;
            // 
            // BtnNuevoPedido
            // 
            BtnNuevoPedido.BackColor = Color.White;
            BtnNuevoPedido.Cursor = Cursors.Hand;
            BtnNuevoPedido.Dock = DockStyle.Top;
            BtnNuevoPedido.FlatAppearance.BorderSize = 0;
            BtnNuevoPedido.FlatAppearance.MouseDownBackColor = Color.White;
            BtnNuevoPedido.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnNuevoPedido.FlatStyle = FlatStyle.Flat;
            BtnNuevoPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevoPedido.ForeColor = Color.Black;
            BtnNuevoPedido.Location = new Point(0, 0);
            BtnNuevoPedido.Margin = new Padding(3, 4, 3, 4);
            BtnNuevoPedido.Name = "BtnNuevoPedido";
            BtnNuevoPedido.Size = new Size(274, 77);
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
            Btnpedido.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            Btnpedido.FlatStyle = FlatStyle.Flat;
            Btnpedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnpedido.ForeColor = Color.White;
            Btnpedido.Location = new Point(0, 0);
            Btnpedido.Margin = new Padding(3, 4, 3, 4);
            Btnpedido.Name = "Btnpedido";
            Btnpedido.Size = new Size(274, 77);
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
            Primarypanel.Controls.Add(ImageMain);
            Primarypanel.Dock = DockStyle.Fill;
            Primarypanel.Location = new Point(274, 197);
            Primarypanel.Margin = new Padding(3, 4, 3, 4);
            Primarypanel.Name = "Primarypanel";
            Primarypanel.Size = new Size(878, 711);
            Primarypanel.TabIndex = 2;
            // 
            // ImageMain
            // 
            ImageMain.Anchor = AnchorStyles.None;
            ImageMain.Image = ResourcesXperto.Logo;
            ImageMain.Location = new Point(181, 77);
            ImageMain.Margin = new Padding(3, 4, 3, 4);
            ImageMain.MaximumSize = new Size(533, 488);
            ImageMain.Name = "ImageMain";
            ImageMain.Size = new Size(533, 488);
            ImageMain.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageMain.TabIndex = 0;
            ImageMain.TabStop = false;
            // 
            // collapseTimer
            // 
            collapseTimer.Interval = 300;
            collapseTimer.Tick += collapseTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 908);
            Controls.Add(Primarypanel);
            Controls.Add(Leftpanel);
            Controls.Add(Toppanel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1168, 944);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PedidoXperto";
            WindowState = FormWindowState.Maximized;
            Toppanel.ResumeLayout(false);
            Toppanel.PerformLayout();
            Leftpanel.ResumeLayout(false);
            SubPanelMenuAdmin.ResumeLayout(false);
            SubpanelMenuPedido.ResumeLayout(false);
            Primarypanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImageMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Toppanel;
        private Label label1;
        private Panel Leftpanel;
        private Panel Primarypanel;
        private PictureBox ImageMain;
        private Button Btnpedido;
        private Panel SubpanelMenuPedido;
        private Button BtnValidarPedido;
        private Button BtnNuevoPedido;
        private Button Hide;
        private System.Windows.Forms.Timer collapseTimer;
        private Button BtnAdministrador;
        private Panel SubPanelMenuAdmin;
        private Button BtnUsuarios;
        public Label LbUsuario;
        public Label LogOut;
    }
}
