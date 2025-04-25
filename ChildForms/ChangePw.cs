using LiteDB;
using PedidoXperto.ChildClases;
using ProyectoXperto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidoXperto.ChildForms
{
    public partial class ChangePw : Form
    {
        public ChangePw()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (TxtPw.Text != string.Empty && Cb_Usuario.Text != string.Empty)
            {
                using (var db = new LiteDatabase("C:\\ConfigDB\\USUARIOS_TRASPASOS.db"))
                {

                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario que coincida con el nombre de usuario ingresado
                    var usuario = usuarios.FindOne(x => x.UsuarioName == Cb_Usuario.Text);  // Asegúrate de que el campo sea el nombre de usuario

                    if (usuario != null)
                    {
                        // Comprobar si la contraseña ingresada coincide con el hash almacenado
                        bool isMatch = BCrypt.Net.BCrypt.Verify(TxtPw.Text, usuario.Password);

                        if (isMatch && usuario.Rol == "Administrador")
                        {
                            TxtPw.Text = string.Empty;
                            Cb_Usuario.Visible = false;
                            TxtPw2.Visible = true;
                            LbUser.Text = "Contrasena";
                            LbPw.Text = "Confirmar";
                            Enter.Text = "Cambiar";
                            TxtPw2.Focus();
                        }
                        else
                        {
                            MessageBox.Show("El usuario debe ser administrador", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            TxtPw.Focus();
                            TxtPw.Select(0, TxtPw.TextLength);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        TxtPw.Focus();
                        TxtPw.Select(0, TxtPw.TextLength);
                    }
                }

            }
        }
    }
}
