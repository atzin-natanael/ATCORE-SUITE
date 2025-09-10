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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATCORE_SUITE.ChildForms
{
    public partial class AddUser : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public AddUser()
        {
            InitializeComponent();
            Cargar();
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
                db.Dispose();
            }
            
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Usuario.Text) && !string.IsNullOrEmpty(TxtPw.Text) && !string.IsNullOrEmpty(TxtPw2.Text))
            {
                // Verificar que las contraseñas coincidan
                if (TxtPw.Text == TxtPw2.Text)
                {
                    // Cifrar la contraseña antes de almacenarla
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(TxtPw.Text);

                    // Abrir la base de datos
                    using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
                    {
                        var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                        // Verificar si el nombre de usuario ya existe
                        var existingUser = usuarios.FindOne(x => x.UsuarioName == Txt_Usuario.Text);

                        if (existingUser == null)
                        {
                            // Contar el número de usuarios existentes para determinar el próximo ID
                            int nextUserId = usuarios.Count() + 1;  // El próximo ID será el total de usuarios + 1
                            var lastIdUser = usuarios.FindOne(x => x.Id == nextUserId);
                            int siguiente = int.Parse(lastIdUser.Id.ToString()) + 1;
                            // Crear un nuevo usuario con el ID calculado
                            AdminUsuario nuevoUsuario = new AdminUsuario
                            {
                                Id = siguiente,  // Asignar el próximo ID
                                UsuarioName = Txt_Usuario.Text,
                                Password = hashedPassword,
                                Rol = Cb_Rol.Text // Asignamos el rol seleccionado
                            };

                            // Insertar el nuevo usuario en la base de datos
                            usuarios.Insert(nuevoUsuario);

                            MessageBox.Show("Usuario agregado exitosamente");
                            db.Dispose();
                            this.Close();
                        }
                        else
                        {
                            // Si el usuario ya existe
                            MessageBox.Show("El nombre de usuario ya está registrado.");
                            db.Dispose();
                        }
                    }
                }
                else
                {
                    // Si las contraseñas no coinciden
                    MessageBox.Show("Las contraseñas no coinciden.");
                    TxtPw.Clear();
                    TxtPw2.Clear();
                    TxtPw.Focus();
                }
            }
            else
            {
                // Si alguno de los campos está vacío o el rol no está seleccionado
                MessageBox.Show("Por favor complete todos los campos y seleccione un rol.");
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                TxtPw2.Focus();
            }
        }

        private void TxtPw2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Cb_Rol.Focus();
            }
        }

        private void Cb_Rol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Enter.Focus();
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
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
