namespace FannyLunaSuma
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            btnSumar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 36);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 0;
            label1.Text = "Suma";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(98, 130);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(112, 23);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(281, 130);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(112, 23);
            txtNum2.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(453, 130);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(112, 23);
            txtResult.TabIndex = 3;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(113, 204);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 4;
            btnSumar.Text = "Suma";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(293, 204);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(475, 204);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 133);
            label2.Name = "label2";
            label2.Size = new Size(17, 17);
            label2.TabIndex = 7;
            label2.Text = "+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(416, 136);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 8;
            label3.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSumar);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private Button btnSumar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label2;
        private Label label3;
    }
}
