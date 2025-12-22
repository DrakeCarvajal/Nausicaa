namespace Ejercicio6
{
    partial class Ejercicio6
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
            lbl1 = new Label();
            txtCodigo = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(126, 41);
            lbl1.Name = "lbl1";
            lbl1.RightToLeft = RightToLeft.No;
            lbl1.Size = new Size(100, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Ingrese el código:";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(126, 76);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // btn1
            // 
            btn1.Location = new Point(28, 118);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 75);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(140, 118);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 75);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(253, 118);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 75);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(140, 212);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 5;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // Ejercicio6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 256);
            Controls.Add(btnReiniciar);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtCodigo);
            Controls.Add(lbl1);
            Name = "Ejercicio6";
            Text = "Ejercicio6. Bóveda de combinación digital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtCodigo;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnReiniciar;
    }
}
