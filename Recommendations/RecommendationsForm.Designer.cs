namespace Recommendations
{
    partial class RecommendationsForm
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
            this.lKLabel = new System.Windows.Forms.Label();
            this.cCloseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.recDataGV = new System.Windows.Forms.DataGridView();
            this.toCategorLabel = new System.Windows.Forms.Label();
            this.toFavLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lKLabel
            // 
            this.lKLabel.AutoSize = true;
            this.lKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lKLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lKLabel.Location = new System.Drawing.Point(16, 16);
            this.lKLabel.Name = "lKLabel";
            this.lKLabel.Size = new System.Drawing.Size(156, 24);
            this.lKLabel.TabIndex = 1;
            this.lKLabel.Text = "Личный кабинет";
            this.lKLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // cCloseLabel
            // 
            this.cCloseLabel.AutoSize = true;
            this.cCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cCloseLabel.Location = new System.Drawing.Point(615, 9);
            this.cCloseLabel.Name = "cCloseLabel";
            this.cCloseLabel.Size = new System.Drawing.Size(20, 20);
            this.cCloseLabel.TabIndex = 10;
            this.cCloseLabel.Text = "X";
            this.cCloseLabel.Click += new System.EventHandler(this.cCloseLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cCloseLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 60);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(179, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Список рекомендаций";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 41);
            this.panel2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(12, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.recDataGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toCategorLabel);
            this.splitContainer1.Panel2.Controls.Add(this.toFavLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lKLabel);
            this.splitContainer1.Size = new System.Drawing.Size(638, 331);
            this.splitContainer1.SplitterDistance = 435;
            this.splitContainer1.TabIndex = 13;
            // 
            // recDataGV
            // 
            this.recDataGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.recDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recDataGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.recDataGV.Location = new System.Drawing.Point(0, 0);
            this.recDataGV.Name = "recDataGV";
            this.recDataGV.Size = new System.Drawing.Size(433, 329);
            this.recDataGV.TabIndex = 0;
            // 
            // toCategorLabel
            // 
            this.toCategorLabel.AutoSize = true;
            this.toCategorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toCategorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.toCategorLabel.Location = new System.Drawing.Point(16, 103);
            this.toCategorLabel.Name = "toCategorLabel";
            this.toCategorLabel.Size = new System.Drawing.Size(106, 24);
            this.toCategorLabel.TabIndex = 3;
            this.toCategorLabel.Text = "Категории";
            this.toCategorLabel.Click += new System.EventHandler(this.toCategorLabel_Click);
            // 
            // toFavLabel
            // 
            this.toFavLabel.AutoSize = true;
            this.toFavLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toFavLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.toFavLabel.Location = new System.Drawing.Point(16, 58);
            this.toFavLabel.Name = "toFavLabel";
            this.toFavLabel.Size = new System.Drawing.Size(109, 24);
            this.toFavLabel.TabIndex = 2;
            this.toFavLabel.Text = "Избранное";
            this.toFavLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RecommendationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecommendationsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RecommendationsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lKLabel;
        private System.Windows.Forms.Label cCloseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label toCategorLabel;
        private System.Windows.Forms.Label toFavLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView recDataGV;
    }
}