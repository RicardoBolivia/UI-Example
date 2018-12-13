namespace UIGranosYMas
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbOpociones = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.subMenuBuscar = new System.Windows.Forms.Panel();
            this.GBBUS = new System.Windows.Forms.GroupBox();
            this.busNom = new System.Windows.Forms.RadioButton();
            this.busNit = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btbEliminar = new System.Windows.Forms.Button();
            this.btbBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbOpociones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.subMenuBuscar.SuspendLayout();
            this.GBBUS.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 425F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 630);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(927, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 419);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbOpociones, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbDatos, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(927, 169);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // gbOpociones
            // 
            this.gbOpociones.Controls.Add(this.refresh);
            this.gbOpociones.Controls.Add(this.subMenuBuscar);
            this.gbOpociones.Controls.Add(this.btnNuevo);
            this.gbOpociones.Controls.Add(this.btnEditar);
            this.gbOpociones.Controls.Add(this.btbEliminar);
            this.gbOpociones.Controls.Add(this.btbBuscar);
            this.gbOpociones.Controls.Add(this.btnAgregar);
            this.gbOpociones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOpociones.Font = new System.Drawing.Font("Verdana Pro Cond Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpociones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.gbOpociones.Location = new System.Drawing.Point(466, 3);
            this.gbOpociones.Name = "gbOpociones";
            this.gbOpociones.Size = new System.Drawing.Size(458, 163);
            this.gbOpociones.TabIndex = 3;
            this.gbOpociones.TabStop = false;
            this.gbOpociones.Text = "Opciones";
            // 
            // refresh
            // 
            this.refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::UIGranosYMas.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(429, 17);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(23, 21);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 17;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // subMenuBuscar
            // 
            this.subMenuBuscar.Controls.Add(this.GBBUS);
            this.subMenuBuscar.Location = new System.Drawing.Point(266, 82);
            this.subMenuBuscar.Name = "subMenuBuscar";
            this.subMenuBuscar.Size = new System.Drawing.Size(186, 84);
            this.subMenuBuscar.TabIndex = 16;
            this.subMenuBuscar.Visible = false;
            // 
            // GBBUS
            // 
            this.GBBUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.GBBUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GBBUS.Controls.Add(this.busNom);
            this.GBBUS.Controls.Add(this.busNit);
            this.GBBUS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBBUS.Font = new System.Drawing.Font("Verdana Pro Cond Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.GBBUS.ForeColor = System.Drawing.Color.White;
            this.GBBUS.Location = new System.Drawing.Point(0, 0);
            this.GBBUS.Name = "GBBUS";
            this.GBBUS.Size = new System.Drawing.Size(186, 84);
            this.GBBUS.TabIndex = 0;
            this.GBBUS.TabStop = false;
            this.GBBUS.Text = "Buscar por:";
            // 
            // busNom
            // 
            this.busNom.AutoSize = true;
            this.busNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.busNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.busNom.ForeColor = System.Drawing.Color.White;
            this.busNom.Location = new System.Drawing.Point(7, 51);
            this.busNom.Name = "busNom";
            this.busNom.Size = new System.Drawing.Size(77, 21);
            this.busNom.TabIndex = 1;
            this.busNom.TabStop = true;
            this.busNom.Text = "Nombre";
            this.busNom.UseVisualStyleBackColor = true;
            this.busNom.Click += new System.EventHandler(this.busNom_Click);
            // 
            // busNit
            // 
            this.busNit.AutoSize = true;
            this.busNit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.busNit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.busNit.ForeColor = System.Drawing.Color.White;
            this.busNit.Location = new System.Drawing.Point(7, 24);
            this.busNit.Name = "busNit";
            this.busNit.Size = new System.Drawing.Size(44, 21);
            this.busNit.TabIndex = 0;
            this.busNit.TabStop = true;
            this.busNit.Text = "Nit";
            this.busNit.UseVisualStyleBackColor = true;
            this.busNit.Click += new System.EventHandler(this.busNit_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Image = global::UIGranosYMas.Properties.Resources.add_button_icon_icons;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(6, 44);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(212, 38);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = global::UIGranosYMas.Properties.Resources.refresh;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(240, 103);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(212, 38);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btbEliminar
            // 
            this.btbEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.btbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbEliminar.FlatAppearance.BorderSize = 0;
            this.btbEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btbEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btbEliminar.Image = global::UIGranosYMas.Properties.Resources.delete;
            this.btbEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbEliminar.Location = new System.Drawing.Point(6, 103);
            this.btbEliminar.Name = "btbEliminar";
            this.btbEliminar.Size = new System.Drawing.Size(212, 38);
            this.btbEliminar.TabIndex = 13;
            this.btbEliminar.Text = "Eliminar";
            this.btbEliminar.UseVisualStyleBackColor = false;
            this.btbEliminar.Click += new System.EventHandler(this.btbEliminar_Click);
            // 
            // btbBuscar
            // 
            this.btbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.btbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbBuscar.FlatAppearance.BorderSize = 0;
            this.btbBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btbBuscar.Image = global::UIGranosYMas.Properties.Resources.buscar;
            this.btbBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbBuscar.Location = new System.Drawing.Point(240, 44);
            this.btbBuscar.Name = "btbBuscar";
            this.btbBuscar.Size = new System.Drawing.Size(212, 38);
            this.btbBuscar.TabIndex = 12;
            this.btbBuscar.Text = "Buscar";
            this.btbBuscar.UseVisualStyleBackColor = false;
            this.btbBuscar.Click += new System.EventHandler(this.btbBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Image = global::UIGranosYMas.Properties.Resources.add_button_icon_icons;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(6, 44);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(212, 38);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtNit);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Enabled = false;
            this.gbDatos.Font = new System.Drawing.Font("Verdana Pro Cond Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.gbDatos.Location = new System.Drawing.Point(3, 3);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(457, 163);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(98, 67);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(167, 31);
            this.txtNit.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 31);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(933, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbOpociones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.subMenuBuscar.ResumeLayout(false);
            this.GBBUS.ResumeLayout(false);
            this.GBBUS.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbOpociones;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Panel subMenuBuscar;
        private System.Windows.Forms.GroupBox GBBUS;
        private System.Windows.Forms.RadioButton busNom;
        private System.Windows.Forms.RadioButton busNit;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btbEliminar;
        private System.Windows.Forms.Button btbBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}