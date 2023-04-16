using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ej10
{
    public partial class fSalario : Form
    {
        public fSalario()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSalario_Click(object sender, EventArgs e)
        {
            double salario = (Convert.ToDouble(tTarifa.Text) * Convert.ToDouble(tCantHoras.Text)) * Convert.ToDouble(tCantDias.Text);
            double retenciones = (salario * 20) / 100;
            double agregado = (2023 - Convert.ToDouble(tIngreso.Text)) * 1.5;
            agregado = (salario * agregado) / 100;
            salario = salario - retenciones;
            salario = salario + agregado;
            MessageBox.Show(tNombre.Text + " su salario es de $" + salario);
        }
    }
}
