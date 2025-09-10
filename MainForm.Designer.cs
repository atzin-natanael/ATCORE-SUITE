using ATCORE_SUITE;

namespace ATCORE_SUITE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Toppanel = new Panel();
            Min = new Button();
            Max = new Button();
            ExitMain = new Button();
            Title2 = new Label();
            LogOut = new Label();
            LbUsuario = new Label();
            Title1 = new Label();
            ImageMain = new PictureBox();
            collapseTimer = new System.Windows.Forms.Timer(components);
            CompletePanel = new Panel();
            Primarypanel = new Panel();
            Leftpanel = new Panel();
            SubPanelMenuAdmin = new Panel();
            BtnRoles = new Button();
            BtnUsuarios = new Button();
            BtnAdministrador = new Button();
            SubPanelInventario = new Panel();
            BtnCSalida = new Button();
            BtnCEntrada = new Button();
            BtnTSalida = new Button();
            BtnTEntrada = new Button();
            BtnInventario = new Button();
            SubpanelMenuPedido = new Panel();
            EnviarTicket = new Button();
            BtnValidarPedido = new Button();
            Btnpedido = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Hide = new Button();
            Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageMain).BeginInit();
            CompletePanel.SuspendLayout();
            Primarypanel.SuspendLayout();
            Leftpanel.SuspendLayout();
            SubPanelMenuAdmin.SuspendLayout();
            SubPanelInventario.SuspendLayout();
            SubpanelMenuPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Toppanel
            // 
            Toppanel.BackColor = Color.FromArgb(120, 120, 120);
            Toppanel.Controls.Add(Min);
            Toppanel.Controls.Add(Max);
            Toppanel.Controls.Add(ExitMain);
            Toppanel.Controls.Add(Title2);
            Toppanel.Controls.Add(LogOut);
            Toppanel.Controls.Add(LbUsuario);
            Toppanel.Controls.Add(Title1);
            Toppanel.Cursor = Cursors.Hand;
            Toppanel.Dock = DockStyle.Top;
            Toppanel.Location = new Point(0, 0);
            Toppanel.Name = "Toppanel";
            Toppanel.Size = new Size(1366, 58);
            Toppanel.TabIndex = 0;
            Toppanel.MouseDown += Toppanel_MouseDown;
            // 
            // Min
            // 
            Min.BackColor = Color.FromArgb(120, 120, 120);
            Min.Cursor = Cursors.Hand;
            Min.Dock = DockStyle.Right;
            Min.FlatAppearance.BorderSize = 0;
            Min.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Min.FlatStyle = FlatStyle.Flat;
            Min.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Min.ForeColor = Color.White;
            Min.Image = (Image)resources.GetObject("Min.Image");
            Min.Location = new Point(1165, 0);
            Min.Name = "Min";
            Min.Size = new Size(67, 58);
            Min.TabIndex = 0;
            Min.TabStop = false;
            Min.UseVisualStyleBackColor = false;
            Min.Click += Min_Click;
            // 
            // Max
            // 
            Max.BackColor = Color.FromArgb(120, 120, 120);
            Max.Cursor = Cursors.Hand;
            Max.Dock = DockStyle.Right;
            Max.FlatAppearance.BorderSize = 0;
            Max.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            Max.FlatStyle = FlatStyle.Flat;
            Max.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Max.ForeColor = Color.White;
            Max.Image = (Image)resources.GetObject("Max.Image");
            Max.Location = new Point(1232, 0);
            Max.Name = "Max";
            Max.Size = new Size(67, 58);
            Max.TabIndex = 0;
            Max.TabStop = false;
            Max.UseVisualStyleBackColor = false;
            Max.Click += Max_Click;
            // 
            // ExitMain
            // 
            ExitMain.BackColor = Color.FromArgb(120, 120, 120);
            ExitMain.Cursor = Cursors.Hand;
            ExitMain.Dock = DockStyle.Right;
            ExitMain.FlatAppearance.BorderSize = 0;
            ExitMain.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            ExitMain.FlatStyle = FlatStyle.Flat;
            ExitMain.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitMain.ForeColor = Color.White;
            ExitMain.Image = (Image)resources.GetObject("ExitMain.Image");
            ExitMain.Location = new Point(1299, 0);
            ExitMain.Name = "ExitMain";
            ExitMain.Size = new Size(67, 58);
            ExitMain.TabIndex = 0;
            ExitMain.UseVisualStyleBackColor = false;
            ExitMain.Click += Exit_Click;
            // 
            // Title2
            // 
            Title2.Anchor = AnchorStyles.None;
            Title2.AutoSize = true;
            Title2.BackColor = Color.FromArgb(120, 120, 120);
            Title2.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title2.ForeColor = Color.Red;
            Title2.Location = new Point(727, 12);
            Title2.Name = "Title2";
            Title2.Size = new Size(95, 30);
            Title2.TabIndex = 3;
            Title2.Text = "SUITE";
            Title2.Visible = false;
            Title2.Click += Title2_Click;
            // 
            // LogOut
            // 
            LogOut.Anchor = AnchorStyles.Left;
            LogOut.AutoSize = true;
            LogOut.Cursor = Cursors.Hand;
            LogOut.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LogOut.ForeColor = SystemColors.Control;
            LogOut.Location = new Point(6, 32);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(110, 21);
            LogOut.TabIndex = 2;
            LogOut.Text = "Cerrar Sesion";
            LogOut.Click += LogOut_Click;
            LogOut.MouseEnter += LogOut_MouseEnter;
            LogOut.MouseLeave += LogOut_MouseLeave;
            // 
            // LbUsuario
            // 
            LbUsuario.Anchor = AnchorStyles.Left;
            LbUsuario.BackColor = Color.FromArgb(120, 120, 120);
            LbUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbUsuario.ForeColor = SystemColors.Control;
            LbUsuario.Location = new Point(3, 9);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(349, 23);
            LbUsuario.TabIndex = 1;
            LbUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Title1
            // 
            Title1.Anchor = AnchorStyles.None;
            Title1.AutoSize = true;
            Title1.BackColor = Color.FromArgb(120, 120, 120);
            Title1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title1.ForeColor = Color.White;
            Title1.Location = new Point(599, 12);
            Title1.Name = "Title1";
            Title1.Size = new Size(133, 30);
            Title1.TabIndex = 0;
            Title1.Text = "AT-CORE";
            Title1.Visible = false;
            // 
            // ImageMain
            // 
            ImageMain.Anchor = AnchorStyles.None;
            ImageMain.Image = (Image)resources.GetObject("ImageMain.Image");
            ImageMain.Location = new Point(483, 198);
            ImageMain.MaximumSize = new Size(466, 366);
            ImageMain.Name = "ImageMain";
            ImageMain.Size = new Size(466, 366);
            ImageMain.SizeMode = PictureBoxSizeMode.Zoom;
            ImageMain.TabIndex = 0;
            ImageMain.TabStop = false;
            ImageMain.Click += ImageMain_Click;
            // 
            // collapseTimer
            // 
            collapseTimer.Interval = 300;
            collapseTimer.Tick += collapseTimer_Tick;
            // 
            // CompletePanel
            // 
            CompletePanel.Controls.Add(Primarypanel);
            CompletePanel.Controls.Add(Toppanel);
            CompletePanel.Dock = DockStyle.Fill;
            CompletePanel.Location = new Point(0, 0);
            CompletePanel.Name = "CompletePanel";
            CompletePanel.Size = new Size(1366, 768);
            CompletePanel.TabIndex = 2;
            // 
            // Primarypanel
            // 
            Primarypanel.BackColor = Color.FromArgb(15, 15, 15);
            Primarypanel.Controls.Add(ImageMain);
            Primarypanel.Controls.Add(Leftpanel);
            Primarypanel.Dock = DockStyle.Fill;
            Primarypanel.Location = new Point(0, 58);
            Primarypanel.Name = "Primarypanel";
            Primarypanel.Size = new Size(1366, 710);
            Primarypanel.TabIndex = 1;
            // 
            // Leftpanel
            // 
            Leftpanel.BackColor = Color.FromArgb(120, 120, 120);
            Leftpanel.Controls.Add(SubPanelMenuAdmin);
            Leftpanel.Controls.Add(BtnAdministrador);
            Leftpanel.Controls.Add(SubPanelInventario);
            Leftpanel.Controls.Add(BtnInventario);
            Leftpanel.Controls.Add(SubpanelMenuPedido);
            Leftpanel.Controls.Add(Btnpedido);
            Leftpanel.Controls.Add(pictureBox2);
            Leftpanel.Controls.Add(pictureBox1);
            Leftpanel.Controls.Add(Hide);
            Leftpanel.Dock = DockStyle.Left;
            Leftpanel.Location = new Point(0, 0);
            Leftpanel.Name = "Leftpanel";
            Leftpanel.Size = new Size(240, 710);
            Leftpanel.TabIndex = 1;
            Leftpanel.MouseEnter += Leftpanel_MouseEnter;
            Leftpanel.MouseLeave += Leftpanel_MouseLeave;
            // 
            // SubPanelMenuAdmin
            // 
            SubPanelMenuAdmin.Controls.Add(BtnRoles);
            SubPanelMenuAdmin.Controls.Add(BtnUsuarios);
            SubPanelMenuAdmin.Dock = DockStyle.Top;
            SubPanelMenuAdmin.Location = new Point(0, 463);
            SubPanelMenuAdmin.Name = "SubPanelMenuAdmin";
            SubPanelMenuAdmin.Size = new Size(240, 106);
            SubPanelMenuAdmin.TabIndex = 4;
            // 
            // BtnRoles
            // 
            BtnRoles.BackColor = Color.Silver;
            BtnRoles.Cursor = Cursors.Hand;
            BtnRoles.Dock = DockStyle.Top;
            BtnRoles.FlatAppearance.BorderSize = 0;
            BtnRoles.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnRoles.FlatStyle = FlatStyle.Flat;
            BtnRoles.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRoles.ForeColor = Color.Black;
            BtnRoles.Location = new Point(0, 50);
            BtnRoles.Name = "BtnRoles";
            BtnRoles.Size = new Size(240, 50);
            BtnRoles.TabIndex = 0;
            BtnRoles.TabStop = false;
            BtnRoles.Text = "Roles";
            BtnRoles.UseVisualStyleBackColor = false;
            BtnRoles.Click += BtnRoles_Click;
            BtnRoles.MouseEnter += BtnRoles_MouseEnter;
            BtnRoles.MouseLeave += BtnRoles_MouseLeave;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.BackColor = Color.Silver;
            BtnUsuarios.Cursor = Cursors.Hand;
            BtnUsuarios.Dock = DockStyle.Top;
            BtnUsuarios.FlatAppearance.BorderSize = 0;
            BtnUsuarios.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnUsuarios.FlatStyle = FlatStyle.Flat;
            BtnUsuarios.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUsuarios.ForeColor = Color.Black;
            BtnUsuarios.Location = new Point(0, 0);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(240, 50);
            BtnUsuarios.TabIndex = 0;
            BtnUsuarios.TabStop = false;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.UseVisualStyleBackColor = false;
            BtnUsuarios.Click += BtnUsuarios_Click;
            BtnUsuarios.MouseEnter += BtnUsuarios_MouseEnter;
            BtnUsuarios.MouseLeave += BtnUsuarios_MouseLeave;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.BackColor = Color.FromArgb(50, 50, 50);
            BtnAdministrador.Cursor = Cursors.Hand;
            BtnAdministrador.Dock = DockStyle.Top;
            BtnAdministrador.FlatAppearance.BorderSize = 0;
            BtnAdministrador.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnAdministrador.FlatStyle = FlatStyle.Flat;
            BtnAdministrador.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAdministrador.ForeColor = SystemColors.Control;
            BtnAdministrador.Location = new Point(0, 409);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(240, 54);
            BtnAdministrador.TabIndex = 0;
            BtnAdministrador.TabStop = false;
            BtnAdministrador.Text = "Administrador";
            BtnAdministrador.UseVisualStyleBackColor = false;
            BtnAdministrador.Click += BtnAdministrador_Click;
            BtnAdministrador.MouseEnter += BtnAdministrador_MouseEnter_1;
            BtnAdministrador.MouseLeave += BtnAdministrador_MouseLeave_1;
            // 
            // SubPanelInventario
            // 
            SubPanelInventario.Controls.Add(BtnCSalida);
            SubPanelInventario.Controls.Add(BtnCEntrada);
            SubPanelInventario.Controls.Add(BtnTSalida);
            SubPanelInventario.Controls.Add(BtnTEntrada);
            SubPanelInventario.Dock = DockStyle.Top;
            SubPanelInventario.Location = new Point(0, 207);
            SubPanelInventario.Name = "SubPanelInventario";
            SubPanelInventario.Size = new Size(240, 202);
            SubPanelInventario.TabIndex = 5;
            // 
            // BtnCSalida
            // 
            BtnCSalida.BackColor = Color.Silver;
            BtnCSalida.Cursor = Cursors.Hand;
            BtnCSalida.Dock = DockStyle.Top;
            BtnCSalida.FlatAppearance.BorderSize = 0;
            BtnCSalida.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnCSalida.FlatStyle = FlatStyle.Flat;
            BtnCSalida.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCSalida.ForeColor = Color.Black;
            BtnCSalida.Location = new Point(0, 150);
            BtnCSalida.Name = "BtnCSalida";
            BtnCSalida.Size = new Size(240, 50);
            BtnCSalida.TabIndex = 2;
            BtnCSalida.TabStop = false;
            BtnCSalida.Text = "Enviar Compra";
            BtnCSalida.UseVisualStyleBackColor = false;
            BtnCSalida.Click += BtnCSalida_Click;
            BtnCSalida.MouseEnter += BtnCSalida_MouseEnter;
            BtnCSalida.MouseLeave += BtnCSalida_MouseLeave;
            // 
            // BtnCEntrada
            // 
            BtnCEntrada.BackColor = Color.Silver;
            BtnCEntrada.Cursor = Cursors.Hand;
            BtnCEntrada.Dock = DockStyle.Top;
            BtnCEntrada.FlatAppearance.BorderSize = 0;
            BtnCEntrada.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnCEntrada.FlatStyle = FlatStyle.Flat;
            BtnCEntrada.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCEntrada.ForeColor = Color.Black;
            BtnCEntrada.Location = new Point(0, 100);
            BtnCEntrada.Name = "BtnCEntrada";
            BtnCEntrada.Size = new Size(240, 50);
            BtnCEntrada.TabIndex = 1;
            BtnCEntrada.TabStop = false;
            BtnCEntrada.Text = "Recibir Compra";
            BtnCEntrada.UseVisualStyleBackColor = false;
            BtnCEntrada.Click += BtnCEntrada_Click;
            BtnCEntrada.MouseEnter += BtnCEntrada_MouseEnter;
            BtnCEntrada.MouseLeave += BtnCEntrada_MouseLeave;
            // 
            // BtnTSalida
            // 
            BtnTSalida.BackColor = Color.Silver;
            BtnTSalida.Cursor = Cursors.Hand;
            BtnTSalida.Dock = DockStyle.Top;
            BtnTSalida.FlatAppearance.BorderSize = 0;
            BtnTSalida.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnTSalida.FlatStyle = FlatStyle.Flat;
            BtnTSalida.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTSalida.ForeColor = Color.Black;
            BtnTSalida.Location = new Point(0, 50);
            BtnTSalida.Name = "BtnTSalida";
            BtnTSalida.Size = new Size(240, 50);
            BtnTSalida.TabIndex = 0;
            BtnTSalida.TabStop = false;
            BtnTSalida.Text = "Enviar Traspaso";
            BtnTSalida.UseVisualStyleBackColor = false;
            BtnTSalida.Click += BtnTSalida_Click;
            BtnTSalida.MouseEnter += BtnTSalida_MouseEnter;
            BtnTSalida.MouseLeave += BtnTSalida_MouseLeave;
            // 
            // BtnTEntrada
            // 
            BtnTEntrada.BackColor = Color.Silver;
            BtnTEntrada.Cursor = Cursors.Hand;
            BtnTEntrada.Dock = DockStyle.Top;
            BtnTEntrada.FlatAppearance.BorderSize = 0;
            BtnTEntrada.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnTEntrada.FlatStyle = FlatStyle.Flat;
            BtnTEntrada.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnTEntrada.ForeColor = Color.Black;
            BtnTEntrada.Location = new Point(0, 0);
            BtnTEntrada.Name = "BtnTEntrada";
            BtnTEntrada.Size = new Size(240, 50);
            BtnTEntrada.TabIndex = 0;
            BtnTEntrada.TabStop = false;
            BtnTEntrada.Text = "Recibir Traspaso";
            BtnTEntrada.UseVisualStyleBackColor = false;
            BtnTEntrada.Click += BtnTEntrada_Click;
            BtnTEntrada.MouseEnter += BtnTEntrada_MouseEnter;
            BtnTEntrada.MouseLeave += BtnTEntrada_MouseLeave;
            // 
            // BtnInventario
            // 
            BtnInventario.BackColor = Color.FromArgb(50, 50, 50);
            BtnInventario.Cursor = Cursors.Hand;
            BtnInventario.Dock = DockStyle.Top;
            BtnInventario.FlatAppearance.BorderSize = 0;
            BtnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            BtnInventario.FlatStyle = FlatStyle.Flat;
            BtnInventario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInventario.ForeColor = SystemColors.Control;
            BtnInventario.Location = new Point(0, 153);
            BtnInventario.Name = "BtnInventario";
            BtnInventario.Size = new Size(240, 54);
            BtnInventario.TabIndex = 2;
            BtnInventario.TabStop = false;
            BtnInventario.Text = "Inventario";
            BtnInventario.UseVisualStyleBackColor = false;
            BtnInventario.Click += BtnInventario_Click;
            BtnInventario.MouseEnter += BtnInventario_MouseEnter;
            BtnInventario.MouseLeave += BtnInventario_MouseLeave;
            // 
            // SubpanelMenuPedido
            // 
            SubpanelMenuPedido.Controls.Add(EnviarTicket);
            SubpanelMenuPedido.Controls.Add(BtnValidarPedido);
            SubpanelMenuPedido.Dock = DockStyle.Top;
            SubpanelMenuPedido.Location = new Point(0, 54);
            SubpanelMenuPedido.Name = "SubpanelMenuPedido";
            SubpanelMenuPedido.Size = new Size(240, 99);
            SubpanelMenuPedido.TabIndex = 1;
            // 
            // EnviarTicket
            // 
            EnviarTicket.BackColor = Color.Silver;
            EnviarTicket.Cursor = Cursors.Hand;
            EnviarTicket.Dock = DockStyle.Top;
            EnviarTicket.FlatAppearance.BorderSize = 0;
            EnviarTicket.FlatAppearance.MouseOverBackColor = Color.Gray;
            EnviarTicket.FlatStyle = FlatStyle.Flat;
            EnviarTicket.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnviarTicket.ForeColor = Color.Black;
            EnviarTicket.Location = new Point(0, 50);
            EnviarTicket.Name = "EnviarTicket";
            EnviarTicket.Size = new Size(240, 50);
            EnviarTicket.TabIndex = 1;
            EnviarTicket.TabStop = false;
            EnviarTicket.Text = "Enviar Ticket";
            EnviarTicket.UseVisualStyleBackColor = false;
            EnviarTicket.Click += EnviarTicket_Click;
            EnviarTicket.MouseEnter += EnviarTicket_MouseEnter;
            EnviarTicket.MouseLeave += EnviarTicket_MouseLeave;
            // 
            // BtnValidarPedido
            // 
            BtnValidarPedido.BackColor = Color.Silver;
            BtnValidarPedido.Cursor = Cursors.Hand;
            BtnValidarPedido.Dock = DockStyle.Top;
            BtnValidarPedido.FlatAppearance.BorderSize = 0;
            BtnValidarPedido.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnValidarPedido.FlatStyle = FlatStyle.Flat;
            BtnValidarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnValidarPedido.ForeColor = Color.Black;
            BtnValidarPedido.Location = new Point(0, 0);
            BtnValidarPedido.Name = "BtnValidarPedido";
            BtnValidarPedido.Size = new Size(240, 50);
            BtnValidarPedido.TabIndex = 0;
            BtnValidarPedido.TabStop = false;
            BtnValidarPedido.Text = "Validar Pedido";
            BtnValidarPedido.UseVisualStyleBackColor = false;
            BtnValidarPedido.Click += BtnValidarPedido_Click;
            BtnValidarPedido.MouseEnter += BtnValidarPedido_MouseEnter;
            BtnValidarPedido.MouseLeave += BtnValidarPedido_MouseLeave;
            // 
            // Btnpedido
            // 
            Btnpedido.BackColor = Color.FromArgb(50, 50, 50);
            Btnpedido.Cursor = Cursors.Hand;
            Btnpedido.Dock = DockStyle.Top;
            Btnpedido.FlatAppearance.BorderSize = 0;
            Btnpedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            Btnpedido.FlatStyle = FlatStyle.Flat;
            Btnpedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnpedido.ForeColor = SystemColors.Control;
            Btnpedido.Location = new Point(0, 0);
            Btnpedido.Name = "Btnpedido";
            Btnpedido.Size = new Size(240, 54);
            Btnpedido.TabIndex = 0;
            Btnpedido.TabStop = false;
            Btnpedido.Text = "Surtido";
            Btnpedido.UseVisualStyleBackColor = false;
            Btnpedido.Click += Btnpedido_Click;
            Btnpedido.MouseEnter += Btnpedido_MouseEnter;
            Btnpedido.MouseLeave += Btnpedido_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 456);
            pictureBox2.MaximumSize = new Size(466, 366);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 622);
            pictureBox1.MaximumSize = new Size(466, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Hide
            // 
            Hide.Cursor = Cursors.Hand;
            Hide.Dock = DockStyle.Bottom;
            Hide.FlatAppearance.BorderSize = 0;
            Hide.FlatAppearance.MouseDownBackColor = Color.White;
            Hide.FlatAppearance.MouseOverBackColor = Color.Gray;
            Hide.FlatStyle = FlatStyle.Flat;
            Hide.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hide.ForeColor = Color.White;
            Hide.Location = new Point(0, 668);
            Hide.Name = "Hide";
            Hide.Size = new Size(240, 42);
            Hide.TabIndex = 2;
            Hide.Text = "Ocultar";
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1366, 768);
            Controls.Add(CompletePanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1366, 768);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "ATCORE_SUITE";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            Toppanel.ResumeLayout(false);
            Toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageMain).EndInit();
            CompletePanel.ResumeLayout(false);
            Primarypanel.ResumeLayout(false);
            Leftpanel.ResumeLayout(false);
            SubPanelMenuAdmin.ResumeLayout(false);
            SubPanelInventario.ResumeLayout(false);
            SubpanelMenuPedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label Title1;
        private PictureBox ImageMain;
        private System.Windows.Forms.Timer collapseTimer;
        public Label LbUsuario;
        public Label LogOut;
        private Panel CompletePanel;
        private Panel Primarypanel;
        private Label Title2;
        public Button ExitMain;
        public Panel Toppanel;
        public Button Min;
        public Button Max;
        private Button Hide;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel SubPanelMenuAdmin;
        public Button BtnRoles;
        public Button BtnUsuarios;
        private Button BtnAdministrador;
        private Panel SubPanelInventario;
        public Button BtnCSalida;
        public Button BtnCEntrada;
        public Button BtnTSalida;
        public Button BtnTEntrada;
        private Panel SubpanelMenuPedido;
        public Button EnviarTicket;
        public Button BtnValidarPedido;
        private Button Btnpedido;
        private Panel Leftpanel;
        public Button BtnInventario;
    }
}
