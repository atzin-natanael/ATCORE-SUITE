namespace ATCORE_SUITE.ChildForms
{
    partial class MensajeError
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
            Titulo = new Label();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(94, 141);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(620, 184);
            Titulo.TabIndex = 0;
            Titulo.Text = ".";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MensajeError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Titulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MensajeError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MensajeError";
            WindowState = FormWindowState.Maximized;
            KeyPress += MensajeError_KeyPress;
            ResumeLayout(false);
        }

        #endregion

        public Label Titulo;
    }
}