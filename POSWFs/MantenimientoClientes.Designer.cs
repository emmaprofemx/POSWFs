﻿
namespace POSWFs
{
    partial class MantenimientoClientes
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
            this.SuspendLayout();
            // 
            // btnMConsultar
            // 
            this.btnMConsultar.Location = new System.Drawing.Point(56, 286);
            // 
            // btnMGuardar
            // 
            this.btnMGuardar.Location = new System.Drawing.Point(209, 286);
            // 
            // btnMNuevo
            // 
            this.btnMNuevo.Location = new System.Drawing.Point(372, 286);
            // 
            // btnMEliminar
            // 
            this.btnMEliminar.Location = new System.Drawing.Point(526, 286);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(614, 405);
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 444);
            this.Name = "MantenimientoClientes";
            this.Text = "MantenimientoClientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}