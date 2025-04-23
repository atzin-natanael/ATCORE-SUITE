using PedidoXperto.ChildForms;

namespace ProyectoXperto
{
    public partial class PedidoXperto : Form
    {
        public PedidoXperto()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(49, 46, 178);
            Design();
        }

        private void Btnpedido_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubpanelMenuPedido);
        }
        public void Design()
        {
            SubpanelMenuPedido.Visible = false;
            SubPanelMenuAdmin.Visible = false;
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
                Hide.Text = ">";
            }
        }

        private void Btnpedido_MouseClick(object sender, MouseEventArgs e)
        {
            Btnpedido.ForeColor = Color.FromArgb(49, 46, 178);
        }
        private void Btnpedido_MouseEnter(object sender, EventArgs e)
        {
            Btnpedido.ForeColor = Color.WhiteSmoke;
            Mostrar();
        }

        private void Btnpedido_MouseLeave(object sender, EventArgs e)
        {
            Btnpedido.ForeColor = Color.WhiteSmoke;
        }

        private void Btnpedido_MouseDown(object sender, MouseEventArgs e)
        {
            //Btnpedido.ForeColor = Color.Red;
        }

        private void Leftpanel_MouseLeave(object sender, EventArgs e)
        {
            collapseTimer.Start();
        }

        private void Leftpanel_MouseEnter(object sender, EventArgs e)
        {
            collapseTimer.Stop();

            Mostrar();
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
            // Si el mouse REALMENTE está fuera del panel y sus hijos, colapsamos
            if (!Leftpanel.Bounds.Contains(PointToClient(Cursor.Position)))
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
                foreach(Control ctrl in SubPanelMenuAdmin.Controls)
                {
                    if (ctrl is Button)
                        ctrl.Visible = false;
                }
                Hide.Text = ">";
            }
            if (!MouseEstaDentroDelPanel())
            {
                Ocultar();
            }
            collapseTimer.Stop();
        }
        private Form activeForm = null;
        private void openChild(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
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
        private void BtnValidarPedido_Click(object sender, EventArgs e)
        {
            openChild(new FormValidarPedido());
            HideSubmenu();
            Ocultar();
        }

        private void BtnNuevoPedido_Click(object sender, EventArgs e)
        {
            openChild(new FormCrearPedido());
            HideSubmenu();
            Ocultar();
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubPanelMenuAdmin);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            openChild(new FormAdminUsuarios());
            HideSubmenu();
            Ocultar();
        }
    }
}
