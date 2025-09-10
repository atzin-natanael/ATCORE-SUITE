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
    public partial class ControlAcceso : Form
    {
        public delegate void EnviarVariableDelegate3();
        public event EnviarVariableDelegate3 EnviarVariableEvent3;
        public ControlAcceso()
        {
            InitializeComponent();
            LeerUsuarios();
        }
        public void LeerUsuarios()
        {
            using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
            {
                var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");
                var listaUsuarios = usuarios.FindAll().ToList();
                if (listaUsuarios.Count > 0)
                {
                    Cb_Usuario.DataSource = listaUsuarios;
                    Cb_Usuario.DisplayMember = "UsuarioName"; // Asegúrate de que este campo exista en tu clase AdminUsuario
                    Cb_Usuario.ValueMember = "Id"; // Asegúrate de que este campo exista en tu clase AdminUsuario
                    Cb_Usuario.AutoCompleteMode = AutoCompleteMode.Append;
                    Cb_Usuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    Cb_Usuario.AutoCompleteCustomSource.AddRange(listaUsuarios.Select(u => u.UsuarioName).ToArray());
                }
                else
                {
                    MessageBox.Show("No hay usuarios registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ForgetPw_Click(object sender, EventArgs e)
        {
            string existUser = null;
            if (Cb_Usuario.Text != string.Empty)
                existUser = ValidarUsuario();
            else
            {
                MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (existUser == null)
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChangePw changePw = new ChangePw(existUser);
            changePw.ShowDialog();
        }
        public string ValidarUsuario()
        {
            if (Cb_Usuario.Text != string.Empty)
            {
                using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
                {

                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario que coincida con el nombre de usuario ingresado
                    var usuario = usuarios.FindOne(x => x.UsuarioName == Cb_Usuario.Text);  // Asegúrate de que el campo sea el nombre de usuario

                    if (usuario != null)
                    {
                        db.Dispose();
                        return usuario.UsuarioName;
                    }
                    else
                    {
                        db.Dispose();
                        return null;
                    }
                }

            }
            else
            {
                return null;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Cb_Usuario.Text) && !string.IsNullOrWhiteSpace(TxtPw.Text))
            {
                using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
                {
                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");
                    var usuario = usuarios.FindOne(x => x.UsuarioName == Cb_Usuario.Text);

                    if (usuario != null)
                    {
                        bool isMatch = BCrypt.Net.BCrypt.Verify(TxtPw.Text, usuario.Password);

                        // Lista de roles permitidos
                        var rolesPermitidos = new List<string> { "INVENTARIOS", "ADMINISTRADOR", "JEFE FACTURISTA" };

                        if (isMatch)
                        {
                            if (rolesPermitidos.Contains(usuario.Rol.ToUpper()))
                            {
                                MessageBox.Show("Autorizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GlobalSettings.Instance.aceptado = true;
                                GlobalSettings.Instance.Usuario = usuario.UsuarioName;
                                EnviarVariableEvent3();
                                db.Dispose();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No tiene permisos suficientes.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                db.Dispose();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            db.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        db.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPw.Focus();
                TxtPw.Select(0, TxtPw.TextLength);
            }
        }

        private void TxtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_Click(sender, e);
            }
        }

        private void Cb_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
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

        private void Enter_MouseEnter(object sender, EventArgs e)
        {
            Enter.ForeColor = Color.Yellow;
        }

        private void Enter_MouseLeave(object sender, EventArgs e)
        {
            Enter.ForeColor = Color.White;
        }
    }
}
