using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo1_Com2
{
    public partial class HabitacionSimple : Form
    {
        public HabitacionSimple()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new Habitaciones();
            formulario.Show();
            this.Hide();
        }
    }
}
