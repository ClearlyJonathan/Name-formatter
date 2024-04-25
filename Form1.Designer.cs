namespace Name_formatter
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
            this.personalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameLabelPrompt = new System.Windows.Forms.Label();
            this.middleNameLabelPrompt = new System.Windows.Forms.Label();
            this.lastNameLabelPrompt = new System.Windows.Forms.Label();
            this.titlePromptLabel = new System.Windows.Forms.Label();
            this.firstNameTextControl = new System.Windows.Forms.TextBox();
            this.middleNameTextControl = new System.Windows.Forms.TextBox();
            this.lastNameTextControl = new System.Windows.Forms.TextBox();
            this.mrCheckBox = new System.Windows.Forms.CheckBox();
            this.mrsCheckBox = new System.Windows.Forms.CheckBox();
            this.msCheckBox = new System.Windows.Forms.CheckBox();
            this.formattingLabelDescription = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.displayButtonControl = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.personalDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalDetailsGroupBox
            // 
            this.personalDetailsGroupBox.Controls.Add(this.msCheckBox);
            this.personalDetailsGroupBox.Controls.Add(this.mrsCheckBox);
            this.personalDetailsGroupBox.Controls.Add(this.mrCheckBox);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameTextControl);
            this.personalDetailsGroupBox.Controls.Add(this.middleNameTextControl);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameTextControl);
            this.personalDetailsGroupBox.Controls.Add(this.titlePromptLabel);
            this.personalDetailsGroupBox.Controls.Add(this.lastNameLabelPrompt);
            this.personalDetailsGroupBox.Controls.Add(this.middleNameLabelPrompt);
            this.personalDetailsGroupBox.Controls.Add(this.firstNameLabelPrompt);
            this.personalDetailsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.personalDetailsGroupBox.Name = "personalDetailsGroupBox";
            this.personalDetailsGroupBox.Size = new System.Drawing.Size(449, 326);
            this.personalDetailsGroupBox.TabIndex = 0;
            this.personalDetailsGroupBox.TabStop = false;
            this.personalDetailsGroupBox.Text = "Personal Information";
            // 
            // firstNameLabelPrompt
            // 
            this.firstNameLabelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabelPrompt.Location = new System.Drawing.Point(33, 52);
            this.firstNameLabelPrompt.Name = "firstNameLabelPrompt";
            this.firstNameLabelPrompt.Size = new System.Drawing.Size(186, 44);
            this.firstNameLabelPrompt.TabIndex = 0;
            this.firstNameLabelPrompt.Text = "First name: ";
            this.firstNameLabelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.firstNameLabelPrompt.Click += new System.EventHandler(this.firstNameLabelPrompt_Click);
            // 
            // middleNameLabelPrompt
            // 
            this.middleNameLabelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabelPrompt.Location = new System.Drawing.Point(33, 116);
            this.middleNameLabelPrompt.Name = "middleNameLabelPrompt";
            this.middleNameLabelPrompt.Size = new System.Drawing.Size(186, 44);
            this.middleNameLabelPrompt.TabIndex = 1;
            this.middleNameLabelPrompt.Text = "Middle name:";
            this.middleNameLabelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameLabelPrompt
            // 
            this.lastNameLabelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabelPrompt.Location = new System.Drawing.Point(33, 183);
            this.lastNameLabelPrompt.Name = "lastNameLabelPrompt";
            this.lastNameLabelPrompt.Size = new System.Drawing.Size(186, 44);
            this.lastNameLabelPrompt.TabIndex = 2;
            this.lastNameLabelPrompt.Text = "Last name:";
            this.lastNameLabelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titlePromptLabel
            // 
            this.titlePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePromptLabel.Location = new System.Drawing.Point(33, 249);
            this.titlePromptLabel.Name = "titlePromptLabel";
            this.titlePromptLabel.Size = new System.Drawing.Size(186, 44);
            this.titlePromptLabel.TabIndex = 3;
            this.titlePromptLabel.Text = "Preferred Title";
            this.titlePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTextControl
            // 
            this.firstNameTextControl.Location = new System.Drawing.Point(252, 64);
            this.firstNameTextControl.Name = "firstNameTextControl";
            this.firstNameTextControl.Size = new System.Drawing.Size(144, 22);
            this.firstNameTextControl.TabIndex = 0;
            this.firstNameTextControl.TextChanged += new System.EventHandler(this.firstNameTextControl_TextChanged);
            // 
            // middleNameTextControl
            // 
            this.middleNameTextControl.Location = new System.Drawing.Point(252, 128);
            this.middleNameTextControl.Name = "middleNameTextControl";
            this.middleNameTextControl.Size = new System.Drawing.Size(144, 22);
            this.middleNameTextControl.TabIndex = 1;
            this.middleNameTextControl.TextChanged += new System.EventHandler(this.middleNameTextControl_TextChanged);
            // 
            // lastNameTextControl
            // 
            this.lastNameTextControl.Location = new System.Drawing.Point(252, 195);
            this.lastNameTextControl.Name = "lastNameTextControl";
            this.lastNameTextControl.Size = new System.Drawing.Size(144, 22);
            this.lastNameTextControl.TabIndex = 2;
            this.lastNameTextControl.TextChanged += new System.EventHandler(this.lastNameTextControl_TextChanged);
            // 
            // mrCheckBox
            // 
            this.mrCheckBox.AutoSize = true;
            this.mrCheckBox.Location = new System.Drawing.Point(252, 263);
            this.mrCheckBox.Name = "mrCheckBox";
            this.mrCheckBox.Size = new System.Drawing.Size(47, 20);
            this.mrCheckBox.TabIndex = 3;
            this.mrCheckBox.Text = "Mr.";
            this.mrCheckBox.UseVisualStyleBackColor = true;
            this.mrCheckBox.CheckedChanged += new System.EventHandler(this.mrCheckBox_CheckedChanged);
            // 
            // mrsCheckBox
            // 
            this.mrsCheckBox.AutoSize = true;
            this.mrsCheckBox.Location = new System.Drawing.Point(305, 263);
            this.mrsCheckBox.Name = "mrsCheckBox";
            this.mrsCheckBox.Size = new System.Drawing.Size(54, 20);
            this.mrsCheckBox.TabIndex = 9;
            this.mrsCheckBox.Text = "Mrs.";
            this.mrsCheckBox.UseVisualStyleBackColor = true;
            this.mrsCheckBox.CheckedChanged += new System.EventHandler(this.mrsCheckBox_CheckedChanged);
            // 
            // msCheckBox
            // 
            this.msCheckBox.AutoSize = true;
            this.msCheckBox.Location = new System.Drawing.Point(365, 263);
            this.msCheckBox.Name = "msCheckBox";
            this.msCheckBox.Size = new System.Drawing.Size(50, 20);
            this.msCheckBox.TabIndex = 10;
            this.msCheckBox.Text = "Ms.";
            this.msCheckBox.UseVisualStyleBackColor = true;
            this.msCheckBox.CheckedChanged += new System.EventHandler(this.msCheckBox_CheckedChanged);
            // 
            // formattingLabelDescription
            // 
            this.formattingLabelDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattingLabelDescription.Location = new System.Drawing.Point(468, 12);
            this.formattingLabelDescription.Name = "formattingLabelDescription";
            this.formattingLabelDescription.Size = new System.Drawing.Size(300, 38);
            this.formattingLabelDescription.TabIndex = 11;
            this.formattingLabelDescription.Text = "Choose your formatting style";
            this.formattingLabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "Title. First, Middle, Last",
            "First, Middle, Last",
            "First, Last",
            "Last, First, Middle, Title",
            "Last, First, Middle",
            "Last, First",
            "None"});
            this.listBox1.Location = new System.Drawing.Point(486, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 280);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // displayButtonControl
            // 
            this.displayButtonControl.Location = new System.Drawing.Point(12, 428);
            this.displayButtonControl.Name = "displayButtonControl";
            this.displayButtonControl.Size = new System.Drawing.Size(128, 61);
            this.displayButtonControl.TabIndex = 1;
            this.displayButtonControl.Text = "Format Name";
            this.displayButtonControl.UseVisualStyleBackColor = true;
            this.displayButtonControl.Click += new System.EventHandler(this.displayButtonControl_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(333, 428);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(128, 61);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear Button";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(629, 428);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 61);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 609);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayButtonControl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.formattingLabelDescription);
            this.Controls.Add(this.personalDetailsGroupBox);
            this.Name = "Form1";
            this.Text = "Name Formatter";
            this.personalDetailsGroupBox.ResumeLayout(false);
            this.personalDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalDetailsGroupBox;
        private System.Windows.Forms.Label firstNameLabelPrompt;
        private System.Windows.Forms.Label lastNameLabelPrompt;
        private System.Windows.Forms.Label middleNameLabelPrompt;
        private System.Windows.Forms.TextBox lastNameTextControl;
        private System.Windows.Forms.TextBox middleNameTextControl;
        private System.Windows.Forms.TextBox firstNameTextControl;
        private System.Windows.Forms.Label titlePromptLabel;
        private System.Windows.Forms.CheckBox msCheckBox;
        private System.Windows.Forms.CheckBox mrsCheckBox;
        private System.Windows.Forms.CheckBox mrCheckBox;
        private System.Windows.Forms.Label formattingLabelDescription;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button displayButtonControl;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

