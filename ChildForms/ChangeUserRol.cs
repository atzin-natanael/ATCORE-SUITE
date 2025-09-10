using ATCORE_SUITE.ChildClases;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;
using LiteDB;
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

namespace ATCORE_SUITE.ChildForms
{
    public partial class ChangeUserRol : Form
    {
        public ChangeUserRol(string Usuario)
        {
            InitializeComponent();
            Cargar();
            Txt_Usuario.Text = Usuario;
            Cb_Rol.SelectedIndex = 0; // Inicialmente no se selecciona ningún rol
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Cargar()
        {
            using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
            {
                var coleccion = db.GetCollection<AdminRoles>("ROLES");
                var listaRoles = coleccion.FindAll().Select(r => r.RolNombre).ToList();

                Cb_Rol.Items.Clear(); // Limpia primero
                Cb_Rol.Items.AddRange(listaRoles.ToArray());
            }
        }
        private void Enter_Click(object sender, EventArgs e)
        {

            using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
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
                    db.Dispose();
                }
            }

        }

        private void Cb_Rol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter.Focus();
            }
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

        private void panelTop_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
