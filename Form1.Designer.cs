namespace Delegate_Practice_Form
{
    partial class StringListPropertyProgram
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
            this.listStringList = new System.Windows.Forms.ListView();
            this.labelStringListHeader = new System.Windows.Forms.Label();
            this.buttonListEdit = new System.Windows.Forms.Button();
            this.labelWordsLessThan3 = new System.Windows.Forms.Label();
            this.labelStringsWithLetterT = new System.Windows.Forms.Label();
            this.labelStringsWithOddNumbers = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStringStatsHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listStringList
            // 
            this.listStringList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listStringList.AutoArrange = false;
            this.listStringList.GridLines = true;
            this.listStringList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listStringList.LabelWrap = false;
            this.listStringList.Location = new System.Drawing.Point(309, 104);
            this.listStringList.Name = "listStringList";
            this.listStringList.Size = new System.Drawing.Size(161, 251);
            this.listStringList.TabIndex = 0;
            this.listStringList.UseCompatibleStateImageBehavior = false;
            this.listStringList.View = System.Windows.Forms.View.List;
            // 
            // labelStringListHeader
            // 
            this.labelStringListHeader.AutoSize = true;
            this.labelStringListHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStringListHeader.Location = new System.Drawing.Point(306, 84);
            this.labelStringListHeader.Name = "labelStringListHeader";
            this.labelStringListHeader.Size = new System.Drawing.Size(87, 17);
            this.labelStringListHeader.TabIndex = 1;
            this.labelStringListHeader.Text = "String List:";
            // 
            // buttonListEdit
            // 
            this.buttonListEdit.Location = new System.Drawing.Point(349, 361);
            this.buttonListEdit.Name = "buttonListEdit";
            this.buttonListEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonListEdit.TabIndex = 2;
            this.buttonListEdit.Text = "Edit";
            this.buttonListEdit.UseVisualStyleBackColor = true;
            this.buttonListEdit.Click += new System.EventHandler(this.ButtonListEdit_Click);
            // 
            // labelWordsLessThan3
            // 
            this.labelWordsLessThan3.AutoSize = true;
            this.labelWordsLessThan3.Location = new System.Drawing.Point(13, 146);
            this.labelWordsLessThan3.Name = "labelWordsLessThan3";
            this.labelWordsLessThan3.Size = new System.Drawing.Size(248, 17);
            this.labelWordsLessThan3.TabIndex = 3;
            this.labelWordsLessThan3.Text = "Strings With Fewer Than 3 Characters";
            // 
            // labelStringsWithLetterT
            // 
            this.labelStringsWithLetterT.AutoSize = true;
            this.labelStringsWithLetterT.Location = new System.Drawing.Point(13, 205);
            this.labelStringsWithLetterT.Name = "labelStringsWithLetterT";
            this.labelStringsWithLetterT.Size = new System.Drawing.Size(216, 17);
            this.labelStringsWithLetterT.TabIndex = 5;
            this.labelStringsWithLetterT.Text = "Strings Containing The Letter \"T\"";
            // 
            // labelStringsWithOddNumbers
            // 
            this.labelStringsWithOddNumbers.AutoSize = true;
            this.labelStringsWithOddNumbers.Location = new System.Drawing.Point(12, 262);
            this.labelStringsWithOddNumbers.Name = "labelStringsWithOddNumbers";
            this.labelStringsWithOddNumbers.Size = new System.Drawing.Size(257, 17);
            this.labelStringsWithOddNumbers.TabIndex = 7;
            this.labelStringsWithOddNumbers.Text = "Strings With An Odd Number Of Letters";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(177, 418);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(122, 23);
            this.buttonRun.TabIndex = 11;
            this.buttonRun.Text = "Generate Stats";
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(120, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(229, 32);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "String Statistics";
            // 
            // labelStringStatsHeader
            // 
            this.labelStringStatsHeader.AutoSize = true;
            this.labelStringStatsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStringStatsHeader.Location = new System.Drawing.Point(13, 128);
            this.labelStringStatsHeader.Name = "labelStringStatsHeader";
            this.labelStringStatsHeader.Size = new System.Drawing.Size(98, 17);
            this.labelStringStatsHeader.TabIndex = 13;
            this.labelStringStatsHeader.Text = "String Stats:";
            // 
            // StringListPropertyProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.labelStringStatsHeader);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStringsWithOddNumbers);
            this.Controls.Add(this.labelStringsWithLetterT);
            this.Controls.Add(this.labelWordsLessThan3);
            this.Controls.Add(this.buttonListEdit);
            this.Controls.Add(this.labelStringListHeader);
            this.Controls.Add(this.listStringList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "StringListPropertyProgram";
            this.Text = "String Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStringList;
        private System.Windows.Forms.Label labelStringListHeader;
        private System.Windows.Forms.Button buttonListEdit;
        private System.Windows.Forms.Label labelWordsLessThan3;
        private System.Windows.Forms.Label labelStringsWithLetterT;
        private System.Windows.Forms.Label labelStringsWithOddNumbers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStringStatsHeader;
    }
}

