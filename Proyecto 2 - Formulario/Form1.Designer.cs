
namespace Proyecto_2___Formulario
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
            this.Nom = new System.Windows.Forms.Label();
            this.Ape = new System.Windows.Forms.Label();
            this.Tel = new System.Windows.Forms.Label();
            this.Est = new System.Windows.Forms.Label();
            this.Ed = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Estatura = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Gen = new System.Windows.Forms.GroupBox();
            this.Hom = new System.Windows.Forms.RadioButton();
            this.Muj = new System.Windows.Forms.RadioButton();
            this.Gen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(88, 88);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(73, 20);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nombre: ";
            this.Nom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ape
            // 
            this.Ape.AutoSize = true;
            this.Ape.Location = new System.Drawing.Point(84, 129);
            this.Ape.Name = "Ape";
            this.Ape.Size = new System.Drawing.Size(77, 20);
            this.Ape.TabIndex = 1;
            this.Ape.Text = "Apellidos:";
            this.Ape.Click += new System.EventHandler(this.Ape_Click);
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(78, 169);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(79, 20);
            this.Tel.TabIndex = 2;
            this.Tel.Text = "Teléfono: ";
            // 
            // Est
            // 
            this.Est.AutoSize = true;
            this.Est.Location = new System.Drawing.Point(83, 211);
            this.Est.Name = "Est";
            this.Est.Size = new System.Drawing.Size(74, 20);
            this.Est.TabIndex = 3;
            this.Est.Text = "Estatura:";
            // 
            // Ed
            // 
            this.Ed.AutoSize = true;
            this.Ed.Location = new System.Drawing.Point(88, 253);
            this.Ed.Name = "Ed";
            this.Ed.Size = new System.Drawing.Size(51, 20);
            this.Ed.TabIndex = 4;
            this.Ed.Text = "Edad:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(192, 88);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(450, 26);
            this.Nombre.TabIndex = 7;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(192, 120);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(450, 26);
            this.Apellidos.TabIndex = 8;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(192, 169);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(450, 26);
            this.Telefono.TabIndex = 9;
            // 
            // Estatura
            // 
            this.Estatura.Location = new System.Drawing.Point(192, 211);
            this.Estatura.Name = "Estatura";
            this.Estatura.Size = new System.Drawing.Size(450, 26);
            this.Estatura.TabIndex = 10;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(192, 253);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(450, 26);
            this.Edad.TabIndex = 11;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(82, 499);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(213, 88);
            this.Save.TabIndex = 13;
            this.Save.Text = "Guardar";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(429, 499);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(213, 88);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Gen
            // 
            this.Gen.Controls.Add(this.Muj);
            this.Gen.Controls.Add(this.Hom);
            this.Gen.Location = new System.Drawing.Point(92, 336);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(550, 100);
            this.Gen.TabIndex = 15;
            this.Gen.TabStop = false;
            this.Gen.Text = "Género";
            // 
            // Hom
            // 
            this.Hom.AutoSize = true;
            this.Hom.Location = new System.Drawing.Point(77, 45);
            this.Hom.Name = "Hom";
            this.Hom.Size = new System.Drawing.Size(91, 24);
            this.Hom.TabIndex = 0;
            this.Hom.TabStop = true;
            this.Hom.Text = "Hombre";
            this.Hom.UseVisualStyleBackColor = true;
            // 
            // Muj
            // 
            this.Muj.AutoSize = true;
            this.Muj.Location = new System.Drawing.Point(337, 45);
            this.Muj.Name = "Muj";
            this.Muj.Size = new System.Drawing.Size(73, 24);
            this.Muj.TabIndex = 1;
            this.Muj.TabStop = true;
            this.Muj.Text = "Mujer";
            this.Muj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 765);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Estatura);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Ed);
            this.Controls.Add(this.Est);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Ape);
            this.Controls.Add(this.Nom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Gen.ResumeLayout(false);
            this.Gen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Ape;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.Label Est;
        private System.Windows.Forms.Label Ed;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Estatura;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox Gen;
        private System.Windows.Forms.RadioButton Muj;
        private System.Windows.Forms.RadioButton Hom;
    }
}

