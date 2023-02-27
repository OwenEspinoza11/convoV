namespace ccvp1
{
    public partial class frmSalarios : Form
    {
        public frmSalarios()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text,
                apellido = txtApellido.Text;

            double salario, añoIng, ant, inss, ir, neto, antPOR;

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre");
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese su apellido");
                txtApellido.Focus();
            }
            else if (mtxtSalario.Text == "")
            {
                MessageBox.Show("Ingrese su salario");
                mtxtSalario.Focus();
            }
            else if (mtxtAingreso.Text == "")
            {
                MessageBox.Show("Ingrese su apellido");
                mtxtAingreso.Focus();
            }
            else
            {
                salario = double.Parse(mtxtSalario.Text);
                añoIng = double.Parse(mtxtAingreso.Text);

                if (salario < 4000 || salario > 500000)
                {
                    MessageBox.Show("Ingrese un valor dentro del rango");
                }
                else
                {
                    if (añoIng < 1964 || añoIng > 2023)
                    {
                        MessageBox.Show("Ingrese un año dentro del rango");
                    }
                    else
                    {
                        inss = salario * 0.07;
                        txtInss.Text = inss.ToString();

                        ant = 2023 - añoIng;
                        antPOR = ((2 * ant) + 1) / 100;
                        salario = salario + antPOR;
                        salario = (salario - inss) * 12;

                        txtAntiguedad.Text = antPOR.ToString();

                        if (salario >= 5000 || salario < 1000)
                        {
                            ir = 0;
                            txtIR.Text = ir.ToString();
                            neto = salario - ir;

                            txtNeto.Text = neto.ToString();
                        }
                        else if (salario >= 100000 || salario <= 200000)
                        {
                            ir = (salario - 100000);
                            ir = ir * 0.10;
                            ir = ir - 5000;

                            txtIR.Text = ir.ToString();
                            neto = salario - ir;

                            txtNeto.Text = neto.ToString();
                        }
                        else if (salario > 200000 || salario <= 300000)
                        {
                            ir = (salario - 200000);
                            ir = ir * 0.15;
                            ir = ir - 10000;

                            txtIR.Text = ir.ToString();
                            neto = salario - ir;

                            txtNeto.Text = neto.ToString();
                        }
                        else if (salario >= 300001 || salario <= 400000)
                        {
                            ir = (salario - 300000);
                            ir = ir * 0.20;
                            ir = ir - 15000;

                            txtIR.Text = ir.ToString();
                            neto = salario - ir;

                            txtNeto.Text = neto.ToString();
                        }
                        else if (salario >= 400001)
                        {
                            ir = (salario - 350000);
                            ir = ir * 0.20;
                            ir = ir - 20000;

                            txtIR.Text = ir.ToString();
                            neto = salario - ir;

                            txtNeto.Text = neto.ToString();
                        }



                    }

                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            mtxtAingreso.Clear();
            mtxtSalario.Clear();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre");
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese su apellido");
                txtApellido.Focus();
            }
            else if (mtxtSalario.Text == "")
            {
                MessageBox.Show("Ingrese su salario");
                mtxtSalario.Focus();
            }
            else if (mtxtAingreso.Text == "")
            {
                MessageBox.Show("Ingrese su apellido");
                mtxtAingreso.Focus();
            }
            else
            {
                int n;


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                }

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();


                row.Cells[0].Value = txtNombre.Text;
                row.Cells[1].Value = txtApellido.Text;
                row.Cells[2].Value = mtxtSalario.Text;
                row.Cells[3].Value = txtAntiguedad.Text;
                row.Cells[4].Value = txtInss.Text;
                row.Cells[5].Value = txtIR.Text;
                row.Cells[6].Value = txtNeto.Text;
                


                dataGridView1.Rows.Add(row);

            }
        }
    }
}