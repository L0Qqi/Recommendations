namespace Recommendations
{
    partial class PersonalAccountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.forMeButton = new System.Windows.Forms.Button();
            this.basketButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameShowLabel = new System.Windows.Forms.Label();
            this.adressShowLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.adressShowLabel);
            this.panel1.Controls.Add(this.nameShowLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.basketButton);
            this.panel1.Controls.Add(this.forMeButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.adressLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 307);
            this.panel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(159, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя:";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLabel.Location = new System.Drawing.Point(159, 77);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(137, 20);
            this.adressLabel.TabIndex = 1;
            this.adressLabel.Text = "Адрес доставки:";
            // 
            // forMeButton
            // 
            this.forMeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.forMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forMeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.forMeButton.Location = new System.Drawing.Point(15, 172);
            this.forMeButton.Name = "forMeButton";
            this.forMeButton.Size = new System.Drawing.Size(158, 33);
            this.forMeButton.TabIndex = 3;
            this.forMeButton.Text = "Предложения для меня";
            this.forMeButton.UseVisualStyleBackColor = false;
            this.forMeButton.Click += new System.EventHandler(this.forMeButton_Click);
            // 
            // basketButton
            // 
            this.basketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.basketButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.basketButton.Location = new System.Drawing.Point(15, 233);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(158, 33);
            this.basketButton.TabIndex = 4;
            this.basketButton.Text = "Корзина";
            this.basketButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.button1.Location = new System.Drawing.Point(235, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Заказы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(235, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // nameShowLabel
            // 
            this.nameShowLabel.AutoSize = true;
            this.nameShowLabel.Location = new System.Drawing.Point(210, 39);
            this.nameShowLabel.Name = "nameShowLabel";
            this.nameShowLabel.Size = new System.Drawing.Size(86, 13);
            this.nameShowLabel.TabIndex = 7;
            this.nameShowLabel.Text = "nameShowLabel";
            // 
            // adressShowLabel
            // 
            this.adressShowLabel.AutoSize = true;
            this.adressShowLabel.Location = new System.Drawing.Point(302, 82);
            this.adressShowLabel.Name = "adressShowLabel";
            this.adressShowLabel.Size = new System.Drawing.Size(91, 13);
            this.adressShowLabel.TabIndex = 8;
            this.adressShowLabel.Text = "adressShowLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.pictureBox1.Image = global::Recommendations.Properties.Resources.user_proj;
            this.pictureBox1.Location = new System.Drawing.Point(15, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PersonalAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(461, 347);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalAccountForm";
            this.Text = "PersonalAccountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label adressShowLabel;
        private System.Windows.Forms.Label nameShowLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.Button forMeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adressLabel;
    }
}