using ATCORE_SUITE.ChildClases;
using ATCORE_SUITE.ChildForms;
using ATCORE_SUITE.Mesa_de_control;
using System.Runtime.InteropServices;

namespace ATCORE_SUITE
{
    public partial class MainForm : Form
    {
        bool activo = false;
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(49, 46, 178);
            Design();
            //LoadConfig();
        }
        public void LoadConfig()
        {
            string filePath = GlobalSettings.Instance.PathConfig + "DB.txt"; // Ruta de tu archivo de texto
            List<string> lineas = new List<string>();

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                // Leer todas las líneas del archivo
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string linea;
                    GlobalSettings.Instance.Config = new List<string>();
                    while ((linea = sr.ReadLine()) != null)
                    {
                        GlobalSettings.Instance.Config.Add(linea);
                    }

                }
                GlobalSettings.Instance.Ip = GlobalSettings.Instance.Config[0];
                GlobalSettings.Instance.Puerto = GlobalSettings.Instance.Config[1];
                GlobalSettings.Instance.Direccion = GlobalSettings.Instance.Config[2];
                GlobalSettings.Instance.User = GlobalSettings.Instance.Config[3];
                GlobalSettings.Instance.Pw = GlobalSettings.Instance.Config[4];
                GlobalSettings.Instance.LastUser = GlobalSettings.Instance.Config[5];
                GlobalSettings.Instance.StringConnectionCloud = GlobalSettings.Instance.Config[6];
                GlobalSettings.Instance.StringConnection =
                    "User=" + GlobalSettings.Instance.User + ";" +
                    "Password=" + GlobalSettings.Instance.Pw + ";" +
                    "Database=" + GlobalSettings.Instance.Direccion + ";" +
                    "DataSource=" + GlobalSettings.Instance.Ip + ";" +
                    "Port=" + GlobalSettings.Instance.Puerto + ";" +
                    "Dialect=3;" +
                    "Charset=UTF8;";
            }
            else
            {
                MessageBox.Show("Archivo de Configuracion no encontrado", "DB.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Btnpedido_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubpanelMenuPedido);
        }
        public void Design()
        {
            SubpanelMenuPedido.Visible = false;
            SubPanelMenuAdmin.Visible = false;
            SubPanelInventario.Visible = false;
        }
        public void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        public void HideSubmenu()
        {
            if (SubpanelMenuPedido.Visible == true)
            {
                SubpanelMenuPedido.Visible = false;
            }
            if (SubPanelMenuAdmin.Visible == true)
            {
                SubPanelMenuAdmin.Visible = false;
            }
            if (SubPanelInventario.Visible == true)
            {
                SubPanelInventario.Visible = false;
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (Hide.Text == ">")
            {
                Leftpanel.Width = 240;
                foreach (Control ctrl in Leftpanel.Controls)
                {
                    if (ctrl is Button && ctrl != Hide)
                        ctrl.Visible = true;
                }
                foreach (Control ctrl in SubpanelMenuPedido.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = true;
                }
                foreach (Control ctrl in SubPanelMenuAdmin.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = true;
                }
                foreach (Control ctrl in SubPanelInventario.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = true;
                }
                Hide.Text = "Ocultar";
            }
            else
            {
                Leftpanel.Width = 30;
                foreach (Control ctrl in Leftpanel.Controls)
                {
                    if (ctrl is Button && ctrl != Hide)
                        ctrl.Visible = false;
                }
                foreach (Control ctrl in SubpanelMenuPedido.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                foreach (Control ctrl in SubPanelMenuAdmin.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                foreach (Control ctrl in SubPanelInventario.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                Hide.Text = ">";
            }
        }
        bool mouseInside = false;
        private void Leftpanel_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = Leftpanel.PointToClient(Cursor.Position);

            if (!Leftpanel.ClientRectangle.Contains(mousePos))
            {
                collapseTimer.Start();
            }
        }

        private void Leftpanel_MouseEnter(object sender, EventArgs e)
        {
            Point mousePos = Leftpanel.PointToClient(Cursor.Position);

            if (Leftpanel.ClientRectangle.Contains(mousePos) && !mouseInside)
            {
                // Entra por primera vez desde fuera
                collapseTimer.Stop();
                Mostrar();
            }

            mouseInside = true;
        }
        public void Ocultar()
        {
            Leftpanel.Width = 30;
            foreach (Control ctrl in Leftpanel.Controls)
            {
                if (ctrl is Button && ctrl != Hide)
                    ctrl.Visible = false;
            }
            foreach (Control ctrl in SubpanelMenuPedido.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = false;
            }
            foreach (Control ctrl in SubPanelMenuAdmin.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = false;
            }
            foreach (Control ctrl in SubPanelInventario.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = false;
            }
            Hide.Text = ">";
        }
        public void Mostrar()
        {
            Leftpanel.Width = 240;
            foreach (Control ctrl in Leftpanel.Controls)
            {
                if (ctrl is Button && ctrl != Hide)
                    ctrl.Visible = true;
            }
            foreach (Control ctrl in SubpanelMenuPedido.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = true;
            }
            foreach (Control ctrl in SubPanelMenuAdmin.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = true;
            }
            foreach (Control ctrl in SubPanelInventario.Controls)
            {
                if (ctrl is Button)
                    ctrl.Visible = true;
            }
            Hide.Text = "Ocultar";
        }
        bool MouseEstaDentroDelPanel()
        {
            Point mousePos = PointToClient(Cursor.Position);
            Control controlBajoMouse = GetChildAtPoint(mousePos, GetChildAtPointSkip.Invisible);

            return controlBajoMouse != null && (controlBajoMouse == Leftpanel || Leftpanel.Contains(controlBajoMouse));
        }

        private void collapseTimer_Tick(object sender, EventArgs e)
        {
            if (!MouseEstaDentroDelPanel())
            {
                Leftpanel.Width = 30;

                foreach (Control ctrl in Leftpanel.Controls)
                {
                    if (ctrl is Button && ctrl != Hide)
                        ctrl.Visible = false;
                }

                foreach (Control ctrl in SubpanelMenuPedido.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }

                foreach (Control ctrl in SubPanelMenuAdmin.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }

                foreach (Control ctrl in SubPanelInventario.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }

                Hide.Text = ">";
                collapseTimer.Stop();
            }
        }

        private Form activeForm = null;
        private void openChild(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Primarypanel.Controls.Add(childForm);
            Primarypanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private FormValidarPedido frmValidar;
        private void BtnValidarPedido_Click(object sender, EventArgs e)
        {
            if (frmValidar == null || frmValidar.IsDisposed)
                frmValidar = new FormValidarPedido();
            ExitMain.Visible = false;
            openChild(frmValidar);
            frmValidar.TxtPedido.Focus();
            HideSubmenu();
            Ocultar();
        }
        private FormCrearPedido formCrearPedido;
        private void BtnNuevoPedido_Click(object sender, EventArgs e)
        {
            if (formCrearPedido == null || formCrearPedido.IsDisposed)
                formCrearPedido = new FormCrearPedido();

            openChild(formCrearPedido);
            HideSubmenu();
            Title1.Visible = true;
            Title2.Visible = true;
            Ocultar();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubPanelMenuAdmin);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            ExitMain.Visible = false;
            openChild(new FormAdminUsuarios());
            HideSubmenu();
            Ocultar();
        }

        private void LogOut_MouseEnter(object sender, EventArgs e)
        {
            LogOut.ForeColor = System.Drawing.Color.Red;
        }

        private void LogOut_MouseLeave(object sender, EventArgs e)
        {
            LogOut.ForeColor = SystemColors.Control;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Estás seguro de que deseas cerrar sesión?\nTodo el trabajo no guardado se perderá.",
               "Confirmar cierre de sesión",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning
           );

            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void BtnAdministrador_MouseEnter(object sender, EventArgs e)
        {
            BtnAdministrador.ForeColor = Color.Red;
        }

        private void BtnAdministrador_MouseLeave(object sender, EventArgs e)
        {
            BtnAdministrador.ForeColor = Color.Red;
            Ocultar();
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            ExitMain.Visible = false;
            openChild(new FormAdminRoles());
            HideSubmenu();
            Ocultar();
        }

        private void ImageMain_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Login log = new Login();
            //log.ShowDialog();

        }

        private void EnviarTicket_Click(object sender, EventArgs e)
        {
            ExitMain.Visible = false;
            var frmT = new FormTickets();
            openChild(frmT);
            frmT.Txt_Pedido.Focus();
            HideSubmenu();
            Ocultar();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Title2_Click(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (!activo) {
                this.CenterToScreen();
                this.WindowState = FormWindowState.Maximized;
                int alto = this.Height;
                int ancho = this.Width;
                this.WindowState = FormWindowState.Normal;
                this.Width = ancho;
                this.Height = alto-10;
                this.Location = new Point(0,0);
                activo = true;
            }
            else {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(800, 600);
                this.Location = new Point(0, 0);
                activo = false;
                 }
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubPanelInventario);
        }
        private void AnyControl_MouseEnter(object sender, EventArgs e)
        {
            collapseTimer.Stop();
            Mostrar();
        }

        private void AnyControl_MouseLeave(object sender, EventArgs e)
        {
            // Verificar si el mouse está realmente fuera del panel
            Point mousePos = Leftpanel.PointToClient(Cursor.Position);
            if (!Leftpanel.ClientRectangle.Contains(mousePos))
            {
                collapseTimer.Start();
            }
        }
        private void AddMouseEventsRecursive(Control parent)
        {
            parent.MouseEnter += AnyControl_MouseEnter;
            parent.MouseLeave += AnyControl_MouseLeave;

            foreach (Control child in parent.Controls)
            {
                AddMouseEventsRecursive(child); // recursivo para subpaneles
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            AddMouseEventsRecursive(Leftpanel);
        }

        private void BtnAdministrador_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnAdministrador_MouseEnter_1(object sender, EventArgs e)
        {
            BtnAdministrador.ForeColor = System.Drawing.Color.Red;
        }

        private void BtnAdministrador_MouseLeave_1(object sender, EventArgs e)
        {
            BtnAdministrador.ForeColor = System.Drawing.Color.White;
        }

        private void BtnInventario_MouseEnter(object sender, EventArgs e)
        {
            BtnInventario.ForeColor = System.Drawing.Color.Red;
        }

        private void BtnInventario_MouseLeave(object sender, EventArgs e)
        {
            BtnInventario.ForeColor = System.Drawing.Color.White;
        }

        private void Btnpedido_MouseEnter(object sender, EventArgs e)
        {
            Btnpedido.ForeColor = System.Drawing.Color.Red;
        }

        private void Btnpedido_MouseLeave(object sender, EventArgs e)
        {
            Btnpedido.ForeColor = System.Drawing.Color.White;
        }

        private void BtnValidarPedido_MouseEnter(object sender, EventArgs e)
        {
            BtnValidarPedido.ForeColor = System.Drawing.Color.White;
        }

        private void BtnValidarPedido_MouseLeave(object sender, EventArgs e)
        {
            BtnValidarPedido.ForeColor = System.Drawing.Color.Black;
        }

        private void EnviarTicket_MouseEnter(object sender, EventArgs e)
        {
            EnviarTicket.ForeColor = System.Drawing.Color.White;
        }

        private void EnviarTicket_MouseLeave(object sender, EventArgs e)
        {
            EnviarTicket.ForeColor = System.Drawing.Color.Black;
        }

        private void BtnTEntrada_MouseEnter(object sender, EventArgs e)
        {
            BtnTEntrada.ForeColor = System.Drawing.Color.White;
        }

        private void BtnTSalida_MouseEnter(object sender, EventArgs e)
        {
            BtnTSalida.ForeColor = System.Drawing.Color.White;
        }

        private void BtnCEntrada_MouseEnter(object sender, EventArgs e)
        {
            BtnCEntrada.ForeColor = System.Drawing.Color.White;
        }

        private void BtnCSalida_MouseEnter(object sender, EventArgs e)
        {
            BtnCSalida.ForeColor = System.Drawing.Color.White;
        }

        private void BtnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            BtnUsuarios.ForeColor = System.Drawing.Color.White;
        }

        private void BtnRoles_MouseEnter(object sender, EventArgs e)
        {
            BtnRoles.ForeColor = System.Drawing.Color.White;
        }

        private void BtnTEntrada_MouseLeave(object sender, EventArgs e)
        {
            BtnTEntrada.ForeColor = System.Drawing.Color.Black;
        }

        private void BtnTSalida_MouseLeave(object sender, EventArgs e)
        {
            BtnTSalida.ForeColor = System.Drawing.Color.Black;
        }

        private void BtnCEntrada_MouseLeave(object sender, EventArgs e)
        {
            BtnCEntrada.ForeColor = System.Drawing.Color.Black;
        }

        private void BtnCSalida_MouseLeave(object sender, EventArgs e)
        {
            BtnCSalida.ForeColor = System.Drawing.Color.Black;
        }

        private void BtnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            BtnUsuarios.ForeColor = System.Drawing.Color.Black;
        }

        private void BtnRoles_MouseLeave(object sender, EventArgs e)
        {
            BtnRoles.ForeColor = System.Drawing.Color.Black;
        }

        private void BtnCSalida_Click(object sender, EventArgs e)
        {
            ExitMain.Visible = false;
            var frm = new Mesa_de_control.Compra_Salida();
            openChild(frm);
            frm.TxtFolio.Focus();
            HideSubmenu();
            HideSubmenu();
            Ocultar();

        }

        private void BtnCEntrada_Click(object sender, EventArgs e)
        {
            ExitMain.Visible = false;
            var frm = new Mesa_de_control.Compra_Entrada();
            openChild(frm);
            frm.TxtFolio.Focus();
            HideSubmenu();
            HideSubmenu();
            Ocultar();
        }

        private void BtnTSalida_Click(object sender, EventArgs e)
        {
            ExitMain.Visible = false;
            var frm = new Mesa_de_control.Traspaso_Salida();
            openChild(frm);
            frm.TxtFolio.Focus();
            HideSubmenu();
            HideSubmenu();
            Ocultar();
        }

        private void BtnTEntrada_Click(object sender, EventArgs e)
        {
            ExitMain.Visible = false;
            var frm = new Mesa_de_control.Traspaso_Entrada();
            openChild(frm);
            frm.TxtFolio.Focus();
            HideSubmenu();
            HideSubmenu();
            Ocultar();
        }
    }
}
