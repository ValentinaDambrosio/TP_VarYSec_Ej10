namespace TP_VarYSec_Ej10
{
    partial class fSalario
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.bSalario = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lIngreso = new System.Windows.Forms.Label();
            this.tIngreso = new System.Windows.Forms.TextBox();
            this.lTarifaHoraria = new System.Windows.Forms.Label();
            this.tTarifa = new System.Windows.Forms.TextBox();
            this.lCantHoras = new System.Windows.Forms.Label();
            this.tCantHoras = new System.Windows.Forms.TextBox();
            this.lCantDias = new System.Windows.Forms.Label();
            this.tCantDias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(425, 284);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bSalario
            // 
            this.bSalario.Location = new System.Drawing.Point(344, 284);
            this.bSalario.Name = "bSalario";
            this.bSalario.Size = new System.Drawing.Size(75, 23);
            this.bSalario.TabIndex = 1;
            this.bSalario.Text = "Salario";
            this.bSalario.UseVisualStyleBackColor = true;
            this.bSalario.Click += new System.EventHandler(this.bSalario_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(96, 55);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(157, 48);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(155, 20);
            this.tNombre.TabIndex = 3;
            // 
            // lIngreso
            // 
            this.lIngreso.AutoSize = true;
            this.lIngreso.Location = new System.Drawing.Point(62, 82);
            this.lIngreso.Name = "lIngreso";
            this.lIngreso.Size = new System.Drawing.Size(81, 13);
            this.lIngreso.TabIndex = 4;
            this.lIngreso.Text = "Año de ingreso:";
            // 
            // tIngreso
            // 
            this.tIngreso.Location = new System.Drawing.Point(157, 79);
            this.tIngreso.Name = "tIngreso";
            this.tIngreso.Size = new System.Drawing.Size(70, 20);
            this.tIngreso.TabIndex = 5;
            // 
            // lTarifaHoraria
            // 
            this.lTarifaHoraria.AutoSize = true;
            this.lTarifaHoraria.Location = new System.Drawing.Point(71, 112);
            this.lTarifaHoraria.Name = "lTarifaHoraria";
            this.lTarifaHoraria.Size = new System.Drawing.Size(72, 13);
            this.lTarifaHoraria.TabIndex = 6;
            this.lTarifaHoraria.Text = "Tarifa horaria:";
            // 
            // tTarifa
            // 
            this.tTarifa.Location = new System.Drawing.Point(157, 109);
            this.tTarifa.Name = "tTarifa";
            this.tTarifa.Size = new System.Drawing.Size(70, 20);
            this.tTarifa.TabIndex = 7;
            // 
            // lCantHoras
            // 
            this.lCantHoras.AutoSize = true;
            this.lCantHoras.Location = new System.Drawing.Point(10, 142);
            this.lCantHoras.Name = "lCantHoras";
            this.lCantHoras.Size = new System.Drawing.Size(133, 13);
            this.lCantHoras.TabIndex = 8;
            this.lCantHoras.Text = "Cantidad de horas por día:";
            // 
            // tCantHoras
            // 
            this.tCantHoras.Location = new System.Drawing.Point(157, 139);
            this.tCantHoras.Name = "tCantHoras";
            this.tCantHoras.Size = new System.Drawing.Size(70, 20);
            this.tCantHoras.TabIndex = 9;
            // 
            // lCantDias
            // 
            this.lCantDias.AutoSize = true;
            this.lCantDias.Location = new System.Drawing.Point(12, 171);
            this.lCantDias.Name = "lCantDias";
            this.lCantDias.Size = new System.Drawing.Size(131, 13);
            this.lCantDias.TabIndex = 10;
            this.lCantDias.Text = "Cantidad de días por mes:";
            // 
            // tCantDias
            // 
            this.tCantDias.Location = new System.Drawing.Point(157, 168);
            this.tCantDias.Name = "tCantDias";
            this.tCantDias.Size = new System.Drawing.Size(70, 20);
            this.tCantDias.TabIndex = 11;
            // 
            // fSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 316);
            this.Controls.Add(this.tCantDias);
            this.Controls.Add(this.lCantDias);
            this.Controls.Add(this.tCantHoras);
            this.Controls.Add(this.lCantHoras);
            this.Controls.Add(this.tTarifa);
            this.Controls.Add(this.lTarifaHoraria);
            this.Controls.Add(this.tIngreso);
            this.Controls.Add(this.lIngreso);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bSalario);
            this.Controls.Add(this.bCerrar);
            this.Name = "fSalario";
            this.Text = "Salario del mes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bSalario;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label lIngreso;
        private System.Windows.Forms.TextBox tIngreso;
        private System.Windows.Forms.Label lTarifaHoraria;
        private System.Windows.Forms.TextBox tTarifa;
        private System.Windows.Forms.Label lCantHoras;
        private System.Windows.Forms.TextBox tCantHoras;
        private System.Windows.Forms.Label lCantDias;
        private System.Windows.Forms.TextBox tCantDias;
    }
}

