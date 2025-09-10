using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using ATCORE_SUITE.ChildClases;

namespace ATCORE_SUITE.ChildForms
{
    public partial class ChangeNameRol : Form
    {
        public ChangeNameRol(string Name)
        {
            InitializeComponent();
            Txt_Rol.Text = Name;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Txt_Rol2.Text != string.Empty)
            {
                using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
                {
                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");
                    var usuariosConRol = usuarios.Find(u => u.Rol == Txt_Rol.Text);

                    int contador = 0;

                    foreach (var usuario in usuariosConRol)
                    {
                        usuario.Rol = Txt_Rol2.Text;
                        usuarios.Update(usuario);
                        contador++;
                    }

                    if (contador > 0)
                    {
                        MessageBox.Show($"Rol actualizado en {contador} usuario(s).");
                    }
                }
                using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
                {
                    var usuarios = db.GetCollection<AdminRoles>("ROLES");

                    // Buscar el usuario en la base de datos por su ID
                    var usuarioAEditar = usuarios.FindOne(u => u.RolNombre == Txt_Rol.Text);

                    if (usuarioAEditar != null)
                    {
                        // Eliminar el usuario de la base de datos
                        usuarioAEditar.RolNombre = Txt_Rol2.Text; // Cambiar el rol
                        usuarios.Update(usuarioAEditar);
                        db.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario en la base de datos.");
                        db.Dispose();
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


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTop_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Enter_MouseEnter(object sender, EventArgs e)
        {
            Enter.ForeColor = System.Drawing.Color.Yellow;
        }

        private void Enter_MouseLeave(object sender, EventArgs e)
        {
            Enter.ForeColor = System.Drawing.Color.White;
        }
    }
}
