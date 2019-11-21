namespace ExcitingVirtualPet
{
    partial class PetHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WaterButton = new System.Windows.Forms.Button();
            this.PetButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.feedButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.affectionMeter = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.boredomMeter = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.thirstMeter = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.hungerMeter = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.foodAmountBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.waterAmountBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.petPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(492, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Display";
            // 
            // petPictureBox
            // 
            this.petPictureBox.Location = new System.Drawing.Point(9, 29);
            this.petPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(474, 414);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.petPictureBox.TabIndex = 0;
            this.petPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WaterButton);
            this.groupBox2.Controls.Add(this.PetButton);
            this.groupBox2.Controls.Add(this.PlayButton);
            this.groupBox2.Controls.Add(this.feedButton);
            this.groupBox2.Location = new System.Drawing.Point(519, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(334, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pet Controls";
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(9, 74);
            this.WaterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(316, 35);
            this.WaterButton.TabIndex = 0;
            this.WaterButton.Text = "Give Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // PetButton
            // 
            this.PetButton.Location = new System.Drawing.Point(9, 163);
            this.PetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PetButton.Name = "PetButton";
            this.PetButton.Size = new System.Drawing.Size(316, 35);
            this.PetButton.TabIndex = 0;
            this.PetButton.Text = "Pet Cat";
            this.PetButton.UseVisualStyleBackColor = true;
            this.PetButton.Click += new System.EventHandler(this.PetButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(9, 118);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(316, 35);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play With Cat";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(9, 29);
            this.feedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(316, 35);
            this.feedButton.TabIndex = 0;
            this.feedButton.Text = "Feed Pet";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.affectionMeter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.boredomMeter);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.thirstMeter);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.hungerMeter);
            this.groupBox3.Location = new System.Drawing.Point(519, 238);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(334, 243);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pet Facts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Affection";
            // 
            // affectionMeter
            // 
            this.affectionMeter.Location = new System.Drawing.Point(92, 191);
            this.affectionMeter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.affectionMeter.Maximum = 10;
            this.affectionMeter.Name = "affectionMeter";
            this.affectionMeter.Size = new System.Drawing.Size(234, 35);
            this.affectionMeter.Step = 1;
            this.affectionMeter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boredom";
            // 
            // boredomMeter
            // 
            this.boredomMeter.Location = new System.Drawing.Point(92, 134);
            this.boredomMeter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boredomMeter.Maximum = 10;
            this.boredomMeter.Name = "boredomMeter";
            this.boredomMeter.Size = new System.Drawing.Size(234, 35);
            this.boredomMeter.Step = 1;
            this.boredomMeter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thirst";
            // 
            // thirstMeter
            // 
            this.thirstMeter.Location = new System.Drawing.Point(92, 80);
            this.thirstMeter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thirstMeter.Maximum = 10;
            this.thirstMeter.Name = "thirstMeter";
            this.thirstMeter.Size = new System.Drawing.Size(234, 35);
            this.thirstMeter.Step = 1;
            this.thirstMeter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hunger";
            // 
            // hungerMeter
            // 
            this.hungerMeter.Location = new System.Drawing.Point(92, 29);
            this.hungerMeter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hungerMeter.Maximum = 10;
            this.hungerMeter.Name = "hungerMeter";
            this.hungerMeter.Size = new System.Drawing.Size(234, 35);
            this.hungerMeter.Step = 1;
            this.hungerMeter.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.foodAmountBar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.waterAmountBar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(18, 491);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(573, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resources";
            // 
            // foodAmountBar
            // 
            this.foodAmountBar.Location = new System.Drawing.Point(298, 37);
            this.foodAmountBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodAmountBar.Maximum = 10;
            this.foodAmountBar.Name = "foodAmountBar";
            this.foodAmountBar.Size = new System.Drawing.Size(243, 35);
            this.foodAmountBar.Step = 1;
            this.foodAmountBar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Food Dish:";
            // 
            // waterAmountBar
            // 
            this.waterAmountBar.Location = new System.Drawing.Point(21, 37);
            this.waterAmountBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.waterAmountBar.Maximum = 10;
            this.waterAmountBar.Name = "waterAmountBar";
            this.waterAmountBar.Size = new System.Drawing.Size(243, 35);
            this.waterAmountBar.Step = 1;
            this.waterAmountBar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Water Dish:";
            // 
            // PetHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 626);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "PetHome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Virtual Pet";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox petPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Button PetButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar affectionMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar boredomMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar thirstMeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar hungerMeter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar foodAmountBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar waterAmountBar;
        private System.Windows.Forms.Label label5;
    }
}

