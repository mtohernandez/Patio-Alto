
namespace HighGarden
{
    partial class eliminarPasajero
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
            this.estadoPasajero = new System.Windows.Forms.TextBox();
            this.edadBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.eliminarPasajero_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CorreoElectro = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.vuelosID = new System.Windows.Forms.TextBox();
            this.pasajerosID_ = new System.Windows.Forms.TextBox();
            this.dataGridPasajeros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // estadoPasajero
            // 
            this.estadoPasajero.Location = new System.Drawing.Point(775, 514);
            this.estadoPasajero.Name = "estadoPasajero";
            this.estadoPasajero.ReadOnly = true;
            this.estadoPasajero.Size = new System.Drawing.Size(220, 22);
            this.estadoPasajero.TabIndex = 64;
            // 
            // edadBox
            // 
            this.edadBox.Location = new System.Drawing.Point(775, 629);
            this.edadBox.Name = "edadBox";
            this.edadBox.ReadOnly = true;
            this.edadBox.Size = new System.Drawing.Size(220, 22);
            this.edadBox.TabIndex = 63;
            // 
            // buscarButton
            // 
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarButton.Location = new System.Drawing.Point(1297, 459);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 62);
            this.buscarButton.TabIndex = 62;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Location = new System.Drawing.Point(724, 705);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(89, 35);
            this.cancelarButton.TabIndex = 61;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // eliminarPasajero_button
            // 
            this.eliminarPasajero_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarPasajero_button.Location = new System.Drawing.Point(550, 705);
            this.eliminarPasajero_button.Name = "eliminarPasajero_button";
            this.eliminarPasajero_button.Size = new System.Drawing.Size(87, 35);
            this.eliminarPasajero_button.TabIndex = 60;
            this.eliminarPasajero_button.Text = "Eliminar";
            this.eliminarPasajero_button.UseVisualStyleBackColor = true;
            this.eliminarPasajero_button.Click += new System.EventHandler(this.eliminarPasajero_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label9.Location = new System.Drawing.Point(612, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 59;
            this.label9.Text = "Eliminar Pasajero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1082, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Correo Electronico (MAX: 40 caracteres)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Estado Pasajero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Vuelo ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Pasajero ID";
            // 
            // CorreoElectro
            // 
            this.CorreoElectro.Location = new System.Drawing.Point(1085, 629);
            this.CorreoElectro.Name = "CorreoElectro";
            this.CorreoElectro.ReadOnly = true;
            this.CorreoElectro.Size = new System.Drawing.Size(287, 22);
            this.CorreoElectro.TabIndex = 50;
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(405, 629);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.ReadOnly = true;
            this.apellidoBox.Size = new System.Drawing.Size(220, 22);
            this.apellidoBox.TabIndex = 49;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(48, 629);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.ReadOnly = true;
            this.nombreBox.Size = new System.Drawing.Size(220, 22);
            this.nombreBox.TabIndex = 48;
            // 
            // vuelosID
            // 
            this.vuelosID.Location = new System.Drawing.Point(405, 514);
            this.vuelosID.Name = "vuelosID";
            this.vuelosID.ReadOnly = true;
            this.vuelosID.Size = new System.Drawing.Size(220, 22);
            this.vuelosID.TabIndex = 47;
            // 
            // pasajerosID_
            // 
            this.pasajerosID_.Location = new System.Drawing.Point(48, 514);
            this.pasajerosID_.Name = "pasajerosID_";
            this.pasajerosID_.ReadOnly = true;
            this.pasajerosID_.Size = new System.Drawing.Size(220, 22);
            this.pasajerosID_.TabIndex = 46;
            // 
            // dataGridPasajeros
            // 
            this.dataGridPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPasajeros.Location = new System.Drawing.Point(48, 81);
            this.dataGridPasajeros.Name = "dataGridPasajeros";
            this.dataGridPasajeros.ReadOnly = true;
            this.dataGridPasajeros.RowHeadersWidth = 51;
            this.dataGridPasajeros.RowTemplate.Height = 24;
            this.dataGridPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPasajeros.Size = new System.Drawing.Size(1324, 372);
            this.dataGridPasajeros.TabIndex = 45;
            this.dataGridPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPasajeros_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1416, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 25);
            this.button1.TabIndex = 65;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.estadoPasajero);
            this.Controls.Add(this.edadBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.eliminarPasajero_button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorreoElectro);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.vuelosID);
            this.Controls.Add(this.pasajerosID_);
            this.Controls.Add(this.dataGridPasajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eliminarPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eliminarPasajero";
            this.Load += new System.EventHandler(this.eliminarPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox estadoPasajero;
        private System.Windows.Forms.TextBox edadBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button eliminarPasajero_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CorreoElectro;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox vuelosID;
        private System.Windows.Forms.TextBox pasajerosID_;
        private System.Windows.Forms.DataGridView dataGridPasajeros;
        private System.Windows.Forms.Button button1;
    }
}