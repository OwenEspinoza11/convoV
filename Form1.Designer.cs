namespace ccvp1
{
    partial class frmSalarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.mtxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.mtxtAingreso = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IR = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año-Ingreso";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(47, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(793, 251);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(171, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 6;
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.Location = new System.Drawing.Point(171, 161);
            this.mtxtSalario.Mask = "000000000000000000";
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(100, 23);
            this.mtxtSalario.TabIndex = 7;
            // 
            // mtxtAingreso
            // 
            this.mtxtAingreso.Location = new System.Drawing.Point(171, 215);
            this.mtxtAingreso.Mask = "0000";
            this.mtxtAingreso.Name = "mtxtAingreso";
            this.mtxtAingreso.Size = new System.Drawing.Size(100, 23);
            this.mtxtAingreso.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(398, 72);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(398, 132);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(765, 641);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(398, 282);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(668, 49);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 23);
            this.txtAntiguedad.TabIndex = 13;
            // 
            // txtInss
            // 
            this.txtInss.Location = new System.Drawing.Point(668, 119);
            this.txtInss.Name = "txtInss";
            this.txtInss.Size = new System.Drawing.Size(100, 23);
            this.txtInss.TabIndex = 14;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(668, 188);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(100, 23);
            this.txtIR.TabIndex = 15;
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(668, 258);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(100, 23);
            this.txtNeto.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Antiguedad por";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Inss";
            // 
            // IR
            // 
            this.IR.AutoSize = true;
            this.IR.Location = new System.Drawing.Point(594, 191);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(17, 15);
            this.IR.TabIndex = 19;
            this.IR.Text = "IR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Neto";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Salario";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Antiguedad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Inss";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "IR";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Neto";
            this.Column8.Name = "Column8";
            // 
            // frmSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 676);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.txtInss);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mtxtAingreso);
            this.Controls.Add(this.mtxtSalario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalarios";
            this.Text = "Calcular salarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private MaskedTextBox mtxtSalario;
        private MaskedTextBox mtxtAingreso;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private TextBox txtAntiguedad;
        private TextBox txtInss;
        private TextBox txtIR;
        private TextBox txtNeto;
        private Label label5;
        private Label label6;
        private Label IR;
        private Label label8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}