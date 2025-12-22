namespace Ejercicio09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnMostrar = new Button();
            lblEnteros = new Label();
            lblCubos = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(336, 30);
            label1.TabIndex = 0;
            label1.Text = "Enteros del 1 al 10 con sus cubos";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(142, 123);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblEnteros
            // 
            lblEnteros.Location = new Point(94, 86);
            lblEnteros.Name = "lblEnteros";
            lblEnteros.Size = new Size(38, 178);
            lblEnteros.TabIndex = 2;
            lblEnteros.Text = "1";
            lblEnteros.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCubos
            // 
            lblCubos.Location = new Point(225, 86);
            lblCubos.Name = "lblCubos";
            lblCubos.Size = new Size(38, 178);
            lblCubos.TabIndex = 3;
            lblCubos.Text = "1";
            lblCubos.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 333);
            Controls.Add(lblCubos);
            Controls.Add(lblEnteros);
            Controls.Add(btnMostrar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMostrar;
        private Label lblEnteros;
        private Label lblCubos;
    }
}
