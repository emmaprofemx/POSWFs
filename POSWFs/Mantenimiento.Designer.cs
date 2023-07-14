
namespace POSWFs
{
    partial class Mantenimiento
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
            this.btnMConsultar = new System.Windows.Forms.Button();
            this.btnMGuardar = new System.Windows.Forms.Button();
            this.btnMNuevo = new System.Windows.Forms.Button();
            this.btnMEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(545, 369);
            // 
            // btnMConsultar
            // 
            this.btnMConsultar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMConsultar.Location = new System.Drawing.Point(70, 286);
            this.btnMConsultar.Name = "btnMConsultar";
            this.btnMConsultar.Size = new System.Drawing.Size(105, 30);
            this.btnMConsultar.TabIndex = 1;
            this.btnMConsultar.Text = "Consultar";
            this.btnMConsultar.UseVisualStyleBackColor = true;
            this.btnMConsultar.Click += new System.EventHandler(this.btnMConsultar_Click);
            // 
            // btnMGuardar
            // 
            this.btnMGuardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMGuardar.Location = new System.Drawing.Point(213, 286);
            this.btnMGuardar.Name = "btnMGuardar";
            this.btnMGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnMGuardar.TabIndex = 2;
            this.btnMGuardar.Text = "Guardar";
            this.btnMGuardar.UseVisualStyleBackColor = true;
            this.btnMGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMNuevo
            // 
            this.btnMNuevo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMNuevo.Location = new System.Drawing.Point(373, 286);
            this.btnMNuevo.Name = "btnMNuevo";
            this.btnMNuevo.Size = new System.Drawing.Size(105, 30);
            this.btnMNuevo.TabIndex = 3;
            this.btnMNuevo.Text = "Nuevo";
            this.btnMNuevo.UseVisualStyleBackColor = true;
            this.btnMNuevo.Click += new System.EventHandler(this.btnMNuevo_Click);
            // 
            // btnMEliminar
            // 
            this.btnMEliminar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMEliminar.Location = new System.Drawing.Point(520, 286);
            this.btnMEliminar.Name = "btnMEliminar";
            this.btnMEliminar.Size = new System.Drawing.Size(105, 30);
            this.btnMEliminar.TabIndex = 4;
            this.btnMEliminar.Text = "Eliminar";
            this.btnMEliminar.UseVisualStyleBackColor = true;
            this.btnMEliminar.Click += new System.EventHandler(this.btnMEliminar_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.btnMEliminar);
            this.Controls.Add(this.btnMNuevo);
            this.Controls.Add(this.btnMGuardar);
            this.Controls.Add(this.btnMConsultar);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnMConsultar, 0);
            this.Controls.SetChildIndex(this.btnMGuardar, 0);
            this.Controls.SetChildIndex(this.btnMNuevo, 0);
            this.Controls.SetChildIndex(this.btnMEliminar, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnMConsultar;
        public System.Windows.Forms.Button btnMGuardar;
        public System.Windows.Forms.Button btnMNuevo;
        public System.Windows.Forms.Button btnMEliminar;
    }
}