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
    public partial class FormAdminUsuarios : Form
    {
        public FormAdminUsuarios()
        {
            InitializeComponent();
            CargarUsers();
            Design();
        }
        public void CargarUsers()
        {
            using (var db = new LiteDatabase(GlobalSettings.Instance.PathConfig + "USUARIOS_TRASPASOS.db"))
            {
                var usuarios = db.GetCollection<AdminUsuario>("USUARIOS");
                // Obtener todos los usuarios de la base de datos
                var listaUsuarios = usuarios.FindAll();
                // Crear un array o lista para almacenar los nombres de usuario
                List<string> nombresArray = new List<string>();
                // Llenar el array con los nombres de usuario
                foreach (var usuario in listaUsuarios)
                {
                    //nombresArray.Add(usuario.UsuarioName);
                    TablaUsuarios.Rows.Add(usuario.Id, usuario.UsuarioName, usuario.Rol);
                }

            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void Design()
        {
            SubpanelMenu.Visible = false;
        }
        public void HideSubmenu()
        {
            if (SubpanelMenu.Visible == true)
            {
                SubpanelMenu.Visible = false;
            }
        }
        public void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void BtnMen_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(SubpanelMenu);
        }

        private void SubpanelMenu_Resize(object sender, EventArgs e)
        {
            BtnAddUser.Width = SubpanelMenu.Width / 5;
            BtnChangeName.Width = SubpanelMenu.Width / 5;
            BtnDeleteUser.Width = SubpanelMenu.Width / 5;
            BtnEditRol.Width = SubpanelMenu.Width / 5;
            BtnChangePassword.Width = SubpanelMenu.Width / 5;
        }

        private void BtnDeleteUser_MouseEnter(object sender, EventArgs e)
        {
            //BtnDeleteUser.ForeColor = System.Drawing.Color.White;
        }
    }
}
