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
            this.toCatButton = new System.Windows.Forms.Button();
            this.toRecButton = new System.Windows.Forms.Button();
            this.toFavButton = new System.Windows.Forms.Button();
            this.recSettingsButton = new System.Windows.Forms.Button();
            this.nameShowLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cCloseLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.toCatButton);
            this.panel1.Controls.Add(this.toRecButton);
            this.panel1.Controls.Add(this.toFavButton);
            this.panel1.Controls.Add(this.recSettingsButton);
            this.panel1.Controls.Add(this.nameShowLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 307);
            this.panel1.TabIndex = 0;
            // 
            // toCatButton
            // 
            this.toCatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.toCatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.toCatButton.Location = new System.Drawing.Point(15, 233);
            this.toCatButton.Name = "toCatButton";
            this.toCatButton.Size = new System.Drawing.Size(158, 43);
            this.toCatButton.TabIndex = 13;
            this.toCatButton.Text = "Категории";
            this.toCatButton.UseVisualStyleBackColor = false;
            this.toCatButton.Click += new System.EventHandler(this.toCatButton_Click);
            // 
            // toRecButton
            // 
            this.toRecButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.toRecButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.toRecButton.Location = new System.Drawing.Point(235, 233);
            this.toRecButton.Name = "toRecButton";
            this.toRecButton.Size = new System.Drawing.Size(158, 43);
            this.toRecButton.TabIndex = 12;
            this.toRecButton.Text = "Список рекомендаций";
            this.toRecButton.UseVisualStyleBackColor = false;
            this.toRecButton.Click += new System.EventHandler(this.toRecButton_Click);
            // 
            // toFavButton
            // 
            this.toFavButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.toFavButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.toFavButton.Location = new System.Drawing.Point(235, 160);
            this.toFavButton.Name = "toFavButton";
            this.toFavButton.Size = new System.Drawing.Size(158, 43);
            this.toFavButton.TabIndex = 11;
            this.toFavButton.Text = "Избранные";
            this.toFavButton.UseVisualStyleBackColor = false;
            this.toFavButton.Click += new System.EventHandler(this.toFavButton_Click);
            // 
            // recSettingsButton
            // 
            this.recSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.recSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.recSettingsButton.Location = new System.Drawing.Point(15, 160);
            this.recSettingsButton.Name = "recSettingsButton";
            this.recSettingsButton.Size = new System.Drawing.Size(158, 43);
            this.recSettingsButton.TabIndex = 10;
            this.recSettingsButton.Text = "Настройки списка рекомендаций";
            this.recSettingsButton.UseVisualStyleBackColor = false;
            this.recSettingsButton.Click += new System.EventHandler(this.recSettingsButton_Click);
            // 
            // nameShowLabel
            // 
            this.nameShowLabel.AutoSize = true;
            this.nameShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameShowLabel.Location = new System.Drawing.Point(209, 34);
            this.nameShowLabel.Name = "nameShowLabel";
            this.nameShowLabel.Size = new System.Drawing.Size(128, 20);
            this.nameShowLabel.TabIndex = 7;
            this.nameShowLabel.Text = "nameShowLabel";
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
            // cCloseLabel
            // 
            this.cCloseLabel.AutoSize = true;
            this.cCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cCloseLabel.Location = new System.Drawing.Point(444, 3);
            this.cCloseLabel.Name = "cCloseLabel";
            this.cCloseLabel.Size = new System.Drawing.Size(15, 16);
            this.cCloseLabel.TabIndex = 12;
            this.cCloseLabel.Text = "X";
            this.cCloseLabel.Click += new System.EventHandler(this.cCloseLabel_Click);
            // 
            // PersonalAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(461, 347);
            this.Controls.Add(this.cCloseLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalAccountForm";
            this.Text = "PersonalAccountForm";
            this.Load += new System.EventHandler(this.PersonalAccountForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameShowLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button toCatButton;
        private System.Windows.Forms.Button toRecButton;
        private System.Windows.Forms.Button toFavButton;
        private System.Windows.Forms.Button recSettingsButton;
        private System.Windows.Forms.Label cCloseLabel;
    }
}