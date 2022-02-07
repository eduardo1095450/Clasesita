namespace Clase1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.registrar = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.sueldo = new System.Windows.Forms.Label();
            this.empleado = new System.Windows.Forms.CheckBox();
            this.persona = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(459, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 144);
            this.listBox1.TabIndex = 0;
            // 
            // registrar
            // 
            this.registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.Location = new System.Drawing.Point(582, 385);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(131, 53);
            this.registrar.TabIndex = 1;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(38, 71);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(168, 33);
            this.registro.TabIndex = 2;
            this.registro.Text = "REGISTRO:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(103, 162);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(95, 29);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre:";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(103, 213);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(64, 29);
            this.edad.TabIndex = 4;
            this.edad.Text = "Edad:";
            // 
            // sueldo
            // 
            this.sueldo.AutoSize = true;
            this.sueldo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldo.Location = new System.Drawing.Point(103, 268);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(85, 29);
            this.sueldo.TabIndex = 5;
            this.sueldo.Text = "Sueldo:";
            // 
            // empleado
            // 
            this.empleado.AutoSize = true;
            this.empleado.Location = new System.Drawing.Point(459, 135);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(192, 24);
            this.empleado.TabIndex = 6;
            this.empleado.Text = "Ver dato de empleado";
            this.empleado.UseVisualStyleBackColor = true;
            // 
            // persona
            // 
            this.persona.AutoSize = true;
            this.persona.Location = new System.Drawing.Point(459, 79);
            this.persona.Name = "persona";
            this.persona.Size = new System.Drawing.Size(188, 24);
            this.persona.TabIndex = 7;
            this.persona.Text = "Ver datos de persona";
            this.persona.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(670, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 106);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 26);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 26);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(204, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 26);
            this.textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.persona);
            this.Controls.Add(this.empleado);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label registro;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label sueldo;
        private System.Windows.Forms.CheckBox empleado;
        private System.Windows.Forms.CheckBox persona;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

