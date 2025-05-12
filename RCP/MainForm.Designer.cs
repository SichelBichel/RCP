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
            buttonOpenConfig = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowPanelDevices
            // 
            flowPanelDevices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelDevices.BorderStyle = BorderStyle.FixedSingle;
            flowPanelDevices.Location = new Point(12, 102);
            flowPanelDevices.Name = "flowPanelDevices";
            flowPanelDevices.Size = new Size(942, 369);
            flowPanelDevices.TabIndex = 1;
            flowPanelDevices.Paint += flowPanelDevices_Paint;
            // 
            // buttonReloadConfig
            // 
            buttonReloadConfig.Font = new Font("Impact", 12F);
            buttonReloadConfig.Location = new Point(3, 3);
            buttonReloadConfig.Name = "buttonReloadConfig";
            buttonReloadConfig.Size = new Size(114, 36);
            buttonReloadConfig.TabIndex = 2;
            buttonReloadConfig.Text = "Reload Config";
            buttonReloadConfig.UseVisualStyleBackColor = true;
            buttonReloadConfig.Click += buttonReloadConfig_Click;
            // 
            // buttonOpenConfig
            // 
            buttonOpenConfig.Font = new Font("Impact", 12F);
            buttonOpenConfig.Location = new Point(121, 3);
            buttonOpenConfig.Name = "buttonOpenConfig";
            buttonOpenConfig.Size = new Size(114, 36);
            buttonOpenConfig.TabIndex = 3;
            buttonOpenConfig.Text = "Open Config";
            buttonOpenConfig.UseVisualStyleBackColor = true;
            buttonOpenConfig.Click += openCFG;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonOpenConfig);
            panel1.Controls.Add(buttonReloadConfig);
            panel1.Location = new Point(594, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 43);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 12F);
            button1.Location = new Point(240, 3);
            button1.Name = "button1";
            button1.Size = new Size(114, 36);
            button1.TabIndex = 7;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += inputHelpButton;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ReHoGaBanner3_0_Transparent;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.RCP_Logo;
            pictureBox2.Location = new Point(224, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(853, 73);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 7;
            label1.Text = "Version: 1.0.2";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(621, 73);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(176, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://rehoga-interactive.com/";
            linkLabel1.LinkClicked += urlOpened;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 483);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(flowPanelDevices);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "RCP Remote Control Power";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowPanelDevices;
        private Button buttonReloadConfig;
        private Button buttonOpenConfig;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
