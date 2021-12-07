
namespace HighGarden
{
    partial class ModificarVuelos
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
            this.estado_vuelo = new System.Windows.Forms.ComboBox();
            this.hora_salida = new System.Windows.Forms.ComboBox();
            this.destino_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vuelo_id = new System.Windows.Forms.TextBox();
            this.origen_box = new System.Windows.Forms.TextBox();
            this.puestos_disponibles = new System.Windows.Forms.TextBox();
            this.modificarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridVuelos = new System.Windows.Forms.DataGridView();
            this.maxcapacidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // estado_vuelo
            // 
            this.estado_vuelo.FormattingEnabled = true;
            this.estado_vuelo.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE"});
            this.estado_vuelo.Location = new System.Drawing.Point(46, 539);
            this.estado_vuelo.Name = "estado_vuelo";
            this.estado_vuelo.Size = new System.Drawing.Size(187, 24);
            this.estado_vuelo.TabIndex = 30;
            // 
            // hora_salida
            // 
            this.hora_salida.FormattingEnabled = true;
            this.hora_salida.Items.AddRange(new object[] {
            "6:00:00",
            "6:30:00",
            "8:00:00",
            "8:30:00",
            "9:00:00",
            "9:30:00",
            "10:00:00",
            "10:30:00",
            "13:00:00",
            "13:30:00",
            "14:00:00",
            "14:30:00",
            "16:00:00",
            "16:30:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00"});
            this.hora_salida.Location = new System.Drawing.Point(308, 539);
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.Size = new System.Drawing.Size(187, 24);
            this.hora_salida.TabIndex = 29;
            // 
            // destino_box
            // 
            this.destino_box.FormattingEnabled = true;
            this.destino_box.Items.AddRange(new object[] {
            "Armenia",
            "Barranquilla",
            "Bogota",
            "Bucaramanga",
            "Cali",
            "Cucuta",
            "Cartagena",
            "Leticia",
            "Medellin",
            "San Andres",
            "Santa Martha",
            "Monteria",
            "Rioacha",
            "Valledupar"});
            this.destino_box.Location = new System.Drawing.Point(583, 443);
            this.destino_box.Name = "destino_box";
            this.destino_box.Size = new System.Drawing.Size(187, 24);
            this.destino_box.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Estado Del Vuelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hora De Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Puestos Disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Vuelo ID";
            // 
            // vuelo_id
            // 
            this.vuelo_id.Location = new System.Drawing.Point(46, 443);
            this.vuelo_id.Name = "vuelo_id";
            this.vuelo_id.ReadOnly = true;
            this.vuelo_id.Size = new System.Drawing.Size(187, 22);
            this.vuelo_id.TabIndex = 19;
            // 
            // origen_box
            // 
            this.origen_box.Location = new System.Drawing.Point(308, 443);
            this.origen_box.Name = "origen_box";
            this.origen_box.ReadOnly = true;
            this.origen_box.Size = new System.Drawing.Size(187, 22);
            this.origen_box.TabIndex = 31;
            // 
            // puestos_disponibles
            // 
            this.puestos_disponibles.Location = new System.Drawing.Point(583, 541);
            this.puestos_disponibles.Name = "puestos_disponibles";
            this.puestos_disponibles.ReadOnly = true;
            this.puestos_disponibles.Size = new System.Drawing.Size(91, 22);
            this.puestos_disponibles.TabIndex = 32;
            // 
            // modificarButton
            // 
            this.modificarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarButton.Location = new System.Drawing.Point(308, 647);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(101, 45);
            this.modificarButton.TabIndex = 33;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Location = new System.Drawing.Point(520, 647);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(101, 45);
            this.cancelarButton.TabIndex = 34;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(953, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 30);
            this.button3.TabIndex = 35;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Location = new System.Drawing.Point(836, 396);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 69);
            this.buscarButton.TabIndex = 36;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label7.Location = new System.Drawing.Point(404, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Modificar Vuelos";
            // 
            // dataGridVuelos
            // 
            this.dataGridVuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVuelos.Location = new System.Drawing.Point(41, 96);
            this.dataGridVuelos.Name = "dataGridVuelos";
            this.dataGridVuelos.ReadOnly = true;
            this.dataGridVuelos.RowHeadersWidth = 51;
            this.dataGridVuelos.RowTemplate.Height = 24;
            this.dataGridVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVuelos.Size = new System.Drawing.Size(869, 294);
            this.dataGridVuelos.TabIndex = 38;
            this.dataGridVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maxcapacidad
            // 
            this.maxcapacidad.Location = new System.Drawing.Point(710, 542);
            this.maxcapacidad.Name = "maxcapacidad";
            this.maxcapacidad.ReadOnly = true;
            this.maxcapacidad.Size = new System.Drawing.Size(91, 22);
            this.maxcapacidad.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "de";
            // 
            // ModificarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 760);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxcapacidad);
            this.Controls.Add(this.dataGridVuelos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.puestos_disponibles);
            this.Controls.Add(this.origen_box);
            this.Controls.Add(this.estado_vuelo);
            this.Controls.Add(this.hora_salida);
            this.Controls.Add(this.destino_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vuelo_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarVuelos";
            this.Load += new System.EventHandler(this.ModificarVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox estado_vuelo;
        private System.Windows.Forms.ComboBox hora_salida;
        private System.Windows.Forms.ComboBox destino_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vuelo_id;
        private System.Windows.Forms.TextBox origen_box;
        private System.Windows.Forms.TextBox puestos_disponibles;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridVuelos;
        private System.Windows.Forms.TextBox maxcapacidad;
        private System.Windows.Forms.Label label8;
    }
}