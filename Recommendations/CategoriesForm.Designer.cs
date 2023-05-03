namespace Recommendations
{
    partial class CategoriesForm
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
            this.cCloseLabel = new System.Windows.Forms.Label();
            this.autorizationLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fromCatReturnLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gameRB = new System.Windows.Forms.RadioButton();
            this.tVRB = new System.Windows.Forms.RadioButton();
            this.kidRB = new System.Windows.Forms.RadioButton();
            this.phoneRB = new System.Windows.Forms.RadioButton();
            this.computerRB = new System.Windows.Forms.RadioButton();
            this.houseRB = new System.Windows.Forms.RadioButton();
            this.kitchenRB = new System.Windows.Forms.RadioButton();
            this.beautiRB = new System.Windows.Forms.RadioButton();
            this.catDataGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.cCloseLabel);
            this.panel1.Controls.Add(this.autorizationLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cCloseLabel
            // 
            this.cCloseLabel.AutoSize = true;
            this.cCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cCloseLabel.Location = new System.Drawing.Point(615, 9);
            this.cCloseLabel.Name = "cCloseLabel";
            this.cCloseLabel.Size = new System.Drawing.Size(20, 20);
            this.cCloseLabel.TabIndex = 11;
            this.cCloseLabel.Text = "X";
            this.cCloseLabel.Click += new System.EventHandler(this.cCloseLabel_Click);
            // 
            // autorizationLabel
            // 
            this.autorizationLabel.AutoSize = true;
            this.autorizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.autorizationLabel.Location = new System.Drawing.Point(237, 14);
            this.autorizationLabel.Name = "autorizationLabel";
            this.autorizationLabel.Size = new System.Drawing.Size(154, 33);
            this.autorizationLabel.TabIndex = 2;
            this.autorizationLabel.Text = "Категории";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.fromCatReturnLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 38);
            this.panel2.TabIndex = 1;
            // 
            // fromCatReturnLabel
            // 
            this.fromCatReturnLabel.AutoSize = true;
            this.fromCatReturnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromCatReturnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.fromCatReturnLabel.Location = new System.Drawing.Point(12, 13);
            this.fromCatReturnLabel.Name = "fromCatReturnLabel";
            this.fromCatReturnLabel.Size = new System.Drawing.Size(82, 16);
            this.fromCatReturnLabel.TabIndex = 14;
            this.fromCatReturnLabel.Text = "<вернуться";
            this.fromCatReturnLabel.Click += new System.EventHandler(this.fromCatReturnLabel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.catDataGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gameRB);
            this.splitContainer1.Panel2.Controls.Add(this.tVRB);
            this.splitContainer1.Panel2.Controls.Add(this.kidRB);
            this.splitContainer1.Panel2.Controls.Add(this.phoneRB);
            this.splitContainer1.Panel2.Controls.Add(this.computerRB);
            this.splitContainer1.Panel2.Controls.Add(this.houseRB);
            this.splitContainer1.Panel2.Controls.Add(this.kitchenRB);
            this.splitContainer1.Panel2.Controls.Add(this.beautiRB);
            this.splitContainer1.Size = new System.Drawing.Size(638, 333);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 2;
            // 
            // gameRB
            // 
            this.gameRB.AutoSize = true;
            this.gameRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameRB.Location = new System.Drawing.Point(8, 208);
            this.gameRB.Name = "gameRB";
            this.gameRB.Size = new System.Drawing.Size(151, 20);
            this.gameRB.TabIndex = 8;
            this.gameRB.Text = "Игры, развлечения";
            this.gameRB.UseVisualStyleBackColor = true;
            this.gameRB.CheckedChanged += new System.EventHandler(this.gameRB_CheckedChanged);
            // 
            // tVRB
            // 
            this.tVRB.AutoSize = true;
            this.tVRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tVRB.Location = new System.Drawing.Point(8, 26);
            this.tVRB.Name = "tVRB";
            this.tVRB.Size = new System.Drawing.Size(135, 20);
            this.tVRB.TabIndex = 1;
            this.tVRB.Text = "ТВ, аудио, видео";
            this.tVRB.UseVisualStyleBackColor = true;
            this.tVRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // kidRB
            // 
            this.kidRB.AutoSize = true;
            this.kidRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kidRB.Location = new System.Drawing.Point(8, 182);
            this.kidRB.Name = "kidRB";
            this.kidRB.Size = new System.Drawing.Size(130, 20);
            this.kidRB.TabIndex = 7;
            this.kidRB.Text = "Детские товары";
            this.kidRB.UseVisualStyleBackColor = true;
            this.kidRB.CheckedChanged += new System.EventHandler(this.kidRB_CheckedChanged);
            // 
            // phoneRB
            // 
            this.phoneRB.AutoSize = true;
            this.phoneRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneRB.Location = new System.Drawing.Point(8, 78);
            this.phoneRB.Name = "phoneRB";
            this.phoneRB.Size = new System.Drawing.Size(185, 20);
            this.phoneRB.TabIndex = 3;
            this.phoneRB.Text = "Смартфоны, аксессуары";
            this.phoneRB.UseVisualStyleBackColor = true;
            this.phoneRB.CheckedChanged += new System.EventHandler(this.phoneRB_CheckedChanged);
            // 
            // computerRB
            // 
            this.computerRB.AutoSize = true;
            this.computerRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.computerRB.Location = new System.Drawing.Point(8, 156);
            this.computerRB.Name = "computerRB";
            this.computerRB.Size = new System.Drawing.Size(175, 20);
            this.computerRB.TabIndex = 6;
            this.computerRB.Text = "Компьютеры, ноутбуки";
            this.computerRB.UseVisualStyleBackColor = true;
            this.computerRB.CheckedChanged += new System.EventHandler(this.computerRB_CheckedChanged);
            // 
            // houseRB
            // 
            this.houseRB.AutoSize = true;
            this.houseRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.houseRB.Location = new System.Drawing.Point(8, 52);
            this.houseRB.Name = "houseRB";
            this.houseRB.Size = new System.Drawing.Size(51, 20);
            this.houseRB.TabIndex = 2;
            this.houseRB.Text = "Дом";
            this.houseRB.UseVisualStyleBackColor = true;
            this.houseRB.CheckedChanged += new System.EventHandler(this.houseRB_CheckedChanged);
            // 
            // kitchenRB
            // 
            this.kitchenRB.AutoSize = true;
            this.kitchenRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kitchenRB.Location = new System.Drawing.Point(8, 130);
            this.kitchenRB.Name = "kitchenRB";
            this.kitchenRB.Size = new System.Drawing.Size(62, 20);
            this.kitchenRB.TabIndex = 5;
            this.kitchenRB.Text = "Кухня";
            this.kitchenRB.UseVisualStyleBackColor = true;
            this.kitchenRB.CheckedChanged += new System.EventHandler(this.kitchenRB_CheckedChanged);
            // 
            // beautiRB
            // 
            this.beautiRB.AutoSize = true;
            this.beautiRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beautiRB.Location = new System.Drawing.Point(8, 104);
            this.beautiRB.Name = "beautiRB";
            this.beautiRB.Size = new System.Drawing.Size(156, 20);
            this.beautiRB.TabIndex = 4;
            this.beautiRB.Text = "Красота и здоровье";
            this.beautiRB.UseVisualStyleBackColor = true;
            this.beautiRB.CheckedChanged += new System.EventHandler(this.beautiRB_CheckedChanged);
            // 
            // catDataGV
            // 
            this.catDataGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.catDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catDataGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.catDataGV.Location = new System.Drawing.Point(0, 0);
            this.catDataGV.Name = "catDataGV";
            this.catDataGV.Size = new System.Drawing.Size(419, 331);
            this.catDataGV.TabIndex = 0;
            
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catDataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label autorizationLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton gameRB;
        private System.Windows.Forms.RadioButton tVRB;
        private System.Windows.Forms.RadioButton kidRB;
        private System.Windows.Forms.RadioButton phoneRB;
        private System.Windows.Forms.RadioButton computerRB;
        private System.Windows.Forms.RadioButton houseRB;
        private System.Windows.Forms.RadioButton kitchenRB;
        private System.Windows.Forms.RadioButton beautiRB;
        private System.Windows.Forms.Label cCloseLabel;
        private System.Windows.Forms.Label fromCatReturnLabel;
        private System.Windows.Forms.DataGridView catDataGV;
    }
}