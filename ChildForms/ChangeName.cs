using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using PedidoXperto.ChildClases;

namespace PedidoXperto.ChildForms
{
    public partial class ChangeName : Form
    {
        public ChangeName(string Usuario)
        {
            InitializeComponent();
            Txt_Usuario.Text = Usuario;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Txt_Usuario2.Text != string.Empty)
            {
                using (var db = new LiteDatabase("C:\\ConfigDB\\USUARIOS_TRASPASOS.db"))
                {
                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario en la base de datos por su ID
                    var usuarioAEditar = usuarios.FindOne(u => u.UsuarioName == Txt_Usuario.Text);

                    if (usuarioAEditar != null)
                    {
                        // Eliminar el usuario de la base de datos
                        usuarioAEditar.UsuarioName = Txt_Usuario2.Text; // Cambiar el rol
                        usuarios.Update(usuarioAEditar);
                        MessageBox.Show("Nombre cambiado exitosamente.");
                        db.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario en la base de datos.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Usuario2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter.Focus();
            }
        }
    }
}
