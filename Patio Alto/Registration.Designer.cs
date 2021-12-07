
namespace HighGarden
{
    partial class Registration
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
            this.username_register = new System.Windows.Forms.TextBox();
            this.password_register = new System.Windows.Forms.TextBox();
            this.edad_register = new System.Windows.Forms.TextBox();
            this.correo_register = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resgistrarse_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_register
            // 
            this.username_register.Location = new System.Drawing.Point(91, 223);
            this.username_register.Name = "username_register";
            this.username_register.Size = new System.Drawing.Size(211, 22);
            this.username_register.TabIndex = 0;
            // 
            // password_register
            // 
            this.password_register.Location = new System.Drawing.Point(91, 277);
            this.password_register.Name = "password_register";
            this.password_register.Size = new System.Drawing.Size(211, 22);
            this.password_register.TabIndex = 1;
            // 
            // edad_register
            // 
            this.edad_register.Location = new System.Drawing.Point(91, 334);
            this.edad_register.Name = "edad_register";
            this.edad_register.Size = new System.Drawing.Size(211, 22);
            this.edad_register.TabIndex = 2;
            // 
            // correo_register
            // 
            this.correo_register.Location = new System.Drawing.Point(91, 393);
            this.correo_register.Name = "correo_register";
            this.correo_register.Size = new System.Drawing.Size(211, 22);
            this.correo_register.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo Electronico";
            // 
            // resgistrarse_button
            // 
            this.resgistrarse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resgistrarse_button.Location = new System.Drawing.Point(94, 468);
            this.resgistrarse_button.Name = "resgistrarse_button";
            this.resgistrarse_button.Size = new System.Drawing.Size(97, 50);
            this.resgistrarse_button.TabIndex = 8;
            this.resgistrarse_button.Text = "Registrarse";
            this.resgistrarse_button.UseVisualStyleBackColor = true;
            this.resgistrarse_button.Click += new System.EventHandler(this.resgistrarse_button_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(202, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 9F);
            this.label5.Location = new System.Drawing.Point(123, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registration Form";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(374, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resgistrarse_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correo_register);
            this.Controls.Add(this.edad_register);
            this.Controls.Add(this.password_register);
            this.Controls.Add(this.username_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_register;
        private System.Windows.Forms.TextBox password_register;
        private System.Windows.Forms.TextBox edad_register;
        private System.Windows.Forms.TextBox correo_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resgistrarse_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}