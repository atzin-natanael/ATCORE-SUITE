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
using DocumentFormat.OpenXml.Math;
using LiteDB;
using Org.BouncyCastle.Crypto.Generators;
using PedidoXperto.ChildClases;
using ProyectoXperto;

namespace PedidoXperto.ChildForms
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void ForgetPw_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
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
                            this.Hide();
                            db.Dispose();
                            MainForm Main = new MainForm();
                            Main.LbUsuario.Text = "Bienvenido " + usuario.UsuarioName;
                            Main.ShowDialog();
                        }
                        else if (isMatch && usuario.Rol != "Administrador")
                        {
                            this.Close();
                            db.Dispose();
                            MainForm Main = new MainForm();
                            Main.LbUsuario.Text = "Bienvenido " + usuario.UsuarioName;
                            Main.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
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

        private void Cb_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TxtPw.Focus();
            }
        }

        private void TxtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Enter.Focus();
            }
        }

        private void Cb_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
