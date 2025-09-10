using ATCORE_SUITE;
using ATCORE_SUITE.ChildClases;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Spreadsheet;
using LiteDB;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Crypto.Generators;
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
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public void LoadConfig()
        {
            string filePath = GlobalSettings.Instance.PathConfig + "DB.txt"; // Ruta de tu archivo de texto
            List<string> lineas = new List<string>();

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                // Leer todas las líneas del archivo
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string linea;
                    GlobalSettings.Instance.Config = new List<string>();
                    while ((linea = sr.ReadLine()) != null)
                    {
                        GlobalSettings.Instance.Config.Add(linea);
                    }

                }
                GlobalSettings.Instance.Ip = GlobalSettings.Instance.Config[0];
                GlobalSettings.Instance.Puerto = GlobalSettings.Instance.Config[1];
                GlobalSettings.Instance.Direccion = GlobalSettings.Instance.Config[2];
                GlobalSettings.Instance.User = GlobalSettings.Instance.Config[3];
                GlobalSettings.Instance.Pw = GlobalSettings.Instance.Config[4];
                GlobalSettings.Instance.LastUser = GlobalSettings.Instance.Config[5];
                GlobalSettings.Instance.StringConnectionCloud = GlobalSettings.Instance.Config[6];
                GlobalSettings.Instance.StringConnection =
                    "User=" + GlobalSettings.Instance.User + ";" +
                    "Password=" + GlobalSettings.Instance.Pw + ";" +
                    "Database=" + GlobalSettings.Instance.Direccion + ";" +
                    "DataSource=" + GlobalSettings.Instance.Ip + ";" +
                    "Port=" + GlobalSettings.Instance.Puerto + ";" +
                    "Dialect=3;" +
                    "Charset=UTF8;";
            }
            else
            {
                MessageBox.Show("Archivo de Configuracion no encontrado", "DB.txt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LeerUsuarios()
        {
            if (GlobalSettings.Instance.Ip != "192.168.0.239")
                GlobalSettings.Instance.UsuariosDB = "C:\\ConfigDB\\USUARIOS.db";
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
                db.Dispose();
            }

        }
        public void SendConfig()
        {
            string filePath = GlobalSettings.Instance.PathConfig + "DB.txt"; // Ruta de tu archivo de texto
            //List<string> lineas = new List<string>();

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                // Leer todas las líneas del archivo
                List<string> lineas = File.ReadAllLines(filePath).ToList();

                // Asegúrate de que hay al menos 5 líneas
                while (lineas.Count < 6)
                {
                    lineas.Add(""); // Rellena con líneas vacías si es necesario
                }
                lineas[5] = "";
                lineas[5] = Cb_Usuario.Text; // Línea 5 (índice 4 porque comienza en 0)
                GlobalSettings.Instance.LastUser = lineas[5]; // Actualiza la variable de instancia 

                File.WriteAllLines(filePath, lineas);
            }
            else
            {
                MessageBox.Show("Archivo de configuración no encontrado. Por favor, verifica la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public Login()
        {
            InitializeComponent();
            LoadConfig();
            LeerUsuarios();
            Cb_Usuario.Text = GlobalSettings.Instance.LastUser;
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
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
                Acceder();
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void ForgetPw_MouseEnter(object sender, EventArgs e)
        {
            ForgetPw.ForeColor = System.Drawing.Color.Yellow;
            ForgetPw.Font = new System.Drawing.Font(ForgetPw.Font, FontStyle.Underline);
        }

        private void ForgetPw_MouseLeave(object sender, EventArgs e)
        {
            ForgetPw.ForeColor = System.Drawing.Color.White;
            ForgetPw.Font = new System.Drawing.Font(ForgetPw.Font, FontStyle.Regular);
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        private void Acceder()
        {
            if (TxtPw.Text != string.Empty && Cb_Usuario.Text != string.Empty)
            {
                using (var db = new LiteDatabase(GlobalSettings.Instance.UsuariosDB.ToString()))
                {

                    var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");

                    // Buscar el usuario que coincida con el nombre de usuario ingresado
                    var usuario = usuarios.FindOne(x => x.UsuarioName == Cb_Usuario.Text);
                    var roles = db.GetCollection<AdminRoles>("ROLES");

                    if (usuario != null)
                    {
                        // Comprobar si la contraseña ingresada coincide con el hash almacenado
                        bool isMatch = BCrypt.Net.BCrypt.Verify(TxtPw.Text, usuario.Password);

                        if (isMatch)
                        {
                            var rolActual = roles.FindOne(r => r.RolNombre == usuario.Rol);
                            this.Hide();
                            MainForm Main = new MainForm();
                            Main.BtnValidarPedido.Enabled = false;
                            Main.EnviarTicket.Enabled = false;
                            Main.BtnCEntrada.Enabled = false;
                            Main.BtnCSalida.Enabled = false;
                            Main.BtnTEntrada.Enabled = false;
                            Main.BtnTSalida.Enabled = false;
                            //Main.BtnNuevoPedido.Enabled = false;
                            Main.BtnUsuarios.Enabled = false;
                            Main.BtnRoles.Enabled = false;
                            foreach (var derecho in rolActual.Derechos)
                            {
                                if (derecho == "Validar Pedido" || derecho == "All")
                                {
                                    Main.BtnValidarPedido.Enabled = true;
                                }
                                if (derecho == "Enviar Ticket" || derecho == "All")
                                {
                                    Main.EnviarTicket.Enabled = true;
                                }
                                if (derecho == "Administrador de Usuarios" || derecho == "All")
                                {
                                    Main.BtnUsuarios.Enabled = true;
                                }
                                if (derecho == "Administrador de Roles" || derecho == "All")
                                {
                                    Main.BtnRoles.Enabled = true;
                                }
                                if (derecho == "Inventario" || derecho == "All")
                                {
                                    Main.BtnCEntrada.Enabled = true;
                                    Main.BtnCSalida.Enabled = true;
                                    Main.BtnTEntrada.Enabled = true;
                                    Main.BtnTSalida.Enabled = true;
                                }
                            }
                            db.Dispose();
                            SendConfig();
                            Main.LbUsuario.Text = "Bienvenido " + usuario.UsuarioName;
                            Main.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                            db.Dispose();
                            TxtPw.Focus();
                            TxtPw.Select(0, TxtPw.TextLength);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        db.Dispose();
                        TxtPw.Focus();
                        TxtPw.Select(0, TxtPw.TextLength);
                    }
                    db.Dispose();
                }

            }
        }

        private void Txt_Usuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TxtPw.Focus();
            }
        }

        private void Cb_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void Cb_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TxtPw.Focus();
                TxtPw.Select(0, TxtPw.TextLength);
            }
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
