namespace RCP
{
    partial class HostCard
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonStartDevice = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            labelHostName = new Label();
            labelStatus = new Label();
            labelDeviceName = new Label();
            labelIP = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 5);
            label1.Margin = new Padding(3, 5, 3, 5);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Device:";
            label1.Click += label1_Click;
            // 
            // buttonStartDevice
            // 
            buttonStartDevice.Location = new Point(15, 51);
            buttonStartDevice.Name = "buttonStartDevice";
            buttonStartDevice.Size = new Size(86, 60);
            buttonStartDevice.TabIndex = 1;
            buttonStartDevice.Text = "Start Device";
            buttonStartDevice.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(107, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 60);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 35);
            label3.Margin = new Padding(3, 5, 3, 5);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 5);
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 35);
            label2.Margin = new Padding(3, 5, 3, 5);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 5);
            label2.Size = new Size(20, 20);
            label2.TabIndex = 1;
            label2.Text = "IP:";
            label2.Click += label2_Click_1;
            // 
            // labelHostName
            // 
            labelHostName.AutoSize = true;
            labelHostName.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHostName.Location = new Point(15, 15);
            labelHostName.Name = "labelHostName";
            labelHostName.Size = new Size(90, 20);
            labelHostName.TabIndex = 3;
            labelHostName.Text = "ServerName";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.ForeColor = Color.Red;
            labelStatus.Location = new Point(227, 15);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(28, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Off";
            labelStatus.Click += labelStatus_Click;
            // 
            // labelDeviceName
            // 
            labelDeviceName.AutoSize = true;
            labelDeviceName.Location = new Point(192, 56);
            labelDeviceName.Margin = new Padding(3, 5, 3, 5);
            labelDeviceName.Name = "labelDeviceName";
            labelDeviceName.Padding = new Padding(0, 0, 0, 5);
            labelDeviceName.Size = new Size(90, 20);
            labelDeviceName.TabIndex = 5;
            labelDeviceName.Text = "DevNameString";
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Location = new Point(192, 86);
            labelIP.Margin = new Padding(3, 5, 3, 5);
            labelIP.Name = "labelIP";
            labelIP.Padding = new Padding(0, 0, 0, 5);
            labelIP.Size = new Size(100, 20);
            labelIP.TabIndex = 3;
            labelIP.Text = "XXX.XXX.XXX.XXX";
            // 
            // HostCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelIP);
            Controls.Add(labelDeviceName);
            Controls.Add(labelStatus);
            Controls.Add(labelHostName);
            Controls.Add(panel1);
            Controls.Add(buttonStartDevice);
            Name = "HostCard";
            Size = new Size(301, 130);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonStartDevice;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label labelHostName;
        private Label labelStatus;
        private Label labelDeviceName;
        private Label labelIP;
    }
}
