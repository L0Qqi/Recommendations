namespace Recommendations
{
    partial class AutorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.autorizationLabel = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.noAccLabel = new System.Windows.Forms.Label();
            this.toRegLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autorizationLabel
            // 
            this.autorizationLabel.AutoSize = true;
            this.autorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.autorizationLabel.Location = new System.Drawing.Point(73, 26);
            this.autorizationLabel.Name = "autorizationLabel";
            this.autorizationLabel.Size = new System.Drawing.Size(243, 29);
            this.autorizationLabel.TabIndex = 0;
            this.autorizationLabel.Text = "Войдите в аккаунт";
            this.autorizationLabel.Click += new System.EventHandler(this.autorizationLabel_Click);
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(92, 121);
            this.loginTB.Multiline = true;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(207, 42);
            this.loginTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.Location = new System.Drawing.Point(92, 200);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(207, 29);
            this.passwordTB.TabIndex = 2;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(132, 283);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(118, 37);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // noAccLabel
            // 
            this.noAccLabel.Location = new System.Drawing.Point(100, 323);
            this.noAccLabel.Name = "noAccLabel";
            this.noAccLabel.Size = new System.Drawing.Size(82, 13);
            this.noAccLabel.TabIndex = 4;
            this.noAccLabel.Text = "Нет аккаунта?";
            // 
            // toRegLabel
            // 
            this.toRegLabel.AutoSize = true;
            this.toRegLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.toRegLabel.Location = new System.Drawing.Point(178, 323);
            this.toRegLabel.Name = "toRegLabel";
            this.toRegLabel.Size = new System.Drawing.Size(106, 13);
            this.toRegLabel.TabIndex = 5;
            this.toRegLabel.Text = "Зарегистрируйтесь";
            this.toRegLabel.Click += new System.EventHandler(this.toRegLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.autorizationLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 81);
            this.panel1.TabIndex = 6;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toRegLabel);
            this.Controls.Add(this.noAccLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutorizationForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autorizationLabel;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label noAccLabel;
        private System.Windows.Forms.Label toRegLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

