namespace NoteAppUI
{
    partial class NoteForm
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
            this.ShowTitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategorysComboBox = new System.Windows.Forms.ComboBox();
            this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.ChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowTitleLabel
            // 
            this.ShowTitleLabel.AutoSize = true;
            this.ShowTitleLabel.Location = new System.Drawing.Point(16, 32);
            this.ShowTitleLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ShowTitleLabel.Name = "ShowTitleLabel";
            this.ShowTitleLabel.Size = new System.Drawing.Size(39, 17);
            this.ShowTitleLabel.TabIndex = 7;
            this.ShowTitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(16, 64);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 8;
            this.CategoryLabel.Text = "Category:";
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Location = new System.Drawing.Point(16, 101);
            this.CreateLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(62, 17);
            this.CreateLabel.TabIndex = 9;
            this.CreateLabel.Text = "Created:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(92, 28);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleTextBox.MaxLength = 50;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(940, 22);
            this.TitleTextBox.TabIndex = 0;
            // 
            // CategorysComboBox
            // 
            this.CategorysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorysComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategorysComboBox.FormattingEnabled = true;
            this.CategorysComboBox.Location = new System.Drawing.Point(92, 57);
            this.CategorysComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategorysComboBox.Name = "CategorysComboBox";
            this.CategorysComboBox.Size = new System.Drawing.Size(160, 24);
            this.CategorysComboBox.TabIndex = 1;
            // 
            // CreateDateTimePicker
            // 
            this.CreateDateTimePicker.Enabled = false;
            this.CreateDateTimePicker.Location = new System.Drawing.Point(92, 96);
            this.CreateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.CreateDateTimePicker.Name = "CreateDateTimePicker";
            this.CreateDateTimePicker.Size = new System.Drawing.Size(185, 22);
            this.CreateDateTimePicker.TabIndex = 2;
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Enabled = false;
            this.ChangeLabel.Location = new System.Drawing.Point(313, 101);
            this.ChangeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(65, 17);
            this.ChangeLabel.TabIndex = 10;
            this.ChangeLabel.Text = "Modified:";
            // 
            // ChangeDateTimePicker
            // 
            this.ChangeDateTimePicker.Enabled = false;
            this.ChangeDateTimePicker.Location = new System.Drawing.Point(386, 96);
            this.ChangeDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeDateTimePicker.Name = "ChangeDateTimePicker";
            this.ChangeDateTimePicker.Size = new System.Drawing.Size(185, 22);
            this.ChangeDateTimePicker.TabIndex = 3;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(16, 126);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(1033, 377);
            this.NoteTextBox.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(843, 511);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 28);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(951, 511);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.ChangeDateTimePicker);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.CreateDateTimePicker);
            this.Controls.Add(this.CategorysComboBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ShowTitleLabel);
            this.MinimumSize = new System.Drawing.Size(794, 481);
            this.Name = "NoteForm";
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShowTitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox CategorysComboBox;
        private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.DateTimePicker ChangeDateTimePicker;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}