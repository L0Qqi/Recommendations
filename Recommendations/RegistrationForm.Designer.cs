namespace Recommendations
{
    partial class RegistrationForm
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
            this.regLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.telephoneTB = new System.Windows.Forms.TextBox();
            this.bdDateTB = new System.Windows.Forms.TextBox();
            this.loginRegTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cCloseLabel = new System.Windows.Forms.Label();
            this.passwordRegTB = new System.Windows.Forms.TextBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.regLabel.Location = new System.Drawing.Point(99, 45);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(174, 31);
            this.regLabel.TabIndex = 0;
            this.regLabel.Text = "Регистрация";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(90, 95);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(195, 26);
            this.nameTB.TabIndex = 1;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            this.nameTB.Enter += new System.EventHandler(this.nameTB_Enter);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // telephoneTB
            // 
            this.telephoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneTB.Location = new System.Drawing.Point(90, 137);
            this.telephoneTB.Name = "telephoneTB";
            this.telephoneTB.Size = new System.Drawing.Size(195, 26);
            this.telephoneTB.TabIndex = 2;
            this.telephoneTB.Enter += new System.EventHandler(this.telephoneTB_Enter);
            this.telephoneTB.Leave += new System.EventHandler(this.telephoneTB_Leave);
            // 
            // bdDateTB
            // 
            this.bdDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdDateTB.Location = new System.Drawing.Point(90, 182);
            this.bdDateTB.Name = "bdDateTB";
            this.bdDateTB.Size = new System.Drawing.Size(195, 26);
            this.bdDateTB.TabIndex = 3;
            this.bdDateTB.Enter += new System.EventHandler(this.bdDateTB_Enter);
            this.bdDateTB.Leave += new System.EventHandler(this.bdDateTB_Leave);
            // 
            // loginRegTB
            // 
            this.loginRegTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegTB.Location = new System.Drawing.Point(90, 229);
            this.loginRegTB.Name = "loginRegTB";
            this.loginRegTB.Size = new System.Drawing.Size(195, 26);
            this.loginRegTB.TabIndex = 4;
            this.loginRegTB.Enter += new System.EventHandler(this.loginRegTB_Enter);
            this.loginRegTB.Leave += new System.EventHandler(this.loginRegTB_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(90, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Зерегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cCloseLabel
            // 
            this.cCloseLabel.AutoSize = true;
            this.cCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cCloseLabel.Location = new System.Drawing.Point(350, 5);
            this.cCloseLabel.Name = "cCloseLabel";
            this.cCloseLabel.Size = new System.Drawing.Size(20, 20);
            this.cCloseLabel.TabIndex = 11;
            this.cCloseLabel.Text = "X";
            this.cCloseLabel.Click += new System.EventHandler(this.cCloseLabel_Click);
            // 
            // passwordRegTB
            // 
            this.passwordRegTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegTB.Location = new System.Drawing.Point(90, 279);
            this.passwordRegTB.Name = "passwordRegTB";
            this.passwordRegTB.Size = new System.Drawing.Size(195, 26);
            this.passwordRegTB.TabIndex = 12;
            this.passwordRegTB.Enter += new System.EventHandler(this.passwordRegTB_Enter);
            this.passwordRegTB.Leave += new System.EventHandler(this.passwordRegTB_Leave);
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.returnLabel.Location = new System.Drawing.Point(2, 380);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(82, 16);
            this.returnLabel.TabIndex = 13;
            this.returnLabel.Text = "<вернуться";
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(373, 405);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.passwordRegTB);
            this.Controls.Add(this.cCloseLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginRegTB);
            this.Controls.Add(this.bdDateTB);
            this.Controls.Add(this.telephoneTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.regLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox telephoneTB;
        private System.Windows.Forms.TextBox bdDateTB;
        private System.Windows.Forms.TextBox loginRegTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cCloseLabel;
        private System.Windows.Forms.TextBox passwordRegTB;
        private System.Windows.Forms.Label returnLabel;
    }
}