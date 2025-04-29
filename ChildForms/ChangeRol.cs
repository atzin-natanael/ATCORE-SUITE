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
    public partial class ChangeRol : Form
    {
        public ChangeRol(string Usuario)
        {
            InitializeComponent();
            Txt_Usuario.Text = Usuario;
            Cb_Rol.SelectedIndex = 0; // Inicialmente no se selecciona ningún rol
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Cb_Rol.SelectedIndex != 0)
            {
                using (var db = new LiteDatabase("C:\\ConfigDB\\USUARIOS_TRASPASOS.db"))
                {
                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario en la base de datos por su ID
                    var usuarioAEditar = usuarios.FindOne(u => u.UsuarioName == Txt_Usuario.Text);

                    if (usuarioAEditar != null)
                    {
                        // Eliminar el usuario de la base de datos
                        usuarioAEditar.Rol = Cb_Rol.Text; // Cambiar el rol
                        usuarios.Update(usuarioAEditar);
                        MessageBox.Show("Rol cambiado exitosamente.");
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
                MessageBox.Show("Seleccione un rol");
            }
        }

        private void Cb_Rol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter.Focus();
            }
        }
    }
}
