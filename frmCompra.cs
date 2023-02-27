using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccvp1
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double cantidad, precio, total, subtotal, monto, vuelto;

            if(txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre");
                txtNombre.Focus();
            }
            else if (mtxtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad");
                mtxtCantidad.Focus();
            }
            else if(mtxtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio");
                mtxtCantidad.Focus();

            }
            else
            {


            }
        }
    }
}
