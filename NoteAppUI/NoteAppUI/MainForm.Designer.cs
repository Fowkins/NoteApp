namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerNote = new System.Windows.Forms.SplitContainer();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.ShowCatgoryLabel = new System.Windows.Forms.Label();
            this.TitleListBox = new System.Windows.Forms.ListBox();
            this.CategorysComboBox = new System.Windows.Forms.ComboBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChangeTextLabel = new System.Windows.Forms.Label();
            this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateTextLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNote)).BeginInit();
            this.splitContainerNote.Panel1.SuspendLayout();
            this.splitContainerNote.Panel2.SuspendLayout();
            this.splitContainerNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // splitContainerNote
            // 
            this.splitContainerNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerNote.Location = new System.Drawing.Point(0, 33);
            this.splitContainerNote.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerNote.Name = "splitContainerNote";
            // 
            // splitContainerNote.Panel1
            // 
            this.splitContainerNote.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainerNote.Panel1.Controls.Add(this.ChangeButton);
            this.splitContainerNote.Panel1.Controls.Add(this.NewButton);
            this.splitContainerNote.Panel1.Controls.Add(this.ShowCatgoryLabel);
            this.splitContainerNote.Panel1.Controls.Add(this.TitleListBox);
            this.splitContainerNote.Panel1.Controls.Add(this.CategorysComboBox);
            // 
            // splitContainerNote.Panel2
            // 
            this.splitContainerNote.Panel2.Controls.Add(this.NoteTextBox);
            this.splitContainerNote.Panel2.Controls.Add(this.ChangeDateTimePicker);
            this.splitContainerNote.Panel2.Controls.Add(this.ChangeTextLabel);
            this.splitContainerNote.Panel2.Controls.Add(this.CreateDateTimePicker);
            this.splitContainerNote.Panel2.Controls.Add(this.CreateTextLabel);
            this.splitContainerNote.Panel2.Controls.Add(this.CategoryTextBox);
            this.splitContainerNote.Panel2.Controls.Add(this.TitleTextBox);
            this.splitContainerNote.Size = new System.Drawing.Size(1099, 527);
            this.splitContainerNote.SplitterDistance = 320;
            this.splitContainerNote.SplitterWidth = 5;
            this.splitContainerNote.TabIndex = 15;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Image = global::NoteAppUI.Properties.Resources.delete__1_;
            this.DeleteButton.Location = new System.Drawing.Point(124, 471);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(46, 43);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeButton.Image = global::NoteAppUI.Properties.Resources.edit;
            this.ChangeButton.Location = new System.Drawing.Point(70, 471);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(46, 43);
            this.ChangeButton.TabIndex = 11;
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewButton.Image = global::NoteAppUI.Properties.Resources.add__1_;
            this.NewButton.Location = new System.Drawing.Point(16, 471);
            this.NewButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(46, 43);
            this.NewButton.TabIndex = 8;
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // ShowCatgoryLabel
            // 
            this.ShowCatgoryLabel.AutoSize = true;
            this.ShowCatgoryLabel.Enabled = false;
            this.ShowCatgoryLabel.Location = new System.Drawing.Point(16, 19);
            this.ShowCatgoryLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ShowCatgoryLabel.Name = "ShowCatgoryLabel";
            this.ShowCatgoryLabel.Size = new System.Drawing.Size(107, 17);
            this.ShowCatgoryLabel.TabIndex = 10;
            this.ShowCatgoryLabel.Text = "Show Category:";
            // 
            // TitleListBox
            // 
            this.TitleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleListBox.FormattingEnabled = true;
            this.TitleListBox.ItemHeight = 16;
            this.TitleListBox.Location = new System.Drawing.Point(16, 53);
            this.TitleListBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleListBox.Name = "TitleListBox";
            this.TitleListBox.Size = new System.Drawing.Size(297, 404);
            this.TitleListBox.TabIndex = 1;
            this.TitleListBox.SelectedIndexChanged += new System.EventHandler(this.TitleListBox_SelectedIndexChanged);
            // 
            // CategorysComboBox
            // 
            this.CategorysComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorysComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategorysComboBox.FormattingEnabled = true;
            this.CategorysComboBox.Location = new System.Drawing.Point(140, 18);
            this.CategorysComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategorysComboBox.Name = "CategorysComboBox";
            this.CategorysComboBox.Size = new System.Drawing.Size(173, 24);
            this.CategorysComboBox.TabIndex = 0;
            this.CategorysComboBox.TabStop = false;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NoteTextBox.Location = new System.Drawing.Point(4, 101);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(763, 415);
            this.NoteTextBox.TabIndex = 6;
            // 
            // ChangeDateTimePicker
            // 
            this.ChangeDateTimePicker.Enabled = false;
            this.ChangeDateTimePicker.Location = new System.Drawing.Point(365, 65);
            this.ChangeDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeDateTimePicker.MaximumSize = new System.Drawing.Size(183, 20);
            this.ChangeDateTimePicker.MinimumSize = new System.Drawing.Size(172, 20);
            this.ChangeDateTimePicker.Name = "ChangeDateTimePicker";
            this.ChangeDateTimePicker.Size = new System.Drawing.Size(181, 20);
            this.ChangeDateTimePicker.TabIndex = 5;
            // 
            // ChangeTextLabel
            // 
            this.ChangeTextLabel.AutoSize = true;
            this.ChangeTextLabel.Enabled = false;
            this.ChangeTextLabel.Location = new System.Drawing.Point(292, 65);
            this.ChangeTextLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeTextLabel.MinimumSize = new System.Drawing.Size(60, 13);
            this.ChangeTextLabel.Name = "ChangeTextLabel";
            this.ChangeTextLabel.Size = new System.Drawing.Size(65, 17);
            this.ChangeTextLabel.TabIndex = 12;
            this.ChangeTextLabel.Text = "Modified:";
            // 
            // CreateDateTimePicker
            // 
            this.CreateDateTimePicker.Enabled = false;
            this.CreateDateTimePicker.Location = new System.Drawing.Point(72, 65);
            this.CreateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.CreateDateTimePicker.MaximumSize = new System.Drawing.Size(183, 20);
            this.CreateDateTimePicker.MinimumSize = new System.Drawing.Size(172, 20);
            this.CreateDateTimePicker.Name = "CreateDateTimePicker";
            this.CreateDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.CreateDateTimePicker.TabIndex = 4;
            // 
            // CreateTextLabel
            // 
            this.CreateTextLabel.AutoSize = true;
            this.CreateTextLabel.Enabled = false;
            this.CreateTextLabel.Location = new System.Drawing.Point(2, 65);
            this.CreateTextLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTextLabel.Name = "CreateTextLabel";
            this.CreateTextLabel.Size = new System.Drawing.Size(62, 17);
            this.CreateTextLabel.TabIndex = 13;
            this.CreateTextLabel.Text = "Created:";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTextBox.Location = new System.Drawing.Point(4, 42);
            this.CategoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(253, 15);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTextBox.Location = new System.Drawing.Point(4, 1);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(764, 29);
            this.TitleTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 560);
            this.Controls.Add(this.splitContainerNote);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(834, 481);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerNote.Panel1.ResumeLayout(false);
            this.splitContainerNote.Panel1.PerformLayout();
            this.splitContainerNote.Panel2.ResumeLayout(false);
            this.splitContainerNote.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNote)).EndInit();
            this.splitContainerNote.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerNote;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Label ShowCatgoryLabel;
        private System.Windows.Forms.ListBox TitleListBox;
        private System.Windows.Forms.ComboBox CategorysComboBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.DateTimePicker ChangeDateTimePicker;
        private System.Windows.Forms.Label ChangeTextLabel;
        private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
        private System.Windows.Forms.Label CreateTextLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

