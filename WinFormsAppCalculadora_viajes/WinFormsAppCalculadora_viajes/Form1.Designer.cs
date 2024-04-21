namespace WinFormsAppCalculadora_viajes
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
            buttonCalcular = new Button();
            labelDestino = new Label();
            labelOrigen = new Label();
            textBoxORIGEN = new TextBox();
            textBoxDESTINO = new TextBox();
            textBoxVelocidad = new TextBox();
            labelVelocidd = new Label();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.FromArgb(0, 192, 192);
            buttonCalcular.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalcular.Location = new Point(365, 457);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(155, 57);
            buttonCalcular.TabIndex = 0;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // labelDestino
            // 
            labelDestino.AutoSize = true;
            labelDestino.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDestino.Location = new Point(291, 229);
            labelDestino.Name = "labelDestino";
            labelDestino.Size = new Size(321, 29);
            labelDestino.TabIndex = 1;
            labelDestino.Text = "Ingrese punto de destino";
            // 
            // labelOrigen
            // 
            labelOrigen.AutoSize = true;
            labelOrigen.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOrigen.Location = new Point(291, 106);
            labelOrigen.Name = "labelOrigen";
            labelOrigen.Size = new Size(310, 29);
            labelOrigen.TabIndex = 2;
            labelOrigen.Text = "Ingrese punto de origen";
            // 
            // textBoxORIGEN
            // 
            textBoxORIGEN.Location = new Point(348, 161);
            textBoxORIGEN.Name = "textBoxORIGEN";
            textBoxORIGEN.Size = new Size(204, 27);
            textBoxORIGEN.TabIndex = 3;
            // 
            // textBoxDESTINO
            // 
            textBoxDESTINO.Location = new Point(348, 276);
            textBoxDESTINO.Name = "textBoxDESTINO";
            textBoxDESTINO.Size = new Size(204, 27);
            textBoxDESTINO.TabIndex = 4;
            // 
            // textBoxVelocidad
            // 
            textBoxVelocidad.Location = new Point(348, 400);
            textBoxVelocidad.Name = "textBoxVelocidad";
            textBoxVelocidad.Size = new Size(204, 27);
            textBoxVelocidad.TabIndex = 5;
            // 
            // labelVelocidd
            // 
            labelVelocidd.AutoSize = true;
            labelVelocidd.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVelocidd.Location = new Point(248, 338);
            labelVelocidd.Name = "labelVelocidd";
            labelVelocidd.Size = new Size(399, 29);
            labelVelocidd.TabIndex = 6;
            labelVelocidd.Text = "Ingrese la velocidad Constante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 662);
            Controls.Add(labelVelocidd);
            Controls.Add(textBoxVelocidad);
            Controls.Add(textBoxDESTINO);
            Controls.Add(textBoxORIGEN);
            Controls.Add(labelOrigen);
            Controls.Add(labelDestino);
            Controls.Add(buttonCalcular);
            Name = "Form1";
            Text = "Calculadora de Viajes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalcular;
        private Label labelDestino;
        private Label labelOrigen;
        private TextBox textBoxORIGEN;
        private TextBox textBoxDESTINO;
        private TextBox textBoxVelocidad;
        private Label labelVelocidd;
    }
}
