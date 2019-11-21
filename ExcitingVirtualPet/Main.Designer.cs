namespace ExcitingVirtualPet
{
    partial class Main
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
            this.PetName = new System.Windows.Forms.Label();
            this.nameOfPet = new System.Windows.Forms.TextBox();
            this.CatButton = new System.Windows.Forms.Button();
            this.DogButton = new System.Windows.Forms.Button();
            this.BirdButton = new System.Windows.Forms.Button();
            this.LizardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PetName
            // 
            this.PetName.Location = new System.Drawing.Point(8, 40);
            this.PetName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PetName.Name = "PetName";
            this.PetName.Size = new System.Drawing.Size(88, 37);
            this.PetName.TabIndex = 0;
            this.PetName.Text = "Name:";
            this.PetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameOfPet
            // 
            this.nameOfPet.Location = new System.Drawing.Point(104, 40);
            this.nameOfPet.Name = "nameOfPet";
            this.nameOfPet.Size = new System.Drawing.Size(136, 35);
            this.nameOfPet.TabIndex = 1;
            // 
            // CatButton
            // 
            this.CatButton.Location = new System.Drawing.Point(24, 112);
            this.CatButton.Name = "CatButton";
            this.CatButton.Size = new System.Drawing.Size(88, 48);
            this.CatButton.TabIndex = 2;
            this.CatButton.Text = "Cat";
            this.CatButton.UseVisualStyleBackColor = true;
            this.CatButton.Click += new System.EventHandler(this.CatButton_Click);
            // 
            // DogButton
            // 
            this.DogButton.Location = new System.Drawing.Point(24, 176);
            this.DogButton.Name = "DogButton";
            this.DogButton.Size = new System.Drawing.Size(88, 40);
            this.DogButton.TabIndex = 3;
            this.DogButton.Text = "Dog";
            this.DogButton.UseVisualStyleBackColor = true;
            this.DogButton.Click += new System.EventHandler(this.DogButton_Click);
            // 
            // BirdButton
            // 
            this.BirdButton.Location = new System.Drawing.Point(160, 112);
            this.BirdButton.Name = "BirdButton";
            this.BirdButton.Size = new System.Drawing.Size(96, 40);
            this.BirdButton.TabIndex = 4;
            this.BirdButton.Text = "Bird";
            this.BirdButton.UseVisualStyleBackColor = true;
            this.BirdButton.Click += new System.EventHandler(this.BirdButton_Click);
            // 
            // LizardButton
            // 
            this.LizardButton.Location = new System.Drawing.Point(160, 176);
            this.LizardButton.Name = "LizardButton";
            this.LizardButton.Size = new System.Drawing.Size(96, 40);
            this.LizardButton.TabIndex = 5;
            this.LizardButton.Text = "Lizard";
            this.LizardButton.UseVisualStyleBackColor = true;
            this.LizardButton.Click += new System.EventHandler(this.LizardButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 249);
            this.Controls.Add(this.LizardButton);
            this.Controls.Add(this.BirdButton);
            this.Controls.Add(this.DogButton);
            this.Controls.Add(this.CatButton);
            this.Controls.Add(this.nameOfPet);
            this.Controls.Add(this.PetName);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PetName;
        private System.Windows.Forms.TextBox nameOfPet;
        private System.Windows.Forms.Button CatButton;
        private System.Windows.Forms.Button DogButton;
        private System.Windows.Forms.Button BirdButton;
        private System.Windows.Forms.Button LizardButton;
    }
}