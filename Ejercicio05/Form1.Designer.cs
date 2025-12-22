namespace Ejercicio05
{
    partial class Ejercicio5
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
            btnCarta = new Button();
            lblCarta = new Label();
            SuspendLayout();
            // 
            // btnCarta
            // 
            btnCarta.Location = new Point(105, 107);
            btnCarta.Name = "btnCarta";
            btnCarta.Size = new Size(75, 23);
            btnCarta.TabIndex = 0;
            btnCarta.Text = "Sacar Carta";
            btnCarta.UseVisualStyleBackColor = true;
            btnCarta.Click += btnCarta_Click;
            // 
            // lblCarta
            // 
            lblCarta.AutoSize = true;
            lblCarta.Font = new Font("Segoe UI", 12F);
            lblCarta.Location = new Point(24, 40);
            lblCarta.Name = "lblCarta";
            lblCarta.Size = new Size(91, 21);
            lblCarta.TabIndex = 1;
            lblCarta.Text = "Tu carta es: ";
            lblCarta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 165);
            Controls.Add(lblCarta);
            Controls.Add(btnCarta);
            Name = "Ejercicio5";
            Text = "Ejercicio5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarta;
        private Label lblCarta;
    }
}
