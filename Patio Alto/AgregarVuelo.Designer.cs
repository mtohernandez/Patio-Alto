
namespace HighGarden
{
    partial class AgregarVuelo
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
            this.vuelo_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modificar_vuelo = new System.Windows.Forms.Button();
            this.cancelarmodificar_vuelo = new System.Windows.Forms.Button();
            this.destino_box = new System.Windows.Forms.ComboBox();
            this.origen_box = new System.Windows.Forms.ComboBox();
            this.puestos_disponibles = new System.Windows.Forms.ComboBox();
            this.hora_salida = new System.Windows.Forms.ComboBox();
            this.estado_vuelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vuelo_id
            // 
            this.vuelo_id.Location = new System.Drawing.Point(95, 108);
            this.vuelo_id.Name = "vuelo_id";
            this.vuelo_id.Size = new System.Drawing.Size(187, 22);
            this.vuelo_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vuelo ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puestos Disponibles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora De Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado Del Vuelo";
            // 
            // modificar_vuelo
            // 
            this.modificar_vuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_vuelo.Location = new System.Drawing.Point(95, 589);
            this.modificar_vuelo.Name = "modificar_vuelo";
            this.modificar_vuelo.Size = new System.Drawing.Size(84, 50);
            this.modificar_vuelo.TabIndex = 12;
            this.modificar_vuelo.Text = "Agregar";
            this.modificar_vuelo.UseVisualStyleBackColor = true;
            this.modificar_vuelo.Click += new System.EventHandler(this.modificar_vuelo_Click);
            // 
            // cancelarmodificar_vuelo
            // 
            this.cancelarmodificar_vuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarmodificar_vuelo.Location = new System.Drawing.Point(199, 589);
            this.cancelarmodificar_vuelo.Name = "cancelarmodificar_vuelo";
            this.cancelarmodificar_vuelo.Size = new System.Drawing.Size(83, 50);
            this.cancelarmodificar_vuelo.TabIndex = 13;
            this.cancelarmodificar_vuelo.Text = "Cancelar";
            this.cancelarmodificar_vuelo.UseVisualStyleBackColor = true;
            this.cancelarmodificar_vuelo.Click += new System.EventHandler(this.cancelarmodificar_vuelo_Click);
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
            this.destino_box.Location = new System.Drawing.Point(95, 191);
            this.destino_box.Name = "destino_box";
            this.destino_box.Size = new System.Drawing.Size(187, 24);
            this.destino_box.TabIndex = 14;
            // 
            // origen_box
            // 
            this.origen_box.FormattingEnabled = true;
            this.origen_box.Items.AddRange(new object[] {
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
            this.origen_box.Location = new System.Drawing.Point(95, 273);
            this.origen_box.Name = "origen_box";
            this.origen_box.Size = new System.Drawing.Size(187, 24);
            this.origen_box.TabIndex = 15;
            // 
            // puestos_disponibles
            // 
            this.puestos_disponibles.FormattingEnabled = true;
            this.puestos_disponibles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.puestos_disponibles.Location = new System.Drawing.Point(95, 353);
            this.puestos_disponibles.Name = "puestos_disponibles";
            this.puestos_disponibles.Size = new System.Drawing.Size(187, 24);
            this.puestos_disponibles.TabIndex = 16;
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
            this.hora_salida.Location = new System.Drawing.Point(95, 434);
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.Size = new System.Drawing.Size(187, 24);
            this.hora_salida.TabIndex = 17;
            // 
            // estado_vuelo
            // 
            this.estado_vuelo.FormattingEnabled = true;
            this.estado_vuelo.Items.AddRange(new object[] {
            "DISPONIBLE",
            "NO DISPONIBLE"});
            this.estado_vuelo.Location = new System.Drawing.Point(95, 519);
            this.estado_vuelo.Name = "estado_vuelo";
            this.estado_vuelo.Size = new System.Drawing.Size(187, 24);
            this.estado_vuelo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label7.Location = new System.Drawing.Point(131, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Agregar Vuelo";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(360, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sera al igual la maxima capacidad.";
            // 
            // AgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 727);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.estado_vuelo);
            this.Controls.Add(this.hora_salida);
            this.Controls.Add(this.puestos_disponibles);
            this.Controls.Add(this.origen_box);
            this.Controls.Add(this.destino_box);
            this.Controls.Add(this.cancelarmodificar_vuelo);
            this.Controls.Add(this.modificar_vuelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vuelo_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarVuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vuelo_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modificar_vuelo;
        private System.Windows.Forms.Button cancelarmodificar_vuelo;
        private System.Windows.Forms.ComboBox destino_box;
        private System.Windows.Forms.ComboBox origen_box;
        private System.Windows.Forms.ComboBox puestos_disponibles;
        private System.Windows.Forms.ComboBox hora_salida;
        private System.Windows.Forms.ComboBox estado_vuelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}