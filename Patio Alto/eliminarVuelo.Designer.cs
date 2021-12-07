
namespace HighGarden
{
    partial class eliminarVuelo
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
            this.dataGridVuelos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.puestos_disponibles = new System.Windows.Forms.TextBox();
            this.origen_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vuelo_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.destino_box = new System.Windows.Forms.TextBox();
            this.estado_vuelo = new System.Windows.Forms.TextBox();
            this.hora_salida = new System.Windows.Forms.TextBox();
            this.maxcapacidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVuelos
            // 
            this.dataGridVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVuelos.Location = new System.Drawing.Point(42, 95);
            this.dataGridVuelos.Name = "dataGridVuelos";
            this.dataGridVuelos.ReadOnly = true;
            this.dataGridVuelos.RowHeadersWidth = 51;
            this.dataGridVuelos.RowTemplate.Height = 24;
            this.dataGridVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVuelos.Size = new System.Drawing.Size(869, 294);
            this.dataGridVuelos.TabIndex = 55;
            this.dataGridVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVuelos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label7.Location = new System.Drawing.Point(392, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Eliminar Vuelos";
            // 
            // buscarButton
            // 
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Location = new System.Drawing.Point(829, 395);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(82, 57);
            this.buscarButton.TabIndex = 53;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Location = new System.Drawing.Point(516, 653);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(89, 49);
            this.cancelarButton.TabIndex = 52;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Location = new System.Drawing.Point(309, 653);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(101, 49);
            this.eliminarButton.TabIndex = 51;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // puestos_disponibles
            // 
            this.puestos_disponibles.Location = new System.Drawing.Point(584, 540);
            this.puestos_disponibles.Name = "puestos_disponibles";
            this.puestos_disponibles.ReadOnly = true;
            this.puestos_disponibles.Size = new System.Drawing.Size(81, 22);
            this.puestos_disponibles.TabIndex = 50;
            // 
            // origen_box
            // 
            this.origen_box.Location = new System.Drawing.Point(309, 442);
            this.origen_box.Name = "origen_box";
            this.origen_box.ReadOnly = true;
            this.origen_box.Size = new System.Drawing.Size(187, 22);
            this.origen_box.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Estado Del Vuelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Hora De Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Puestos Disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Vuelo ID";
            // 
            // vuelo_id
            // 
            this.vuelo_id.Location = new System.Drawing.Point(47, 442);
            this.vuelo_id.Name = "vuelo_id";
            this.vuelo_id.ReadOnly = true;
            this.vuelo_id.Size = new System.Drawing.Size(187, 22);
            this.vuelo_id.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(469, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Al eliminar vuelos se perderan todas las reservas y/o compras realizadas";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(921, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 30);
            this.button3.TabIndex = 57;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // destino_box
            // 
            this.destino_box.Location = new System.Drawing.Point(583, 444);
            this.destino_box.Name = "destino_box";
            this.destino_box.ReadOnly = true;
            this.destino_box.Size = new System.Drawing.Size(187, 22);
            this.destino_box.TabIndex = 58;
            // 
            // estado_vuelo
            // 
            this.estado_vuelo.Location = new System.Drawing.Point(47, 538);
            this.estado_vuelo.Name = "estado_vuelo";
            this.estado_vuelo.ReadOnly = true;
            this.estado_vuelo.Size = new System.Drawing.Size(187, 22);
            this.estado_vuelo.TabIndex = 59;
            // 
            // hora_salida
            // 
            this.hora_salida.Location = new System.Drawing.Point(309, 540);
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.ReadOnly = true;
            this.hora_salida.Size = new System.Drawing.Size(187, 22);
            this.hora_salida.TabIndex = 60;
            // 
            // maxcapacidad
            // 
            this.maxcapacidad.Location = new System.Drawing.Point(701, 540);
            this.maxcapacidad.Name = "maxcapacidad";
            this.maxcapacidad.ReadOnly = true;
            this.maxcapacidad.Size = new System.Drawing.Size(82, 22);
            this.maxcapacidad.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(671, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "de";
            // 
            // eliminarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 736);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxcapacidad);
            this.Controls.Add(this.hora_salida);
            this.Controls.Add(this.estado_vuelo);
            this.Controls.Add(this.destino_box);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridVuelos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.puestos_disponibles);
            this.Controls.Add(this.origen_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vuelo_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eliminarVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eliminarVuelo";
            this.Load += new System.EventHandler(this.eliminarVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVuelos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.TextBox puestos_disponibles;
        private System.Windows.Forms.TextBox origen_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vuelo_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox destino_box;
        private System.Windows.Forms.TextBox estado_vuelo;
        private System.Windows.Forms.TextBox hora_salida;
        private System.Windows.Forms.TextBox maxcapacidad;
        private System.Windows.Forms.Label label9;
    }
}