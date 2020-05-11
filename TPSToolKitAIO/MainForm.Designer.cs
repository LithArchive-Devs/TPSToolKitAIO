namespace TPSToolKitAIO
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBasic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAllTools = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkMPGH = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasic
            // 
            this.btnBasic.Location = new System.Drawing.Point(12, 114);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(225, 135);
            this.btnBasic.TabIndex = 1;
            this.btnBasic.Text = "Basic Tools\r\n-LTB2LTA GUI\r\n-RezInject\r\n-RezXtract\r\n-DTXViewer\r\n-DTXConvert";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TPSToolKitAIO.Properties.Resources.TPS;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = global::TPSToolKitAIO.Properties.Resources.TPS;
            this.pictureBox1.InitialImage = global::TPSToolKitAIO.Properties.Resources.TPS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAllTools
            // 
            this.btnAllTools.Location = new System.Drawing.Point(247, 114);
            this.btnAllTools.Name = "btnAllTools";
            this.btnAllTools.Size = new System.Drawing.Size(225, 135);
            this.btnAllTools.TabIndex = 2;
            this.btnAllTools.Text = "Full Tool Kit\r\n-Basic Tools\r\n-Dedit\r\n-fxED\r\n-ModelEdit\r\n-LTAViewer\r\n-RSEditor\r\n-W" +
    "AV Editor\r\n";
            this.btnAllTools.UseVisualStyleBackColor = true;
            this.btnAllTools.Click += new System.EventHandler(this.btnAllTools_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created By: TechX\r\nFor Use with Lithtech Based Games";
            // 
            // lnkMPGH
            // 
            this.lnkMPGH.AutoSize = true;
            this.lnkMPGH.Location = new System.Drawing.Point(244, 252);
            this.lnkMPGH.Name = "lnkMPGH";
            this.lnkMPGH.Size = new System.Drawing.Size(39, 13);
            this.lnkMPGH.TabIndex = 4;
            this.lnkMPGH.TabStop = true;
            this.lnkMPGH.Text = "MPGH";
            this.lnkMPGH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMPGH_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.lnkMPGH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllTools);
            this.Controls.Add(this.btnBasic);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TPS ToolKit AIO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnAllTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkMPGH;
    }
}

