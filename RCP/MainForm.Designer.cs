namespace RCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            flowPanelDevices = new FlowLayoutPanel();
            buttonReloadConfig = new Button();
            SuspendLayout();
            // 
            // flowPanelDevices
            // 
            flowPanelDevices.Location = new Point(12, 69);
            flowPanelDevices.Name = "flowPanelDevices";
            flowPanelDevices.Size = new Size(776, 369);
            flowPanelDevices.TabIndex = 1;
            // 
            // buttonReloadConfig
            // 
            buttonReloadConfig.Font = new Font("Impact", 12F);
            buttonReloadConfig.Location = new Point(319, 18);
            buttonReloadConfig.Name = "buttonReloadConfig";
            buttonReloadConfig.Size = new Size(114, 31);
            buttonReloadConfig.TabIndex = 2;
            buttonReloadConfig.Text = "Reload Config";
            buttonReloadConfig.UseVisualStyleBackColor = true;
            buttonReloadConfig.Click += buttonReloadConfig_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReloadConfig);
            Controls.Add(flowPanelDevices);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "RCP Remote Control Power";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowPanelDevices;
        private Button buttonReloadConfig;
    }
}
