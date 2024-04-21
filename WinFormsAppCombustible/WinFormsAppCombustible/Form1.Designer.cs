namespace WinFormsAppCombustible
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
            labelDisRecorrida = new Label();
            labelGalones = new Label();
            labelResultado = new Label();
            buttonCalcular = new Button();
            textBoxDIS = new TextBox();
            textBoxKMgal = new TextBox();
            SuspendLayout();
            // 
            // labelDisRecorrida
            // 
            labelDisRecorrida.AutoSize = true;
            labelDisRecorrida.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDisRecorrida.Location = new Point(204, 49);
            labelDisRecorrida.Name = "labelDisRecorrida";
            labelDisRecorrida.Size = new Size(328, 28);
            labelDisRecorrida.TabIndex = 0;
            labelDisRecorrida.Text = "Ingrese La distancia total recorrida.";
            labelDisRecorrida.Click += labelDisRecorrida_Click;
            // 
            // labelGalones
            // 
            labelGalones.AutoSize = true;
            labelGalones.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGalones.Location = new Point(184, 155);
            labelGalones.Name = "labelGalones";
            labelGalones.Size = new Size(357, 28);
            labelGalones.TabIndex = 1;
            labelGalones.Text = "Ingrese el total de galones que compro";
            labelGalones.Click += labelGalones_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(175, 360);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(69, 28);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Total: ";
            labelResultado.Click += labelResultado_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCalcular.BackColor = Color.Salmon;
            buttonCalcular.Location = new Point(286, 280);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(158, 52);
            buttonCalcular.TabIndex = 3;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // textBoxDIS
            // 
            textBoxDIS.Location = new Point(240, 97);
            textBoxDIS.Name = "textBoxDIS";
            textBoxDIS.Size = new Size(245, 27);
            textBoxDIS.TabIndex = 4;
            textBoxDIS.TextChanged += textBoxDIS_TextChanged;
            // 
            // textBoxKMgal
            // 
            textBoxKMgal.Location = new Point(240, 204);
            textBoxKMgal.Name = "textBoxKMgal";
            textBoxKMgal.Size = new Size(245, 27);
            textBoxKMgal.TabIndex = 5;
            textBoxKMgal.TextChanged += textBoxKMgal_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxKMgal);
            Controls.Add(textBoxDIS);
            Controls.Add(buttonCalcular);
            Controls.Add(labelResultado);
            Controls.Add(labelGalones);
            Controls.Add(labelDisRecorrida);
            Name = "Form1";
            Text = "Calcular Combustible";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDisRecorrida;
        private Label labelGalones;
        private Label labelResultado;
        private Button buttonCalcular;
        private TextBox textBoxDIS;
        private TextBox textBoxKMgal;
    }
}
