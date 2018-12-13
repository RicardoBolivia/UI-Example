namespace UIGranosYMas
{
    partial class NotasDeEntregraUI
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
            this.gbOpociones = new System.Windows.Forms.GroupBox();
            this.dtCliente = new System.Windows.Forms.DataGridView();
            this.subMenuBuscar = new System.Windows.Forms.Panel();
            this.GBBUS = new System.Windows.Forms.GroupBox();
            this.busNot = new System.Windows.Forms.RadioButton();
            this.busCliente = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btbEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btbBuscar = new System.Windows.Forms.Button();
            this.dtNotas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbOpociones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
            this.subMenuBuscar.SuspendLayout();
            this.GBBUS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbOpociones, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Nombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtNotas, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.583756F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.56684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.01862F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 591);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gbOpociones
            // 
            this.gbOpociones.Controls.Add(this.dtCliente);
            this.gbOpociones.Controls.Add(this.refresh);
            this.gbOpociones.Controls.Add(this.subMenuBuscar);
            this.gbOpociones.Controls.Add(this.btnNuevo);
            this.gbOpociones.Controls.Add(this.btnVer);
            this.gbOpociones.Controls.Add(this.btbEliminar);
            this.gbOpociones.Controls.Add(this.btnAgregar);
            this.gbOpociones.Controls.Add(this.btbBuscar);
            this.gbOpociones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOpociones.Font = new System.Drawing.Font("Verdana Pro Cond Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpociones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.gbOpociones.Location = new System.Drawing.Point(3, 35);
            this.gbOpociones.Name = "gbOpociones";
            this.gbOpociones.Size = new System.Drawing.Size(911, 85);
            this.gbOpociones.TabIndex = 4;
            this.gbOpociones.TabStop = false;
            this.gbOpociones.Text = "Opciones";
            // 
            // dtCliente
            // 
            this.dtCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCliente.Location = new System.Drawing.Point(6, 149);
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.Size = new System.Drawing.Size(20, 17);
            this.dtCliente.TabIndex = 18;
            this.dtCliente.Visible = false;
            // 
            // subMenuBuscar
            // 
            this.subMenuBuscar.Controls.Add(this.GBBUS);
            this.subMenuBuscar.Location = new System.Drawing.Point(274, 0);
            this.subMenuBuscar.Name = "subMenuBuscar";
            this.subMenuBuscar.Size = new System.Drawing.Size(186, 84);
            this.subMenuBuscar.TabIndex = 16;
            this.subMenuBuscar.Visible = false;
            // 
            // GBBUS
            // 
            this.GBBUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.GBBUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GBBUS.Controls.Add(this.busNot);
            this.GBBUS.Controls.Add(this.busCliente);
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
            // busNot
            // 
            this.busNot.AutoSize = true;
            this.busNot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.busNot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.busNot.ForeColor = System.Drawing.Color.White;
            this.busNot.Location = new System.Drawing.Point(6, 23);
            this.busNot.Name = "busNot";
            this.busNot.Size = new System.Drawing.Size(56, 21);
            this.busNot.TabIndex = 1;
            this.busNot.TabStop = true;
            this.busNot.Text = "Nota";
            this.busNot.UseVisualStyleBackColor = true;
            this.busNot.CheckedChanged += new System.EventHandler(this.busNot_CheckedChanged);
            // 
            // busCliente
            // 
            this.busCliente.AutoSize = true;
            this.busCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.busCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.busCliente.ForeColor = System.Drawing.Color.White;
            this.busCliente.Location = new System.Drawing.Point(6, 51);
            this.busCliente.Name = "busCliente";
            this.busCliente.Size = new System.Drawing.Size(71, 21);
            this.busCliente.TabIndex = 0;
            this.busCliente.TabStop = true;
            this.busCliente.Text = "Cliente";
            this.busCliente.UseVisualStyleBackColor = true;
            this.busCliente.CheckedChanged += new System.EventHandler(this.busNot_CheckedChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nombre.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.Nombre.Location = new System.Drawing.Point(3, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(911, 32);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "NOTAS DE ENTREGA";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refresh
            // 
            this.refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::UIGranosYMas.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(878, 44);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(27, 38);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 17;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
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
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVer.Image = global::UIGranosYMas.Properties.Resources.eye;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(442, 44);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(212, 41);
            this.btnVer.TabIndex = 14;
            this.btnVer.Text = "Visualizar";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
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
            this.btbEliminar.Location = new System.Drawing.Point(660, 44);
            this.btbEliminar.Name = "btbEliminar";
            this.btbEliminar.Size = new System.Drawing.Size(212, 38);
            this.btbEliminar.TabIndex = 13;
            this.btbEliminar.Text = "Eliminar";
            this.btbEliminar.UseVisualStyleBackColor = false;
            this.btbEliminar.Click += new System.EventHandler(this.btbEliminar_Click);
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
            this.btbBuscar.Location = new System.Drawing.Point(224, 44);
            this.btbBuscar.Name = "btbBuscar";
            this.btbBuscar.Size = new System.Drawing.Size(212, 38);
            this.btbBuscar.TabIndex = 12;
            this.btbBuscar.Text = "Buscar";
            this.btbBuscar.UseVisualStyleBackColor = false;
            this.btbBuscar.Click += new System.EventHandler(this.btbBuscar_Click);
            // 
            // dtNotas
            // 
            this.dtNotas.AllowUserToAddRows = false;
            this.dtNotas.AllowUserToDeleteRows = false;
            this.dtNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtNotas.Location = new System.Drawing.Point(3, 126);
            this.dtNotas.Name = "dtNotas";
            this.dtNotas.ReadOnly = true;
            this.dtNotas.Size = new System.Drawing.Size(911, 462);
            this.dtNotas.TabIndex = 5;
            // 
            // NotasDeEntregraUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(917, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasDeEntregraUI";
            this.Text = "NotasDeEntregraUI";
            this.Load += new System.EventHandler(this.NotasDeEntregraUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbOpociones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
            this.subMenuBuscar.ResumeLayout(false);
            this.GBBUS.ResumeLayout(false);
            this.GBBUS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.GroupBox gbOpociones;
        private System.Windows.Forms.DataGridView dtCliente;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Panel subMenuBuscar;
        private System.Windows.Forms.GroupBox GBBUS;
        private System.Windows.Forms.RadioButton busNot;
        private System.Windows.Forms.RadioButton busCliente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btbEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btbBuscar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView dtNotas;
    }
}