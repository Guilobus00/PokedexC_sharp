﻿namespace PokedexC_sharp
{
    partial class VentanaPrincipal
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
            this.imagenPokemon = new System.Windows.Forms.PictureBox();
            this.Izquierda = new System.Windows.Forms.Button();
            this.Derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenPokemon
            // 
            this.imagenPokemon.Location = new System.Drawing.Point(45, 40);
            this.imagenPokemon.Name = "imagenPokemon";
            this.imagenPokemon.Size = new System.Drawing.Size(228, 223);
            this.imagenPokemon.TabIndex = 0;
            this.imagenPokemon.TabStop = false;
            // 
            // Izquierda
            // 
            this.Izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izquierda.Location = new System.Drawing.Point(45, 279);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(111, 44);
            this.Izquierda.TabIndex = 1;
            this.Izquierda.Text = "<=";
            this.Izquierda.UseVisualStyleBackColor = true;
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // Derecha
            // 
            this.Derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derecha.Location = new System.Drawing.Point(162, 279);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(111, 44);
            this.Derecha.TabIndex = 2;
            this.Derecha.Text = "=>";
            this.Derecha.UseVisualStyleBackColor = true;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Location = new System.Drawing.Point(279, 40);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(198, 47);
            this.nombrePokemon.TabIndex = 3;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.Derecha);
            this.Controls.Add(this.Izquierda);
            this.Controls.Add(this.imagenPokemon);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPokemon;
        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.Label nombrePokemon;
    }
}

