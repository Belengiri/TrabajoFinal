﻿namespace TrabajoFinal
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnpaciente = new System.Windows.Forms.Button();
            this.btningresos = new System.Windows.Forms.Button();
            this.btnlaboratorio = new System.Windows.Forms.Button();
            this.btnlocalidades = new System.Windows.Forms.Button();
            this.btnpersonalmedico = new System.Windows.Forms.Button();
            this.btnpersonallaboratorio = new System.Windows.Forms.Button();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnespecialidades = new System.Windows.Forms.Button();
            this.btnpracticas = new System.Windows.Forms.Button();
            this.btnpersonalporespecialidad = new System.Windows.Forms.Button();
            this.btnpracticasporespecialidad = new System.Windows.Forms.Button();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelmenu.Controls.Add(this.btnpracticasporespecialidad);
            this.panelmenu.Controls.Add(this.btnpersonalporespecialidad);
            this.panelmenu.Controls.Add(this.btnpracticas);
            this.panelmenu.Controls.Add(this.btnespecialidades);
            this.panelmenu.Controls.Add(this.btncategorias);
            this.panelmenu.Controls.Add(this.btnpersonallaboratorio);
            this.panelmenu.Controls.Add(this.btnpersonalmedico);
            this.panelmenu.Controls.Add(this.btnlocalidades);
            this.panelmenu.Controls.Add(this.btnlaboratorio);
            this.panelmenu.Controls.Add(this.btningresos);
            this.panelmenu.Controls.Add(this.lbltitulo);
            this.panelmenu.Controls.Add(this.btnpaciente);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(200, 462);
            this.panelmenu.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(26, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(149, 31);
            this.lbltitulo.TabIndex = 13;
            this.lbltitulo.Text = "Laboratorio";
            // 
            // btnpaciente
            // 
            this.btnpaciente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpaciente.FlatAppearance.BorderSize = 2;
            this.btnpaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpaciente.Location = new System.Drawing.Point(13, 55);
            this.btnpaciente.Name = "btnpaciente";
            this.btnpaciente.Size = new System.Drawing.Size(160, 23);
            this.btnpaciente.TabIndex = 12;
            this.btnpaciente.Text = "Paciente";
            this.btnpaciente.UseVisualStyleBackColor = true;
            // 
            // btningresos
            // 
            this.btningresos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningresos.FlatAppearance.BorderSize = 2;
            this.btningresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btningresos.Location = new System.Drawing.Point(15, 84);
            this.btningresos.Name = "btningresos";
            this.btningresos.Size = new System.Drawing.Size(160, 23);
            this.btningresos.TabIndex = 14;
            this.btningresos.Text = "Ingresos";
            this.btningresos.UseVisualStyleBackColor = true;
            // 
            // btnlaboratorio
            // 
            this.btnlaboratorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlaboratorio.FlatAppearance.BorderSize = 2;
            this.btnlaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlaboratorio.Location = new System.Drawing.Point(15, 113);
            this.btnlaboratorio.Name = "btnlaboratorio";
            this.btnlaboratorio.Size = new System.Drawing.Size(160, 23);
            this.btnlaboratorio.TabIndex = 15;
            this.btnlaboratorio.Text = "Laboratorio";
            this.btnlaboratorio.UseVisualStyleBackColor = true;
            // 
            // btnlocalidades
            // 
            this.btnlocalidades.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlocalidades.FlatAppearance.BorderSize = 2;
            this.btnlocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlocalidades.Location = new System.Drawing.Point(55, 142);
            this.btnlocalidades.Name = "btnlocalidades";
            this.btnlocalidades.Size = new System.Drawing.Size(120, 23);
            this.btnlocalidades.TabIndex = 16;
            this.btnlocalidades.Text = "Localidades";
            this.btnlocalidades.UseVisualStyleBackColor = true;
            this.btnlocalidades.Visible = false;
            // 
            // btnpersonalmedico
            // 
            this.btnpersonalmedico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpersonalmedico.FlatAppearance.BorderSize = 2;
            this.btnpersonalmedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpersonalmedico.Location = new System.Drawing.Point(55, 171);
            this.btnpersonalmedico.Name = "btnpersonalmedico";
            this.btnpersonalmedico.Size = new System.Drawing.Size(120, 23);
            this.btnpersonalmedico.TabIndex = 17;
            this.btnpersonalmedico.Text = "Personal Medico";
            this.btnpersonalmedico.UseVisualStyleBackColor = true;
            this.btnpersonalmedico.Visible = false;
            // 
            // btnpersonallaboratorio
            // 
            this.btnpersonallaboratorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpersonallaboratorio.FlatAppearance.BorderSize = 2;
            this.btnpersonallaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpersonallaboratorio.Location = new System.Drawing.Point(55, 200);
            this.btnpersonallaboratorio.Name = "btnpersonallaboratorio";
            this.btnpersonallaboratorio.Size = new System.Drawing.Size(120, 23);
            this.btnpersonallaboratorio.TabIndex = 18;
            this.btnpersonallaboratorio.Text = "Personal Laboratorio";
            this.btnpersonallaboratorio.UseVisualStyleBackColor = true;
            this.btnpersonallaboratorio.Visible = false;
            // 
            // btncategorias
            // 
            this.btncategorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncategorias.FlatAppearance.BorderSize = 2;
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncategorias.Location = new System.Drawing.Point(55, 229);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(120, 23);
            this.btncategorias.TabIndex = 19;
            this.btncategorias.Text = "Categorias";
            this.btncategorias.UseVisualStyleBackColor = true;
            this.btncategorias.Visible = false;
            // 
            // btnespecialidades
            // 
            this.btnespecialidades.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnespecialidades.FlatAppearance.BorderSize = 2;
            this.btnespecialidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnespecialidades.Location = new System.Drawing.Point(55, 258);
            this.btnespecialidades.Name = "btnespecialidades";
            this.btnespecialidades.Size = new System.Drawing.Size(120, 23);
            this.btnespecialidades.TabIndex = 20;
            this.btnespecialidades.Text = "Especialidades";
            this.btnespecialidades.UseVisualStyleBackColor = true;
            this.btnespecialidades.Visible = false;
            // 
            // btnpracticas
            // 
            this.btnpracticas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpracticas.FlatAppearance.BorderSize = 2;
            this.btnpracticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpracticas.Location = new System.Drawing.Point(55, 287);
            this.btnpracticas.Name = "btnpracticas";
            this.btnpracticas.Size = new System.Drawing.Size(120, 23);
            this.btnpracticas.TabIndex = 21;
            this.btnpracticas.Text = "Practicas";
            this.btnpracticas.UseVisualStyleBackColor = true;
            this.btnpracticas.Visible = false;
            // 
            // btnpersonalporespecialidad
            // 
            this.btnpersonalporespecialidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpersonalporespecialidad.FlatAppearance.BorderSize = 2;
            this.btnpersonalporespecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpersonalporespecialidad.Location = new System.Drawing.Point(33, 316);
            this.btnpersonalporespecialidad.Name = "btnpersonalporespecialidad";
            this.btnpersonalporespecialidad.Size = new System.Drawing.Size(142, 23);
            this.btnpersonalporespecialidad.TabIndex = 22;
            this.btnpersonalporespecialidad.Text = "Personal por Especialidad";
            this.btnpersonalporespecialidad.UseVisualStyleBackColor = true;
            this.btnpersonalporespecialidad.Visible = false;
            // 
            // btnpracticasporespecialidad
            // 
            this.btnpracticasporespecialidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnpracticasporespecialidad.FlatAppearance.BorderSize = 2;
            this.btnpracticasporespecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpracticasporespecialidad.Location = new System.Drawing.Point(33, 345);
            this.btnpracticasporespecialidad.Name = "btnpracticasporespecialidad";
            this.btnpracticasporespecialidad.Size = new System.Drawing.Size(142, 23);
            this.btnpracticasporespecialidad.TabIndex = 23;
            this.btnpracticasporespecialidad.Text = "Practicas por Especialidad";
            this.btnpracticasporespecialidad.UseVisualStyleBackColor = true;
            this.btnpracticasporespecialidad.Visible = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(200, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(497, 462);
            this.panelcontenedor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 462);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panelmenu);
            this.Name = "Form1";
            this.Text = "Laboratorio";
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btnpracticasporespecialidad;
        private System.Windows.Forms.Button btnpersonalporespecialidad;
        private System.Windows.Forms.Button btnpracticas;
        private System.Windows.Forms.Button btnespecialidades;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btnpersonallaboratorio;
        private System.Windows.Forms.Button btnpersonalmedico;
        private System.Windows.Forms.Button btnlocalidades;
        private System.Windows.Forms.Button btnlaboratorio;
        private System.Windows.Forms.Button btningresos;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnpaciente;
        private System.Windows.Forms.Panel panelcontenedor;
    }
}

