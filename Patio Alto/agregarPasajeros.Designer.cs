
namespace HighGarden
{
    partial class agregarPasajeros
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
            this.dataGridPasajeros = new System.Windows.Forms.DataGridView();
            this.pasajerosID_ = new System.Windows.Forms.TextBox();
            this.vuelosID = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.edadComboBox = new System.Windows.Forms.ComboBox();
            this.CorreoElectro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.agregarpasajero_button = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.RadioButton();
            this.neutroButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPasajeros
            // 
            this.dataGridPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPasajeros.Location = new System.Drawing.Point(67, 109);
            this.dataGridPasajeros.Name = "dataGridPasajeros";
            this.dataGridPasajeros.ReadOnly = true;
            this.dataGridPasajeros.RowHeadersWidth = 51;
            this.dataGridPasajeros.RowTemplate.Height = 24;
            this.dataGridPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPasajeros.Size = new System.Drawing.Size(1324, 372);
            this.dataGridPasajeros.TabIndex = 0;
            this.dataGridPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPasajeros_CellContentClick);
            // 
            // pasajerosID_
            // 
            this.pasajerosID_.Location = new System.Drawing.Point(67, 542);
            this.pasajerosID_.Name = "pasajerosID_";
            this.pasajerosID_.Size = new System.Drawing.Size(220, 22);
            this.pasajerosID_.TabIndex = 1;
            // 
            // vuelosID
            // 
            this.vuelosID.Location = new System.Drawing.Point(424, 542);
            this.vuelosID.Name = "vuelosID";
            this.vuelosID.ReadOnly = true;
            this.vuelosID.Size = new System.Drawing.Size(220, 22);
            this.vuelosID.TabIndex = 2;
            this.vuelosID.TextChanged += new System.EventHandler(this.vuelosID_TextChanged);
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(67, 657);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(220, 22);
            this.nombreBox.TabIndex = 4;
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(424, 657);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(220, 22);
            this.apellidoBox.TabIndex = 5;
            // 
            // edadComboBox
            // 
            this.edadComboBox.FormattingEnabled = true;
            this.edadComboBox.Items.AddRange(new object[] {
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
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.edadComboBox.Location = new System.Drawing.Point(794, 657);
            this.edadComboBox.Name = "edadComboBox";
            this.edadComboBox.Size = new System.Drawing.Size(220, 24);
            this.edadComboBox.TabIndex = 6;
            // 
            // CorreoElectro
            // 
            this.CorreoElectro.Location = new System.Drawing.Point(1104, 657);
            this.CorreoElectro.Name = "CorreoElectro";
            this.CorreoElectro.Size = new System.Drawing.Size(287, 22);
            this.CorreoElectro.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pasajero ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vuelo ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado Pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 68);
            this.label4.TabIndex = 12;
            this.label4.Text = "NORMAL pertenece a vuelo\r\nNEUTRO viene de visita al aeropuerto\r\n\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(791, 633);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1101, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Correo Electronico (MAX: 40 caracteres)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label9.Location = new System.Drawing.Point(644, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Agregar Pasajero";
            // 
            // agregarpasajero_button
            // 
            this.agregarpasajero_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarpasajero_button.Location = new System.Drawing.Point(569, 728);
            this.agregarpasajero_button.Name = "agregarpasajero_button";
            this.agregarpasajero_button.Size = new System.Drawing.Size(88, 33);
            this.agregarpasajero_button.TabIndex = 18;
            this.agregarpasajero_button.Text = "Agregar";
            this.agregarpasajero_button.UseVisualStyleBackColor = true;
            this.agregarpasajero_button.Click += new System.EventHandler(this.agregarpasajero_button_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Location = new System.Drawing.Point(734, 728);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(84, 33);
            this.cancelarButton.TabIndex = 19;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Location = new System.Drawing.Point(1316, 500);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 52);
            this.buscarButton.TabIndex = 20;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1460, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // normalButton
            // 
            this.normalButton.AutoSize = true;
            this.normalButton.Location = new System.Drawing.Point(794, 543);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(88, 21);
            this.normalButton.TabIndex = 22;
            this.normalButton.TabStop = true;
            this.normalButton.Text = "NORMAL";
            this.normalButton.UseVisualStyleBackColor = true;
            // 
            // neutroButton
            // 
            this.neutroButton.AutoSize = true;
            this.neutroButton.Location = new System.Drawing.Point(920, 543);
            this.neutroButton.Name = "neutroButton";
            this.neutroButton.Size = new System.Drawing.Size(88, 21);
            this.neutroButton.TabIndex = 23;
            this.neutroButton.TabStop = true;
            this.neutroButton.Text = "NEUTRO";
            this.neutroButton.UseVisualStyleBackColor = true;
            // 
            // agregarPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1503, 789);
            this.Controls.Add(this.neutroButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.agregarpasajero_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorreoElectro);
            this.Controls.Add(this.edadComboBox);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.vuelosID);
            this.Controls.Add(this.pasajerosID_);
            this.Controls.Add(this.dataGridPasajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarPasajeros";
            this.Load += new System.EventHandler(this.agregarPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPasajeros;
        private System.Windows.Forms.TextBox pasajerosID_;
        private System.Windows.Forms.TextBox vuelosID;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.ComboBox edadComboBox;
        private System.Windows.Forms.TextBox CorreoElectro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button agregarpasajero_button;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton normalButton;
        private System.Windows.Forms.RadioButton neutroButton;
    }
}