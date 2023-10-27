namespace TrabajoFinal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.practicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelbtnACS = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.panelbtncrud = new System.Windows.Forms.Panel();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.paneldatos = new System.Windows.Forms.Panel();
            this.panelgrillas = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panelbtnACS.SuspendLayout();
            this.panelbtncrud.SuspendLayout();
            this.panelgrillas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 53);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLight;

            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);

            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem1,
            this.ingresosToolStripMenuItem1,
            this.practicasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";

            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);

            this.menuStrip2.Size = new System.Drawing.Size(675, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";

            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(69, 22);
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);

            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            // 
            // ingresosToolStripMenuItem1
            // 
            this.ingresosToolStripMenuItem1.Name = "ingresosToolStripMenuItem1";

            this.ingresosToolStripMenuItem1.Size = new System.Drawing.Size(63, 22);

            this.ingresosToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);

            this.ingresosToolStripMenuItem1.Text = "Ingresos";
            // 
            // practicasToolStripMenuItem
            // 
            this.practicasToolStripMenuItem.Name = "practicasToolStripMenuItem";

            this.practicasToolStripMenuItem.Size = new System.Drawing.Size(80, 22);

            this.practicasToolStripMenuItem.Size = new System.Drawing.Size(80, 20);

            this.practicasToolStripMenuItem.Text = "Laboratorio";
            // 
            // panelbtnACS
            // 
            this.panelbtnACS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelbtnACS.Controls.Add(this.btnsalir);
            this.panelbtnACS.Controls.Add(this.btncancelar);
            this.panelbtnACS.Controls.Add(this.btnaceptar);
            this.panelbtnACS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbtnACS.Location = new System.Drawing.Point(0, 391);
            this.panelbtnACS.Name = "panelbtnACS";
            this.panelbtnACS.Size = new System.Drawing.Size(675, 59);
            this.panelbtnACS.TabIndex = 1;
            // 
            // btnsalir
            // 

            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));


            this.btnsalir.Location = new System.Drawing.Point(572, 18);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 

            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));

            this.btncancelar.Location = new System.Drawing.Point(481, 18);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 

            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));

            this.btnaceptar.Location = new System.Drawing.Point(386, 18);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // panelbtncrud
            // 
            this.panelbtncrud.BackColor = System.Drawing.Color.Silver;
            this.panelbtncrud.Controls.Add(this.btnmodificar);
            this.panelbtncrud.Controls.Add(this.btneliminar);
            this.panelbtncrud.Controls.Add(this.btnagregar);
            this.panelbtncrud.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelbtncrud.Location = new System.Drawing.Point(0, 53);
            this.panelbtncrud.Name = "panelbtncrud";
            this.panelbtncrud.Size = new System.Drawing.Size(134, 338);
            this.panelbtncrud.TabIndex = 2;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(12, 80);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(12, 127);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 

            this.btnagregar.BackColor = System.Drawing.Color.SkyBlue;

            this.btnagregar.Location = new System.Drawing.Point(12, 30);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";

            this.btnagregar.UseVisualStyleBackColor = false;

            this.btnagregar.UseVisualStyleBackColor = true;

            // 
            // paneldatos
            // 
            this.paneldatos.Dock = System.Windows.Forms.DockStyle.Right;

            this.paneldatos.Location = new System.Drawing.Point(506, 53);
            this.paneldatos.Name = "paneldatos";
            this.paneldatos.Size = new System.Drawing.Size(169, 338);

            this.paneldatos.Location = new System.Drawing.Point(541, 53);
            this.paneldatos.Name = "paneldatos";
            this.paneldatos.Size = new System.Drawing.Size(134, 338);

            this.paneldatos.TabIndex = 3;
            // 
            // panelgrillas
            // 
            this.panelgrillas.Controls.Add(this.dataGridView1);
            this.panelgrillas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgrillas.Location = new System.Drawing.Point(134, 53);
            this.panelgrillas.Name = "panelgrillas";

            this.panelgrillas.Size = new System.Drawing.Size(372, 338);
            this.panelgrillas.Size = new System.Drawing.Size(407, 338);

            this.panelgrillas.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";

            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(372, 338);

            this.dataGridView1.Size = new System.Drawing.Size(407, 338);

            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.panelgrillas);
            this.Controls.Add(this.paneldatos);
            this.Controls.Add(this.panelbtncrud);
            this.Controls.Add(this.panelbtnACS);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Laboratorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelbtnACS.ResumeLayout(false);
            this.panelbtncrud.ResumeLayout(false);
            this.panelgrillas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelbtnACS;
        private System.Windows.Forms.Panel panelbtncrud;
        private System.Windows.Forms.Panel paneldatos;
        private System.Windows.Forms.Panel panelgrillas;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem practicasToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

