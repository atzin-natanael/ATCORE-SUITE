using ATCORE_SUITE.ChildClases;
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
    public partial class Menu : Form
    {
        public delegate void EnviarVariableDelegate(decimal cantidad, int id);
        public event EnviarVariableDelegate EnviarVariableEvent;
        public Menu()
        {
            InitializeComponent();
        }
        public void FuncionRecibir(string codigo, string descripcion, decimal solicitado, decimal recibido, int id, string Nota)
        {
            LbCodigo.Text = codigo + " - " + descripcion;
            LbSolicitado.Text = solicitado.ToString();
            LbRecibido.Text = recibido.ToString();
            Lb_Nota.Text = Nota.ToString();
            if (recibido > solicitado)
                LbRecibido.BackColor = Color.Red;
            LbPendiente.Text = (solicitado - recibido).ToString();
            if (solicitado - recibido < 0)
                LbPendiente.Text = "0";
            Cantidad.Value = GlobalSettings.Instance.Contenido;
            Cantidad.Select(0, Cantidad.Value.ToString().Length);
            Cantidad.Focus();
            GlobalSettings.Instance.Id = id;
        }
        private void Cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal mul = Cantidad.Value;
                EnviarVariableEvent(Cantidad.Value, GlobalSettings.Instance.Id);
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
