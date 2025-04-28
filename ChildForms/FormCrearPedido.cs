using PedidoXperto.Logic;

namespace PedidoXperto.ChildForms
{
    public partial class FormCrearPedido : Form
    {
        public FormCrearPedido()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_clienteId_TextChanged(object sender, EventArgs e)
        {
            if (InvalidText())
                return;

            Data bridge = new();

            var data = bridge.GetClientName(txtBox_clienteId.Text);

            if (data == null)
            {
                lblNombreCliente.Text = "Cliente no encontrado";
            }
            else
                lblNombreCliente.Text = data;
        }

        private bool InvalidText()
        {
            var clientId = txtBox_clienteId.Text;
            return string.IsNullOrEmpty(clientId) || clientId.Length < 6;
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
