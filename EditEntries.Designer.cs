namespace Delegate_Practice_Form
{
    partial class EditEntries
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxStringList = new System.Windows.Forms.ListBox();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.textBoxEntryInput = new System.Windows.Forms.TextBox();
            this.labelEntryHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(206, 444);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxStringList
            // 
            this.listBoxStringList.FormattingEnabled = true;
            this.listBoxStringList.HorizontalScrollbar = true;
            this.listBoxStringList.ItemHeight = 16;
            this.listBoxStringList.Location = new System.Drawing.Point(12, 12);
            this.listBoxStringList.Name = "listBoxStringList";
            this.listBoxStringList.Size = new System.Drawing.Size(226, 420);
            this.listBoxStringList.TabIndex = 1;
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.Location = new System.Drawing.Point(308, 136);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(94, 27);
            this.buttonAddEntry.TabIndex = 2;
            this.buttonAddEntry.Text = "Add Entry";
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            this.buttonAddEntry.Click += new System.EventHandler(this.buttonAddEntry_Click);
            // 
            // textBoxEntryInput
            // 
            this.textBoxEntryInput.Location = new System.Drawing.Point(260, 108);
            this.textBoxEntryInput.Name = "textBoxEntryInput";
            this.textBoxEntryInput.Size = new System.Drawing.Size(193, 22);
            this.textBoxEntryInput.TabIndex = 3;
            // 
            // labelEntryHeader
            // 
            this.labelEntryHeader.AutoSize = true;
            this.labelEntryHeader.Location = new System.Drawing.Point(257, 88);
            this.labelEntryHeader.Name = "labelEntryHeader";
            this.labelEntryHeader.Size = new System.Drawing.Size(136, 17);
            this.labelEntryHeader.TabIndex = 4;
            this.labelEntryHeader.Text = "Text To Add To List:";
            // 
            // EditEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 479);
            this.Controls.Add(this.labelEntryHeader);
            this.Controls.Add(this.textBoxEntryInput);
            this.Controls.Add(this.buttonAddEntry);
            this.Controls.Add(this.listBoxStringList);
            this.Controls.Add(this.buttonClose);
            this.Name = "EditEntries";
            this.Text = "EditEntries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxStringList;
        private System.Windows.Forms.Button buttonAddEntry;
        private System.Windows.Forms.TextBox textBoxEntryInput;
        private System.Windows.Forms.Label labelEntryHeader;
    }
}