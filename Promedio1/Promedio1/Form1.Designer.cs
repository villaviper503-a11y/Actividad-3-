﻿namespace Promedioguia3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btncontac = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.cboGuia = new System.Windows.Forms.ComboBox();
            this.cboControl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(288, 370);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(225, 30);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "CALCULAR ";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btncontac
            // 
            this.btncontac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontac.Location = new System.Drawing.Point(655, 141);
            this.btncontac.Name = "btncontac";
            this.btncontac.Size = new System.Drawing.Size(111, 25);
            this.btncontac.TabIndex = 2;
            this.btncontac.Text = "CONTACTO";
            this.btncontac.UseVisualStyleBackColor = true;
            this.btncontac.Click += new System.EventHandler(this.btncontac_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(691, 239);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 30);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(111, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PARCIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "GUÍA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONTROL DE LECTURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "PORCENTAJES \r\n        60%";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(310, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(310, 170);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(65, 20);
            this.txtGuia.TabIndex = 10;
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(310, 241);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(65, 20);
            this.txtControl.TabIndex = 11;
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(310, 123);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(129, 20);
            this.txtParcial.TabIndex = 12;
            // 
            // cboGuia
            // 
            this.cboGuia.FormattingEnabled = true;
            this.cboGuia.Items.AddRange(new object[] {
            "40%",
            "20%"});
            this.cboGuia.Location = new System.Drawing.Point(447, 170);
            this.cboGuia.Name = "cboGuia";
            this.cboGuia.Size = new System.Drawing.Size(121, 21);
            this.cboGuia.TabIndex = 13;
            // 
            // cboControl
            // 
            this.cboControl.FormattingEnabled = true;
            this.cboControl.Items.AddRange(new object[] {
            "20%",
            "0%"});
            this.cboControl.Location = new System.Drawing.Point(447, 241);
            this.cboControl.Name = "cboControl";
            this.cboControl.Size = new System.Drawing.Size(121, 21);
            this.cboControl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboControl);
            this.Controls.Add(this.cboGuia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.txtControl);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncontac);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btncontac;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.ComboBox cboGuia;
        private System.Windows.Forms.ComboBox cboControl;
    }
}

