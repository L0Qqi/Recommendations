namespace Recommendations
{
    partial class SettingsForm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.cCloseLabel = new System.Windows.Forms.Label();
            this.objectsCheckLB = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(79, 388);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(156, 33);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cCloseLabel
            // 
            this.cCloseLabel.AutoSize = true;
            this.cCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cCloseLabel.Location = new System.Drawing.Point(301, 2);
            this.cCloseLabel.Name = "cCloseLabel";
            this.cCloseLabel.Size = new System.Drawing.Size(20, 20);
            this.cCloseLabel.TabIndex = 12;
            this.cCloseLabel.Text = "X";
            this.cCloseLabel.Click += new System.EventHandler(this.cCloseLabel_Click);
            // 
            // objectsCheckLB
            // 
            this.objectsCheckLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.objectsCheckLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectsCheckLB.FormattingEnabled = true;
            this.objectsCheckLB.Items.AddRange(new object[] {
            "ТВ, аудио, видео",
            "Дом",
            "Смартфоны, аксессуары",
            "Красота и здоровье",
            "Кухня",
            "Компьютеры, ноутбуки",
            "Детские товары",
            "Игры, развлечения"});
            this.objectsCheckLB.Location = new System.Drawing.Point(22, 30);
            this.objectsCheckLB.Name = "objectsCheckLB";
            this.objectsCheckLB.Size = new System.Drawing.Size(275, 319);
            this.objectsCheckLB.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(322, 433);
            this.Controls.Add(this.objectsCheckLB);
            this.Controls.Add(this.cCloseLabel);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label cCloseLabel;
        private System.Windows.Forms.CheckedListBox objectsCheckLB;
    }
}