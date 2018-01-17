namespace FileComparator
{
    partial class MainFrm
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
            this.SelectBtn = new System.Windows.Forms.Button();
            this.FileSelectionLbl = new System.Windows.Forms.Label();
            this.ParentRBtn = new System.Windows.Forms.RadioButton();
            this.ChildRBtn = new System.Windows.Forms.RadioButton();
            this.GBoxTop = new System.Windows.Forms.GroupBox();
            this.GBoxBottom = new System.Windows.Forms.GroupBox();
            this.ComparePCBtn = new System.Windows.Forms.Button();
            this.GBoxTop.SuspendLayout();
            this.GBoxBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(115, 60);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(91, 23);
            this.SelectBtn.TabIndex = 0;
            this.SelectBtn.Text = "Select File";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // FileSelectionLbl
            // 
            this.FileSelectionLbl.AutoSize = true;
            this.FileSelectionLbl.Location = new System.Drawing.Point(112, 44);
            this.FileSelectionLbl.Name = "FileSelectionLbl";
            this.FileSelectionLbl.Size = new System.Drawing.Size(94, 13);
            this.FileSelectionLbl.TabIndex = 1;
            this.FileSelectionLbl.Text = "No File Selected...";
            // 
            // ParentRBtn
            // 
            this.ParentRBtn.AutoSize = true;
            this.ParentRBtn.Checked = true;
            this.ParentRBtn.Location = new System.Drawing.Point(27, 43);
            this.ParentRBtn.Name = "ParentRBtn";
            this.ParentRBtn.Size = new System.Drawing.Size(56, 17);
            this.ParentRBtn.TabIndex = 3;
            this.ParentRBtn.TabStop = true;
            this.ParentRBtn.Text = "Parent";
            this.ParentRBtn.UseVisualStyleBackColor = true;
            // 
            // ChildRBtn
            // 
            this.ChildRBtn.AutoSize = true;
            this.ChildRBtn.Location = new System.Drawing.Point(27, 66);
            this.ChildRBtn.Name = "ChildRBtn";
            this.ChildRBtn.Size = new System.Drawing.Size(48, 17);
            this.ChildRBtn.TabIndex = 5;
            this.ChildRBtn.Text = "Child";
            this.ChildRBtn.UseVisualStyleBackColor = true;
            // 
            // GBoxTop
            // 
            this.GBoxTop.Controls.Add(this.ParentRBtn);
            this.GBoxTop.Controls.Add(this.ChildRBtn);
            this.GBoxTop.Controls.Add(this.SelectBtn);
            this.GBoxTop.Controls.Add(this.FileSelectionLbl);
            this.GBoxTop.Location = new System.Drawing.Point(32, 31);
            this.GBoxTop.Name = "GBoxTop";
            this.GBoxTop.Size = new System.Drawing.Size(241, 110);
            this.GBoxTop.TabIndex = 6;
            this.GBoxTop.TabStop = false;
            this.GBoxTop.Text = "Save Files";
            // 
            // GBoxBottom
            // 
            this.GBoxBottom.Controls.Add(this.ComparePCBtn);
            this.GBoxBottom.Location = new System.Drawing.Point(32, 162);
            this.GBoxBottom.Name = "GBoxBottom";
            this.GBoxBottom.Size = new System.Drawing.Size(241, 113);
            this.GBoxBottom.TabIndex = 8;
            this.GBoxBottom.TabStop = false;
            this.GBoxBottom.Text = "Compare Child to Parent";
            // 
            // ComparePCBtn
            // 
            this.ComparePCBtn.Location = new System.Drawing.Point(71, 36);
            this.ComparePCBtn.Name = "ComparePCBtn";
            this.ComparePCBtn.Size = new System.Drawing.Size(95, 53);
            this.ComparePCBtn.TabIndex = 0;
            this.ComparePCBtn.Text = "Select Both Files to Compare";
            this.ComparePCBtn.UseVisualStyleBackColor = true;
            this.ComparePCBtn.Click += new System.EventHandler(this.ComparePCBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 304);
            this.Controls.Add(this.GBoxBottom);
            this.Controls.Add(this.GBoxTop);
            this.Name = "MainFrm";
            this.Text = "FileComparator by Edison Earnest";
            this.GBoxTop.ResumeLayout(false);
            this.GBoxTop.PerformLayout();
            this.GBoxBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Label FileSelectionLbl;
        private System.Windows.Forms.RadioButton ParentRBtn;
        private System.Windows.Forms.RadioButton ChildRBtn;
        private System.Windows.Forms.GroupBox GBoxTop;
        private System.Windows.Forms.GroupBox GBoxBottom;
        private System.Windows.Forms.Button ComparePCBtn;
    }
}

