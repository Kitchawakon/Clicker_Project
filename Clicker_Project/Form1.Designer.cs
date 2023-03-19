namespace Clicker_Project
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.UpgradeButton = new System.Windows.Forms.Button();
            this.LevelGem = new System.Windows.Forms.Label();
            this.Helper = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Clicker_Project.Properties.Resources.PrimoemPx;
            this.pictureBox1.Location = new System.Drawing.Point(53, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(164, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click It";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreLabel.Location = new System.Drawing.Point(184, 382);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(38, 39);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "0";
            // 
            // UpgradeButton
            // 
            this.UpgradeButton.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpgradeButton.Location = new System.Drawing.Point(12, 439);
            this.UpgradeButton.Name = "UpgradeButton";
            this.UpgradeButton.Size = new System.Drawing.Size(380, 71);
            this.UpgradeButton.TabIndex = 3;
            this.UpgradeButton.Text = " Upgrade 1 Level\r\n+2 point pre Click\r\nuse 15 point";
            this.UpgradeButton.UseVisualStyleBackColor = true;
            this.UpgradeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelGem
            // 
            this.LevelGem.AutoSize = true;
            this.LevelGem.BackColor = System.Drawing.Color.Transparent;
            this.LevelGem.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LevelGem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LevelGem.Location = new System.Drawing.Point(164, 9);
            this.LevelGem.Name = "LevelGem";
            this.LevelGem.Size = new System.Drawing.Size(85, 28);
            this.LevelGem.TabIndex = 4;
            this.LevelGem.Text = "Level 1";
            // 
            // Helper
            // 
            this.Helper.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Helper.Location = new System.Drawing.Point(12, 516);
            this.Helper.Name = "Helper";
            this.Helper.Size = new System.Drawing.Size(380, 71);
            this.Helper.TabIndex = 5;
            this.Helper.Text = " Buy Helper\r\n+10 point pre Sec\r\nuse 300 point";
            this.Helper.UseVisualStyleBackColor = true;
            this.Helper.Click += new System.EventHandler(this.Helper_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "ticks every 1 sec";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clicker_Project.Properties.Resources.BackGroundPx_jpg;
            this.ClientSize = new System.Drawing.Size(401, 660);
            this.Controls.Add(this.Helper);
            this.Controls.Add(this.LevelGem);
            this.Controls.Add(this.UpgradeButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label ScoreLabel;
        private Button UpgradeButton;
        private Label LevelGem;
        private Button Helper;
        private System.Windows.Forms.Timer timer1;
    }
}