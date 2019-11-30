namespace BindingListsInstantly
{
    partial class Form1
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.surNameLabel = new System.Windows.Forms.Label();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(372, 258);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 84);
            this.listBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(394, 197);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // surNameLabel
            // 
            this.surNameLabel.AutoSize = true;
            this.surNameLabel.Location = new System.Drawing.Point(308, 149);
            this.surNameLabel.Name = "surNameLabel";
            this.surNameLabel.Size = new System.Drawing.Size(69, 17);
            this.surNameLabel.TabIndex = 9;
            this.surNameLabel.Text = "Surname:";
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.Location = new System.Drawing.Point(381, 146);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.surNameTextBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(308, 112);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(381, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.surNameLabel);
            this.Controls.Add(this.surNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Label surNameLabel;
    }
}

