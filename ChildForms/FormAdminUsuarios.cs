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
        }
        public void CargarUsers()
        {
            using (var db = new LiteDatabase("C:\\ConfigDB\\USUARIOS_TRASPASOS.db"))
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
    }
}
