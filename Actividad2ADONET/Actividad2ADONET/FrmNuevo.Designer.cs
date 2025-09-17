namespace Actividad2ADONET
{
    partial class FrmNuevo
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
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtedad = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(283, 210);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 32);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 111);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Edad";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(171, 56);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 3;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(171, 108);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(100, 23);
            txtedad.TabIndex = 4;
            // 
            // FrmNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 265);
            Controls.Add(txtedad);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Name = "FrmNuevo";
            Text = "FrmNuevo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtedad;
    }
}