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
            double cantidad, precio, total, subtotal;

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre");
                txtNombre.Focus();
            }
            else if (mtxtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad");
                mtxtCantidad.Focus();
            }
            else if (mtxtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio");
                mtxtCantidad.Focus();

            }
            else if (treeView1.SelectedNode.Text == "")
            {
                MessageBox.Show("Seleccione una rama");
            }
            else
            {
                cantidad = double.Parse(mtxtCantidad.Text);
                precio = double.Parse(mtxtPrecio.Text);
                
                if (cantidad > 0 || cantidad <= 15)
                {
                    if (precio != 0 || precio <= 65000)
                    {
                        if (treeView1.SelectedNode.Text.Equals("Cordoba"))
                        {
                            subtotal = precio * cantidad;
                            
                            txtSubtotal.Text = subtotal.ToString();
                        }
                        else if (treeView1.SelectedNode.Text.Equals("Dolar"))
                        {
                            subtotal = (precio * cantidad) * 36.5;

                            txtSubtotal.Text = subtotal.ToString();
                        }
                        if (treeView1.SelectedNode.Text.Equals("Credito"))
                        {
                            subtotal = precio * cantidad;

                            txtSubtotal.Text = subtotal.ToString();
                        }
                    }
                }

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();


                row.Cells[0].Value = txtNombre.Text;
                row.Cells[1].Value = mtxtCantidad.Text;
                row.Cells[2].Value = mtxtPrecio.Text;
                row.Cells[3].Value = txtSubtotal.Text;
                
                dataGridView1.Rows.Add(row);

                double stf;

                stf = subtotal;

                total = double.Parse(textBox2.Text);

                total = subtotal;

                
            }
        }

        private void btnPAgar_Click(object sender, EventArgs e)
        {
            double  vuelto, monto;

            monto = double.Parse(mtxtPago.Text);
            vuelto = monto - total;

            textBox4.Text = vuelto.ToString();
        }
    }
}
