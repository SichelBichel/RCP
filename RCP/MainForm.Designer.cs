namespace RCR
{
    partial class MainForm
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
            buttonStartServer = new Button();
            SuspendLayout();
            // 
            // buttonStartServer
            // 
            buttonStartServer.Location = new Point(205, 149);
            buttonStartServer.Name = "buttonStartServer";
            buttonStartServer.Size = new Size(311, 128);
            buttonStartServer.TabIndex = 0;
            buttonStartServer.Text = "button1";
            buttonStartServer.UseVisualStyleBackColor = true;
            buttonStartServer.Click += inputStartServer;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStartServer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "RCP Remote Control Power";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStartServer;
    }
}
