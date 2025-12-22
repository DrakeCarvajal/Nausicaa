namespace Ejercicio04
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
            btnCaF = new Button();
            btbFaC = new Button();
            lblCentigrados = new Label();
            label1 = new Label();
            txtCentrigrados = new TextBox();
            txtFahrenheit = new TextBox();
            btn1Cen = new Button();
            btn1Fahren = new Button();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // btnCaF
            // 
            btnCaF.Cursor = Cursors.Hand;
            btnCaF.Location = new Point(32, 26);
            btnCaF.Name = "btnCaF";
            btnCaF.Size = new Size(122, 59);
            btnCaF.TabIndex = 0;
            btnCaF.Text = "Convertir C a F";
            btnCaF.UseVisualStyleBackColor = true;
            btnCaF.Click += btnCaF_Click;
            // 
            // btbFaC
            // 
            btbFaC.Cursor = Cursors.Hand;
            btbFaC.Location = new Point(302, 26);
            btbFaC.Name = "btbFaC";
            btbFaC.Size = new Size(122, 59);
            btbFaC.TabIndex = 1;
            btbFaC.Text = "Convertir F a C";
            btbFaC.UseVisualStyleBackColor = true;
            btbFaC.Click += btbFaC_Click;
            // 
            // lblCentigrados
            // 
            lblCentigrados.AutoSize = true;
            lblCentigrados.Location = new Point(59, 122);
            lblCentigrados.Name = "lblCentigrados";
            lblCentigrados.Size = new Size(114, 15);
            lblCentigrados.TabIndex = 2;
            lblCentigrados.Text = "Grados Centígrados:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 184);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 3;
            label1.Text = "Grados Fahrenheit:";
            // 
            // txtCentrigrados
            // 
            txtCentrigrados.Location = new Point(213, 119);
            txtCentrigrados.Name = "txtCentrigrados";
            txtCentrigrados.Size = new Size(100, 23);
            txtCentrigrados.TabIndex = 4;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Enabled = false;
            txtFahrenheit.Location = new Point(201, 181);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(112, 23);
            txtFahrenheit.TabIndex = 5;
            // 
            // btn1Cen
            // 
            btn1Cen.Cursor = Cursors.Hand;
            btn1Cen.Location = new Point(334, 106);
            btn1Cen.Name = "btn1Cen";
            btn1Cen.Size = new Size(64, 46);
            btn1Cen.TabIndex = 6;
            btn1Cen.Text = "+1";
            btn1Cen.UseVisualStyleBackColor = true;
            btn1Cen.Click += btn1Cen_Click;
            // 
            // btn1Fahren
            // 
            btn1Fahren.Cursor = Cursors.Hand;
            btn1Fahren.Location = new Point(334, 168);
            btn1Fahren.Name = "btn1Fahren";
            btn1Fahren.Size = new Size(64, 46);
            btn1Fahren.TabIndex = 7;
            btn1Fahren.Text = "+1";
            btn1Fahren.UseVisualStyleBackColor = true;
            btn1Fahren.Click += btn1Fahren_Click;
            // 
            // btnConvertir
            // 
            btnConvertir.Cursor = Cursors.Hand;
            btnConvertir.Location = new Point(170, 236);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(122, 45);
            btnConvertir.TabIndex = 8;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 307);
            Controls.Add(btnConvertir);
            Controls.Add(btn1Fahren);
            Controls.Add(btn1Cen);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCentrigrados);
            Controls.Add(label1);
            Controls.Add(lblCentigrados);
            Controls.Add(btbFaC);
            Controls.Add(btnCaF);
            Name = "Form1";
            Text = "Ejercicio4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCaF;
        private Button btbFaC;
        private Label lblCentigrados;
        private Label label1;
        private TextBox txtCentrigrados;
        private TextBox txtFahrenheit;
        private Button btn1Cen;
        private Button btn1Fahren;
        private Button btnConvertir;
    }
}
