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
            mostrarSubmenu(SubpanelMenu);
        }
        public void Design()
        {
            SubpanelMenu.Visible = false;
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
            if (SubpanelMenu.Visible == true)
            {
                SubpanelMenu.Visible = false;
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
             Leftpanel.Size = new Size(Leftpanel.Width, 20);

        }
    }
}
