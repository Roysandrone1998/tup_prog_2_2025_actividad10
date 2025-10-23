namespace ejer1
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            lsbVerSolicitudesImportaadas = new ListBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(26, 63);
            button1.Name = "button1";
            button1.Size = new Size(201, 51);
            button1.TabIndex = 0;
            button1.Text = "Importar Solicitudes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lsbVerSolicitudesImportaadas
            // 
            lsbVerSolicitudesImportaadas.FormattingEnabled = true;
            lsbVerSolicitudesImportaadas.ItemHeight = 15;
            lsbVerSolicitudesImportaadas.Location = new Point(26, 141);
            lsbVerSolicitudesImportaadas.Name = "lsbVerSolicitudesImportaadas";
            lsbVerSolicitudesImportaadas.Size = new Size(293, 139);
            lsbVerSolicitudesImportaadas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 450);
            Controls.Add(lsbVerSolicitudesImportaadas);
            Controls.Add(button1);
            Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private ListBox lsbVerSolicitudesImportaadas;
    }
}
