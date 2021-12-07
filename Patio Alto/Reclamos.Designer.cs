
namespace HighGarden
{
    partial class Reclamos
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
            this.reclamoTotal = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.CorreoElectro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPasajeros
            // 
            this.dataGridPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPasajeros.Location = new System.Drawing.Point(12, 91);
            this.dataGridPasajeros.Name = "dataGridPasajeros";
            this.dataGridPasajeros.ReadOnly = true;
            this.dataGridPasajeros.RowHeadersWidth = 51;
            this.dataGridPasajeros.RowTemplate.Height = 24;
            this.dataGridPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPasajeros.Size = new System.Drawing.Size(1024, 274);
            this.dataGridPasajeros.TabIndex = 0;
            this.dataGridPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reclamoTotal
            // 
            this.reclamoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reclamoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reclamoTotal.Location = new System.Drawing.Point(12, 463);
            this.reclamoTotal.Name = "reclamoTotal";
            this.reclamoTotal.Size = new System.Drawing.Size(1024, 174);
            this.reclamoTotal.TabIndex = 2;
            this.reclamoTotal.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reclamo:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(334, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(569, 654);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label2.Location = new System.Drawing.Point(456, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reclamos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pasajeros:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(932, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(12, 401);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.ReadOnly = true;
            this.nombreBox.Size = new System.Drawing.Size(161, 22);
            this.nombreBox.TabIndex = 9;
            // 
            // CorreoElectro
            // 
            this.CorreoElectro.Location = new System.Drawing.Point(264, 401);
            this.CorreoElectro.Name = "CorreoElectro";
            this.CorreoElectro.ReadOnly = true;
            this.CorreoElectro.Size = new System.Drawing.Size(192, 22);
            this.CorreoElectro.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Correo:";
            // 
            // x
            // 
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Location = new System.Drawing.Point(1006, 12);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(30, 29);
            this.x.TabIndex = 13;
            this.x.Text = "x";
            this.x.UseVisualStyleBackColor = true;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // Reclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 722);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CorreoElectro);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reclamoTotal);
            this.Controls.Add(this.dataGridPasajeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reclamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclamos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPasajeros;
        private System.Windows.Forms.RichTextBox reclamoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox CorreoElectro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button x;
    }
}