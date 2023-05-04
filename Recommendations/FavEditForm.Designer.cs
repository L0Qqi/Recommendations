namespace Recommendations
{
    partial class FavEditForm
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
            this.fromFavDelButton = new System.Windows.Forms.Button();
            this.cCloseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 352);
            this.panel1.TabIndex = 1;
            // 
            // fromFavDelButton
            // 
            this.fromFavDelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.fromFavDelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fromFavDelButton.Location = new System.Drawing.Point(114, 406);
            this.fromFavDelButton.Name = "fromFavDelButton";
            this.fromFavDelButton.Size = new System.Drawing.Size(120, 32);
            this.fromFavDelButton.TabIndex = 15;
            this.fromFavDelButton.Text = "Удалить";
            this.fromFavDelButton.UseVisualStyleBackColor = false;
            // 
            // cCloseLabel
            // 
            this.cCloseLabel.AllowDrop = true;
            this.cCloseLabel.AutoSize = true;
            this.cCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cCloseLabel.Location = new System.Drawing.Point(340, 6);
            this.cCloseLabel.Name = "cCloseLabel";
            this.cCloseLabel.Size = new System.Drawing.Size(15, 16);
            this.cCloseLabel.TabIndex = 16;
            this.cCloseLabel.Text = "X";
            this.cCloseLabel.Click += new System.EventHandler(this.cCloseLabel_Click);
            // 
            // FavEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.cCloseLabel);
            this.Controls.Add(this.fromFavDelButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FavEditForm";
            this.Text = "FavEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fromFavDelButton;
        private System.Windows.Forms.Label cCloseLabel;
    }
}