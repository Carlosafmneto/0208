namespace _0208
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LBValor1 = new Label();
            LBValor2 = new Label();
            LBTotal = new Label();
            LBresultado = new Label();
            BTNSoma = new Button();
            BTNMenos = new Button();
            BTNVezes = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // LBValor1
            // 
            LBValor1.AutoSize = true;
            LBValor1.Location = new Point(111, 63);
            LBValor1.Name = "LBValor1";
            LBValor1.Size = new Size(39, 15);
            LBValor1.TabIndex = 2;
            LBValor1.Text = "Valor1";
            LBValor1.Click += label1_Click;
            // 
            // LBValor2
            // 
            LBValor2.AutoSize = true;
            LBValor2.Location = new Point(111, 107);
            LBValor2.Name = "LBValor2";
            LBValor2.Size = new Size(39, 15);
            LBValor2.TabIndex = 3;
            LBValor2.Text = "Valor2";
            // 
            // LBTotal
            // 
            LBTotal.AutoSize = true;
            LBTotal.Location = new Point(111, 156);
            LBTotal.Name = "LBTotal";
            LBTotal.Size = new Size(32, 15);
            LBTotal.TabIndex = 4;
            LBTotal.Text = "Total";
            LBTotal.Click += label3_Click;
            // 
            // LBresultado
            // 
            LBresultado.AutoSize = true;
            LBresultado.Location = new Point(198, 156);
            LBresultado.Name = "LBresultado";
            LBresultado.Size = new Size(16, 15);
            LBresultado.TabIndex = 5;
            LBresultado.Text = "...";
            LBresultado.Click += LB_Click;
            // 
            // BTNSoma
            // 
            BTNSoma.Location = new Point(111, 197);
            BTNSoma.Name = "BTNSoma";
            BTNSoma.Size = new Size(75, 23);
            BTNSoma.TabIndex = 6;
            BTNSoma.Text = "Soma";
            BTNSoma.UseVisualStyleBackColor = true;
            // 
            // BTNMenos
            // 
            BTNMenos.Location = new Point(111, 235);
            BTNMenos.Name = "BTNMenos";
            BTNMenos.Size = new Size(75, 23);
            BTNMenos.TabIndex = 7;
            BTNMenos.Text = "Menos";
            BTNMenos.UseVisualStyleBackColor = true;
            BTNMenos.Click += BTNMenos_Click;
            // 
            // BTNVezes
            // 
            BTNVezes.Location = new Point(111, 276);
            BTNVezes.Name = "BTNVezes";
            BTNVezes.Size = new Size(75, 23);
            BTNVezes.TabIndex = 8;
            BTNVezes.Text = "Vezes";
            BTNVezes.UseVisualStyleBackColor = true;
            BTNVezes.Click += BTNVezes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNVezes);
            Controls.Add(BTNMenos);
            Controls.Add(BTNSoma);
            Controls.Add(LBresultado);
            Controls.Add(LBTotal);
            Controls.Add(LBValor2);
            Controls.Add(LBValor1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label LBValor1;
        private Label LBValor2;
        private Label LBTotal;
        private Label LBresultado;
        private Button BTNSoma;
        private Button BTNMenos;
        private Button BTNVezes;
    }
}
