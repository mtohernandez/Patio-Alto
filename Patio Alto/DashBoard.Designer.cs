
namespace HighGarden
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.dataGrid_vuelos = new System.Windows.Forms.DataGridView();
            this.dataGrid_pasajeros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agregar_vuelos = new System.Windows.Forms.Button();
            this.modificar_vuelos = new System.Windows.Forms.Button();
            this.eliminar_vuelos = new System.Windows.Forms.Button();
            this.agregar_pasajero = new System.Windows.Forms.Button();
            this.modificar_pasajero = new System.Windows.Forms.Button();
            this.eliminar_pasajero = new System.Windows.Forms.Button();
            this.actualizar_vuelos = new System.Windows.Forms.Button();
            this.actualizar_pasajeros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.procesarreclamo_button = new System.Windows.Forms.Button();
            this.Clocklbl = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_vuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_vuelos
            // 
            this.dataGrid_vuelos.AllowUserToAddRows = false;
            this.dataGrid_vuelos.AllowUserToDeleteRows = false;
            this.dataGrid_vuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_vuelos.Location = new System.Drawing.Point(55, 126);
            this.dataGrid_vuelos.Name = "dataGrid_vuelos";
            this.dataGrid_vuelos.ReadOnly = true;
            this.dataGrid_vuelos.RowHeadersWidth = 51;
            this.dataGrid_vuelos.RowTemplate.Height = 24;
            this.dataGrid_vuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_vuelos.Size = new System.Drawing.Size(955, 554);
            this.dataGrid_vuelos.TabIndex = 0;
            // 
            // dataGrid_pasajeros
            // 
            this.dataGrid_pasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_pasajeros.Location = new System.Drawing.Point(1045, 126);
            this.dataGrid_pasajeros.Name = "dataGrid_pasajeros";
            this.dataGrid_pasajeros.ReadOnly = true;
            this.dataGrid_pasajeros.RowHeadersWidth = 51;
            this.dataGrid_pasajeros.RowTemplate.Height = 24;
            this.dataGrid_pasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_pasajeros.Size = new System.Drawing.Size(461, 553);
            this.dataGrid_pasajeros.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label1.Location = new System.Drawing.Point(55, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vuelos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label2.Location = new System.Drawing.Point(1042, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasajeros";
            // 
            // agregar_vuelos
            // 
            this.agregar_vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_vuelos.Location = new System.Drawing.Point(55, 686);
            this.agregar_vuelos.Name = "agregar_vuelos";
            this.agregar_vuelos.Size = new System.Drawing.Size(75, 40);
            this.agregar_vuelos.TabIndex = 4;
            this.agregar_vuelos.Text = "Agregar";
            this.agregar_vuelos.UseVisualStyleBackColor = true;
            this.agregar_vuelos.Click += new System.EventHandler(this.agregar_vuelos_Click);
            // 
            // modificar_vuelos
            // 
            this.modificar_vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_vuelos.Location = new System.Drawing.Point(136, 686);
            this.modificar_vuelos.Name = "modificar_vuelos";
            this.modificar_vuelos.Size = new System.Drawing.Size(82, 40);
            this.modificar_vuelos.TabIndex = 5;
            this.modificar_vuelos.Text = "Modificar";
            this.modificar_vuelos.UseVisualStyleBackColor = true;
            this.modificar_vuelos.Click += new System.EventHandler(this.modificar_vuelos_Click);
            // 
            // eliminar_vuelos
            // 
            this.eliminar_vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_vuelos.Location = new System.Drawing.Point(224, 686);
            this.eliminar_vuelos.Name = "eliminar_vuelos";
            this.eliminar_vuelos.Size = new System.Drawing.Size(75, 40);
            this.eliminar_vuelos.TabIndex = 6;
            this.eliminar_vuelos.Text = "Eliminar";
            this.eliminar_vuelos.UseVisualStyleBackColor = true;
            this.eliminar_vuelos.Click += new System.EventHandler(this.eliminar_vuelos_Click);
            // 
            // agregar_pasajero
            // 
            this.agregar_pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar_pasajero.Location = new System.Drawing.Point(1045, 686);
            this.agregar_pasajero.Name = "agregar_pasajero";
            this.agregar_pasajero.Size = new System.Drawing.Size(75, 40);
            this.agregar_pasajero.TabIndex = 7;
            this.agregar_pasajero.Text = "Agregar";
            this.agregar_pasajero.UseVisualStyleBackColor = true;
            this.agregar_pasajero.Click += new System.EventHandler(this.agregar_pasajero_Click);
            // 
            // modificar_pasajero
            // 
            this.modificar_pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_pasajero.Location = new System.Drawing.Point(1126, 686);
            this.modificar_pasajero.Name = "modificar_pasajero";
            this.modificar_pasajero.Size = new System.Drawing.Size(94, 40);
            this.modificar_pasajero.TabIndex = 8;
            this.modificar_pasajero.Text = "Modificar";
            this.modificar_pasajero.UseVisualStyleBackColor = true;
            this.modificar_pasajero.Click += new System.EventHandler(this.modificar_pasajero_Click);
            // 
            // eliminar_pasajero
            // 
            this.eliminar_pasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar_pasajero.Location = new System.Drawing.Point(1226, 686);
            this.eliminar_pasajero.Name = "eliminar_pasajero";
            this.eliminar_pasajero.Size = new System.Drawing.Size(75, 40);
            this.eliminar_pasajero.TabIndex = 9;
            this.eliminar_pasajero.Text = "Eliminar";
            this.eliminar_pasajero.UseVisualStyleBackColor = true;
            this.eliminar_pasajero.Click += new System.EventHandler(this.eliminar_pasajero_Click);
            // 
            // actualizar_vuelos
            // 
            this.actualizar_vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar_vuelos.Location = new System.Drawing.Point(305, 686);
            this.actualizar_vuelos.Name = "actualizar_vuelos";
            this.actualizar_vuelos.Size = new System.Drawing.Size(92, 40);
            this.actualizar_vuelos.TabIndex = 11;
            this.actualizar_vuelos.Text = "Actualizar";
            this.actualizar_vuelos.UseVisualStyleBackColor = true;
            this.actualizar_vuelos.Click += new System.EventHandler(this.actualizar_vuelos_Click);
            // 
            // actualizar_pasajeros
            // 
            this.actualizar_pasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar_pasajeros.Location = new System.Drawing.Point(1307, 686);
            this.actualizar_pasajeros.Name = "actualizar_pasajeros";
            this.actualizar_pasajeros.Size = new System.Drawing.Size(87, 40);
            this.actualizar_pasajeros.TabIndex = 12;
            this.actualizar_pasajeros.Text = "Actualizar";
            this.actualizar_pasajeros.UseVisualStyleBackColor = true;
            this.actualizar_pasajeros.Click += new System.EventHandler(this.actualizar_pasajeros_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1535, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // procesarreclamo_button
            // 
            this.procesarreclamo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.procesarreclamo_button.Location = new System.Drawing.Point(58, 732);
            this.procesarreclamo_button.Name = "procesarreclamo_button";
            this.procesarreclamo_button.Size = new System.Drawing.Size(163, 46);
            this.procesarreclamo_button.TabIndex = 16;
            this.procesarreclamo_button.Text = "Realizar Reclamo";
            this.procesarreclamo_button.UseVisualStyleBackColor = true;
            this.procesarreclamo_button.Click += new System.EventHandler(this.procesarreclamo_button_Click);
            // 
            // Clocklbl
            // 
            this.Clocklbl.AutoSize = true;
            this.Clocklbl.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.Clocklbl.Location = new System.Drawing.Point(1371, 52);
            this.Clocklbl.Name = "Clocklbl";
            this.Clocklbl.Size = new System.Drawing.Size(108, 18);
            this.Clocklbl.TabIndex = 17;
            this.Clocklbl.Text = "12:00:00 pm";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1577, 806);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Clocklbl);
            this.Controls.Add(this.procesarreclamo_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.actualizar_pasajeros);
            this.Controls.Add(this.actualizar_vuelos);
            this.Controls.Add(this.eliminar_pasajero);
            this.Controls.Add(this.modificar_pasajero);
            this.Controls.Add(this.agregar_pasajero);
            this.Controls.Add(this.eliminar_vuelos);
            this.Controls.Add(this.modificar_vuelos);
            this.Controls.Add(this.agregar_vuelos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_pasajeros);
            this.Controls.Add(this.dataGrid_vuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_vuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_vuelos;
        private System.Windows.Forms.DataGridView dataGrid_pasajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregar_vuelos;
        private System.Windows.Forms.Button modificar_vuelos;
        private System.Windows.Forms.Button eliminar_vuelos;
        private System.Windows.Forms.Button agregar_pasajero;
        private System.Windows.Forms.Button modificar_pasajero;
        private System.Windows.Forms.Button eliminar_pasajero;
        private System.Windows.Forms.Button actualizar_vuelos;
        private System.Windows.Forms.Button actualizar_pasajeros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button procesarreclamo_button;
        private System.Windows.Forms.Label Clocklbl;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}