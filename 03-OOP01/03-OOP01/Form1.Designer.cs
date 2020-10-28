﻿namespace _03_OOP01
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreaRettangolo = new System.Windows.Forms.Button();
            this.btnCreaFattura = new System.Windows.Forms.Button();
            this.btnNFattura = new System.Windows.Forms.Button();
            this.btnClasseStatica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(66, 10);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(66, 36);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altezza";
            // 
            // btnCreaRettangolo
            // 
            this.btnCreaRettangolo.Location = new System.Drawing.Point(66, 77);
            this.btnCreaRettangolo.Name = "btnCreaRettangolo";
            this.btnCreaRettangolo.Size = new System.Drawing.Size(75, 23);
            this.btnCreaRettangolo.TabIndex = 4;
            this.btnCreaRettangolo.Text = "Crea";
            this.btnCreaRettangolo.UseVisualStyleBackColor = true;
            this.btnCreaRettangolo.Click += new System.EventHandler(this.btnCreaRettangolo_Click);
            // 
            // btnCreaFattura
            // 
            this.btnCreaFattura.Location = new System.Drawing.Point(257, 36);
            this.btnCreaFattura.Name = "btnCreaFattura";
            this.btnCreaFattura.Size = new System.Drawing.Size(75, 23);
            this.btnCreaFattura.TabIndex = 5;
            this.btnCreaFattura.Text = "Crea Fattura";
            this.btnCreaFattura.UseVisualStyleBackColor = true;
            this.btnCreaFattura.Click += new System.EventHandler(this.btnCreaFattura_Click);
            // 
            // btnNFattura
            // 
            this.btnNFattura.Location = new System.Drawing.Point(257, 77);
            this.btnNFattura.Name = "btnNFattura";
            this.btnNFattura.Size = new System.Drawing.Size(118, 23);
            this.btnNFattura.TabIndex = 6;
            this.btnNFattura.Text = "Numero di Fattura";
            this.btnNFattura.UseVisualStyleBackColor = true;
            this.btnNFattura.Click += new System.EventHandler(this.btnNFattura_Click);
            // 
            // btnClasseStatica
            // 
            this.btnClasseStatica.Location = new System.Drawing.Point(437, 28);
            this.btnClasseStatica.Name = "btnClasseStatica";
            this.btnClasseStatica.Size = new System.Drawing.Size(112, 23);
            this.btnClasseStatica.TabIndex = 7;
            this.btnClasseStatica.Text = "Classe Statica";
            this.btnClasseStatica.UseVisualStyleBackColor = true;
            this.btnClasseStatica.Click += new System.EventHandler(this.btnClasseStatica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 152);
            this.Controls.Add(this.btnClasseStatica);
            this.Controls.Add(this.btnNFattura);
            this.Controls.Add(this.btnCreaFattura);
            this.Controls.Add(this.btnCreaRettangolo);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreaRettangolo;
        private System.Windows.Forms.Button btnCreaFattura;
        private System.Windows.Forms.Button btnNFattura;
        private System.Windows.Forms.Button btnClasseStatica;
    }
}

