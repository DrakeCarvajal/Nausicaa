namespace Ejercicio07
{
    partial class Ejercicio7
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
            btnTijeras = new Button();
            btnPapel = new Button();
            Piedra = new Button();
            lbl1 = new Label();
            lblGanaste = new Label();
            lblPerdiste = new Label();
            lblUsaste = new Label();
            lblUso = new Label();
            lblEmpate = new Label();
            SuspendLayout();
            // 
            // btnTijeras
            // 
            btnTijeras.Location = new Point(264, 151);
            btnTijeras.Name = "btnTijeras";
            btnTijeras.Size = new Size(75, 75);
            btnTijeras.TabIndex = 10;
            btnTijeras.Text = "Tijeras";
            btnTijeras.UseVisualStyleBackColor = true;
            btnTijeras.Click += btnTijeras_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(151, 151);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(75, 75);
            btnPapel.TabIndex = 9;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // Piedra
            // 
            Piedra.Location = new Point(39, 151);
            Piedra.Name = "Piedra";
            Piedra.Size = new Size(75, 75);
            Piedra.TabIndex = 8;
            Piedra.Text = "Piedra";
            Piedra.UseVisualStyleBackColor = true;
            Piedra.Click += btnPiedra_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(80, 23);
            lbl1.Name = "lbl1";
            lbl1.RightToLeft = RightToLeft.No;
            lbl1.Size = new Size(222, 30);
            lbl1.TabIndex = 6;
            lbl1.Text = "Piedra Papel o Tijeras";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGanaste
            // 
            lblGanaste.AutoSize = true;
            lblGanaste.Location = new Point(80, 76);
            lblGanaste.Name = "lblGanaste";
            lblGanaste.Size = new Size(49, 15);
            lblGanaste.TabIndex = 12;
            lblGanaste.Text = "Ganaste";
            lblGanaste.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPerdiste
            // 
            lblPerdiste.AutoSize = true;
            lblPerdiste.Location = new Point(264, 76);
            lblPerdiste.Name = "lblPerdiste";
            lblPerdiste.Size = new Size(49, 15);
            lblPerdiste.TabIndex = 13;
            lblPerdiste.Text = "Perdiste";
            // 
            // lblUsaste
            // 
            lblUsaste.AutoSize = true;
            lblUsaste.Location = new Point(64, 115);
            lblUsaste.Name = "lblUsaste";
            lblUsaste.Size = new Size(62, 15);
            lblUsaste.TabIndex = 14;
            lblUsaste.Text = "Tu usaste: ";
            // 
            // lblUso
            // 
            lblUso.AutoSize = true;
            lblUso.Location = new Point(230, 115);
            lblUso.Name = "lblUso";
            lblUso.Size = new Size(41, 15);
            lblUso.TabIndex = 15;
            lblUso.Text = "Él usó:";
            // 
            // lblEmpate
            // 
            lblEmpate.AutoSize = true;
            lblEmpate.Location = new Point(165, 76);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(47, 15);
            lblEmpate.TabIndex = 16;
            lblEmpate.Text = "Empate";
            // 
            // Ejercicio7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 284);
            Controls.Add(lblEmpate);
            Controls.Add(lblUso);
            Controls.Add(lblUsaste);
            Controls.Add(lblPerdiste);
            Controls.Add(lblGanaste);
            Controls.Add(btnTijeras);
            Controls.Add(btnPapel);
            Controls.Add(Piedra);
            Controls.Add(lbl1);
            Name = "Ejercicio7";
            Text = "Ejercicio7. Juego de piedra, papel o tijera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTijeras;
        private Button btnPapel;
        private Button Piedra;
        private Label lbl1;
        private Label lblGanaste;
        private Label lblPerdiste;
        private Label lblUsaste;
        private Label lblUso;
        private Label lblEmpate;
    }
}
