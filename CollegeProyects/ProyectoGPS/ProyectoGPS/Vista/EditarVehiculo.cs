using ProyectoGPS.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGPS.Vista
{
    public partial class EditarVehiculo : Form
    {
        public EditarVehiculo(DataGridViewRow row)
        {
            InitializeComponent();
            txtmatricula.Text = row.Cells[0].Value.ToString();
            txtmarca.Text = row.Cells[1].Value.ToString(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VehiculosCL oVehiculosCl = new VehiculosCL();
            oVehiculosCl.EditarVehiculo( txtmatricula.Text,txtmarca.Text);
            if (oVehiculosCl.IsError)
            {
                MessageBox.Show(oVehiculosCl.ErrorDescripcion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vehiculo Editado", "Inforamcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
