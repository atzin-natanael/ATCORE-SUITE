using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidoXperto.ChildForms
{
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
            Btn_Aceptar.Focus();
        }
        public void setmensaje(string mensaje, string valor)
        {
            if (valor == "ubicacion")
                lbltitulo.Text = "ubicación";
            else if (valor == "ubicacion2")
            {
                lbltitulo.Text = "ubicación";
                //label1.location = new point(70, 54);
            }
            else if (valor == "nota")
            {
                lbltitulo.Text = "nota";
            }
            else if (valor == "nota2")
            {
                lbltitulo.Text = "nota";
                //label1.location = new point(83, 54);
            }
            else if (valor == "existencia")
                lbltitulo.Text = "existencia";
            richTextBox1.Text = mensaje;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
