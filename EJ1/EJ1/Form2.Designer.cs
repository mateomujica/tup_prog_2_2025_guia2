namespace EJ1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxDNI = new TextBox();
            tbxNombre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            DNI = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbxDNI
            // 
            tbxDNI.Location = new Point(135, 40);
            tbxDNI.Name = "tbxDNI";
            tbxDNI.Size = new Size(100, 23);
            tbxDNI.TabIndex = 0;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(135, 125);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(100, 23);
            tbxNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(79, 182);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(225, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Location = new Point(40, 40);
            DNI.Name = "DNI";
            DNI.Size = new Size(27, 15);
            DNI.TabIndex = 4;
            DNI.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 128);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 254);
            Controls.Add(label2);
            Controls.Add(DNI);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbxNombre);
            Controls.Add(tbxDNI);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxDNI;
        private TextBox tbxNombre;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label DNI;
        private Label label2;
    }
}