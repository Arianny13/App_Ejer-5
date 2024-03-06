namespace Ejer_5
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
            this.btn_Distribuir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Emergencia = new System.Windows.Forms.Label();
            this.lbl_Cirugia = new System.Windows.Forms.Label();
            this.lbl_Suministros = new System.Windows.Forms.Label();
            this.lbl_Administracion = new System.Windows.Forms.Label();
            this.lbl_Laboratorio = new System.Windows.Forms.Label();
            this.lbl_Imagenes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Emergencia = new System.Windows.Forms.TextBox();
            this.txt_Cirugia = new System.Windows.Forms.TextBox();
            this.txt_Suministros = new System.Windows.Forms.TextBox();
            this.txt_Administracion = new System.Windows.Forms.TextBox();
            this.txt_Laboratorio = new System.Windows.Forms.TextBox();
            this.txt_Imagenes = new System.Windows.Forms.TextBox();
            this.txt_Presupuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Distribuir
            // 
            this.btn_Distribuir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Distribuir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Distribuir.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Distribuir.Location = new System.Drawing.Point(108, 389);
            this.btn_Distribuir.Name = "btn_Distribuir";
            this.btn_Distribuir.Size = new System.Drawing.Size(95, 40);
            this.btn_Distribuir.TabIndex = 0;
            this.btn_Distribuir.Text = "Distribuir";
            this.btn_Distribuir.UseVisualStyleBackColor = false;
            this.btn_Distribuir.Click += new System.EventHandler(this.btn_Distribuir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpiar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(259, 389);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(95, 40);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpiar ";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(409, 389);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(95, 40);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Emergencia
            // 
            this.lbl_Emergencia.AutoSize = true;
            this.lbl_Emergencia.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emergencia.Location = new System.Drawing.Point(94, 113);
            this.lbl_Emergencia.Name = "lbl_Emergencia";
            this.lbl_Emergencia.Size = new System.Drawing.Size(92, 18);
            this.lbl_Emergencia.TabIndex = 3;
            this.lbl_Emergencia.Text = "Emergencia";
            // 
            // lbl_Cirugia
            // 
            this.lbl_Cirugia.AutoSize = true;
            this.lbl_Cirugia.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cirugia.Location = new System.Drawing.Point(94, 146);
            this.lbl_Cirugia.Name = "lbl_Cirugia";
            this.lbl_Cirugia.Size = new System.Drawing.Size(61, 18);
            this.lbl_Cirugia.TabIndex = 4;
            this.lbl_Cirugia.Text = "Cirugia";
            // 
            // lbl_Suministros
            // 
            this.lbl_Suministros.AutoSize = true;
            this.lbl_Suministros.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Suministros.Location = new System.Drawing.Point(92, 180);
            this.lbl_Suministros.Name = "lbl_Suministros";
            this.lbl_Suministros.Size = new System.Drawing.Size(92, 18);
            this.lbl_Suministros.TabIndex = 5;
            this.lbl_Suministros.Text = "Suministros";
            // 
            // lbl_Administracion
            // 
            this.lbl_Administracion.AutoSize = true;
            this.lbl_Administracion.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Administracion.Location = new System.Drawing.Point(92, 214);
            this.lbl_Administracion.Name = "lbl_Administracion";
            this.lbl_Administracion.Size = new System.Drawing.Size(118, 18);
            this.lbl_Administracion.TabIndex = 6;
            this.lbl_Administracion.Text = "Administracion";
            // 
            // lbl_Laboratorio
            // 
            this.lbl_Laboratorio.AutoSize = true;
            this.lbl_Laboratorio.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Laboratorio.Location = new System.Drawing.Point(92, 250);
            this.lbl_Laboratorio.Name = "lbl_Laboratorio";
            this.lbl_Laboratorio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Laboratorio.Size = new System.Drawing.Size(92, 18);
            this.lbl_Laboratorio.TabIndex = 7;
            this.lbl_Laboratorio.Text = "Laboratorio";
            // 
            // lbl_Imagenes
            // 
            this.lbl_Imagenes.AutoSize = true;
            this.lbl_Imagenes.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Imagenes.Location = new System.Drawing.Point(92, 281);
            this.lbl_Imagenes.Name = "lbl_Imagenes";
            this.lbl_Imagenes.Size = new System.Drawing.Size(76, 18);
            this.lbl_Imagenes.TabIndex = 8;
            this.lbl_Imagenes.Text = "Imagenes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Presupuesto";
            // 
            // txt_Emergencia
            // 
            this.txt_Emergencia.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Emergencia.Location = new System.Drawing.Point(244, 110);
            this.txt_Emergencia.Name = "txt_Emergencia";
            this.txt_Emergencia.Size = new System.Drawing.Size(249, 26);
            this.txt_Emergencia.TabIndex = 10;
            // 
            // txt_Cirugia
            // 
            this.txt_Cirugia.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cirugia.Location = new System.Drawing.Point(244, 143);
            this.txt_Cirugia.Name = "txt_Cirugia";
            this.txt_Cirugia.Size = new System.Drawing.Size(249, 26);
            this.txt_Cirugia.TabIndex = 11;
            // 
            // txt_Suministros
            // 
            this.txt_Suministros.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Suministros.Location = new System.Drawing.Point(244, 176);
            this.txt_Suministros.Name = "txt_Suministros";
            this.txt_Suministros.Size = new System.Drawing.Size(249, 26);
            this.txt_Suministros.TabIndex = 12;
            // 
            // txt_Administracion
            // 
            this.txt_Administracion.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Administracion.Location = new System.Drawing.Point(244, 211);
            this.txt_Administracion.Name = "txt_Administracion";
            this.txt_Administracion.Size = new System.Drawing.Size(249, 26);
            this.txt_Administracion.TabIndex = 13;
            // 
            // txt_Laboratorio
            // 
            this.txt_Laboratorio.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Laboratorio.Location = new System.Drawing.Point(244, 247);
            this.txt_Laboratorio.Name = "txt_Laboratorio";
            this.txt_Laboratorio.Size = new System.Drawing.Size(249, 26);
            this.txt_Laboratorio.TabIndex = 14;
            // 
            // txt_Imagenes
            // 
            this.txt_Imagenes.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Imagenes.Location = new System.Drawing.Point(244, 280);
            this.txt_Imagenes.Name = "txt_Imagenes";
            this.txt_Imagenes.Size = new System.Drawing.Size(249, 26);
            this.txt_Imagenes.TabIndex = 15;
            // 
            // txt_Presupuesto
            // 
            this.txt_Presupuesto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Presupuesto.Location = new System.Drawing.Point(244, 313);
            this.txt_Presupuesto.Name = "txt_Presupuesto";
            this.txt_Presupuesto.Size = new System.Drawing.Size(249, 26);
            this.txt_Presupuesto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Distribicion de Presupuesto Hospitalareo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Presupuesto);
            this.Controls.Add(this.txt_Imagenes);
            this.Controls.Add(this.txt_Laboratorio);
            this.Controls.Add(this.txt_Administracion);
            this.Controls.Add(this.txt_Suministros);
            this.Controls.Add(this.txt_Cirugia);
            this.Controls.Add(this.txt_Emergencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Imagenes);
            this.Controls.Add(this.lbl_Laboratorio);
            this.Controls.Add(this.lbl_Administracion);
            this.Controls.Add(this.lbl_Suministros);
            this.Controls.Add(this.lbl_Cirugia);
            this.Controls.Add(this.lbl_Emergencia);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Distribuir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Distribuir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Emergencia;
        private System.Windows.Forms.Label lbl_Cirugia;
        private System.Windows.Forms.Label lbl_Suministros;
        private System.Windows.Forms.Label lbl_Administracion;
        private System.Windows.Forms.Label lbl_Laboratorio;
        private System.Windows.Forms.Label lbl_Imagenes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Emergencia;
        private System.Windows.Forms.TextBox txt_Cirugia;
        private System.Windows.Forms.TextBox txt_Suministros;
        private System.Windows.Forms.TextBox txt_Administracion;
        private System.Windows.Forms.TextBox txt_Laboratorio;
        private System.Windows.Forms.TextBox txt_Imagenes;
        private System.Windows.Forms.TextBox txt_Presupuesto;
        private System.Windows.Forms.Label label1;
    }
}

