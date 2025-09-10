using LiteDB;
using ATCORE_SUITE.ChildClases;
using ATCORE_SUITE;
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
    public partial class ChangePw : Form
    {
        string UsuarioModificado = string.Empty;
        public ChangePw(string user)
        {
            InitializeComponent();
            UsuarioModificado = user;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (TxtPw.Text != string.Empty && Txt_Usuario.Text != string.Empty)
            {
                using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
                {

                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario que coincida con el nombre de usuario ingresado
                    var usuario = usuarios.FindOne(x => x.UsuarioName == UsuarioModificado);  // Asegúrate de que el campo sea el nombre de usuario
                    if (LbPw.Text == "Confirmar")
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(TxtPw.Text);
                        usuario.Password = hashedPassword;
                        usuarios.Update(usuario);
                        MessageBox.Show("Contraseña cambiada con éxito");
                        db.Dispose();
                        this.Close();
                        return;
                    }
                    if (usuario != null)
                    {
                        var usuarioAdmin = usuarios.FindOne(x => x.UsuarioName == Txt_Usuario.Text);  // Asegúrate de que el campo sea el nombre de usuario
                        // Comprobar si la contraseña ingresada coincide con el hash almacenado
                        bool isMatch = BCrypt.Net.BCrypt.Verify(TxtPw.Text, usuarioAdmin.Password);

                        if (isMatch && usuarioAdmin.Rol == "ADMINISTRADOR")
                        {
                            TxtPw.Text = string.Empty;
                            Txt_Usuario.Text = string.Empty;
                            Txt_Usuario.CharacterCasing = CharacterCasing.Normal;
                            Txt_Usuario.UseSystemPasswordChar = true;
                            LbUser.Text = "Nueva Contrasena";
                            LbPw.Text = "Confirmar";
                            Enter.Text = "Cambiar";
                            Txt_Usuario.Focus();
                            Lb_Title.Text = "Administrando " + UsuarioModificado;
                        }
                        else if (!isMatch)
                        {
                            MessageBox.Show("Contrasena Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            db.Dispose();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        TxtPw.Focus();
                        TxtPw.Select(0, TxtPw.TextLength);
                        db.Dispose();
                    }
                }

            }
        }

        private void Txt_Usuario_KeyDown(object sender, KeyEventArgs e)
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
                Enter_Click(sender, e);
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

        private void Lb_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTop_MouseDown_1(object sender, MouseEventArgs e)
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
    }
}

