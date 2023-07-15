
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoClientes));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtApellido_Cliente = new LibreriaDLL.ErrortxBox();
            this.txtNombre_Cliente = new LibreriaDLL.ErrortxBox();
            this.txtId_Cliente = new LibreriaDLL.ErrortxBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMConsultar
            // 
            this.btnMConsultar.Location = new System.Drawing.Point(83, 286);
            this.btnMConsultar.Click += new System.EventHandler(this.btnMConsultar_Click);
            // 
            // btnMGuardar
            // 
            this.btnMGuardar.Location = new System.Drawing.Point(235, 286);
            this.btnMGuardar.Click += new System.EventHandler(this.btnMGuardar_Click);
            // 
            // btnMNuevo
            // 
            this.btnMNuevo.Location = new System.Drawing.Point(388, 286);
            this.btnMNuevo.Click += new System.EventHandler(this.btnMNuevo_Click);
            // 
            // btnMEliminar
            // 
            this.btnMEliminar.Location = new System.Drawing.Point(548, 286);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(573, 347);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(186, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "C L I E N T E S";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id Cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(440, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 196);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtApellido_Cliente
            // 
            this.txtApellido_Cliente.Location = new System.Drawing.Point(192, 201);
            this.txtApellido_Cliente.Name = "txtApellido_Cliente";
            this.txtApellido_Cliente.Size = new System.Drawing.Size(192, 20);
            this.txtApellido_Cliente.TabIndex = 23;
            this.txtApellido_Cliente.Validar = true;
            this.txtApellido_Cliente.ValidarNumeros = false;
            // 
            // txtNombre_Cliente
            // 
            this.txtNombre_Cliente.Location = new System.Drawing.Point(192, 146);
            this.txtNombre_Cliente.Name = "txtNombre_Cliente";
            this.txtNombre_Cliente.Size = new System.Drawing.Size(192, 20);
            this.txtNombre_Cliente.TabIndex = 22;
            this.txtNombre_Cliente.Validar = true;
            this.txtNombre_Cliente.ValidarNumeros = false;
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Location = new System.Drawing.Point(192, 96);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.Size = new System.Drawing.Size(192, 20);
            this.txtId_Cliente.TabIndex = 21;
            this.txtId_Cliente.Validar = true;
            this.txtId_Cliente.ValidarNumeros = true;
            this.txtId_Cliente.TextChanged += new System.EventHandler(this.txtId_Cliente_TextChanged);
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 408);
            this.Controls.Add(this.txtApellido_Cliente);
            this.Controls.Add(this.txtNombre_Cliente);
            this.Controls.Add(this.txtId_Cliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoClientes";
            this.Text = "MantenimientoClientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnMConsultar, 0);
            this.Controls.SetChildIndex(this.btnMGuardar, 0);
            this.Controls.SetChildIndex(this.btnMNuevo, 0);
            this.Controls.SetChildIndex(this.btnMEliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtId_Cliente, 0);
            this.Controls.SetChildIndex(this.txtNombre_Cliente, 0);
            this.Controls.SetChildIndex(this.txtApellido_Cliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LibreriaDLL.ErrortxBox txtId_Cliente;
        private LibreriaDLL.ErrortxBox txtNombre_Cliente;
        private LibreriaDLL.ErrortxBox txtApellido_Cliente;
    }
}